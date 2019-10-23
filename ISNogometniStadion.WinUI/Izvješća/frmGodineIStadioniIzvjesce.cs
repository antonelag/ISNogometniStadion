using ISNogometniStadion.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISNogometniStadion.WinUI.Izvješća
{
    public partial class FrmGodineIStadioniIzvjesce : Form
    {
        public APIService _apiServiceStadioni = new APIService("Stadioni");
        public APIService _apiServiceUlaznice = new APIService("Ulaznica");
        public APIService _apiServiceUtakmice = new APIService("Utakmice");
        public APIService _apiServiceTribine = new APIService("Tribine");
        public APIService _apiServiceSektori = new APIService("Sektori");



        public FrmGodineIStadioniIzvjesce()
        {
            InitializeComponent();
        }

        private void FrmGodineIStadioniIzvjesce_Load(object sender, EventArgs e)
        {
            LoadGodine();
        }




        private void LoadGodine()
        {
            var gZ = DateTime.Now.Year + 10;
            var gP = 2014;
            for (int i = gP; i <= gZ; i++)
            {
                cbGodina.Items.Add(i);
            }
        }
        private async Task LoadIzvjesce(int idGodina)
        {
            var stadioni = await _apiServiceStadioni.Get<List<Model.Stadion>>(null);
            List<Stadion> listaStadiona = new List<Stadion>();
            List<Utakmica> listaUtakmica = new List<Utakmica>();
            List<IzvjesceGodine> lista = new List<IzvjesceGodine>();
            foreach (var s in stadioni)
            {
                int brojUlaznica = 0;
                decimal UkupnaZarada = 0;
                var tribine = await _apiServiceTribine.Get<List<Tribina>>(new TribineSearchRequest() { StadionID = s.StadionID });
                var utakmice = await _apiServiceUtakmice.Get<List<Utakmica>>(new UtakmiceeSearchRequest() { StadionID = s.StadionID });
                foreach (var ut in utakmice)
                {
                    var ulaznice = await _apiServiceUlaznice.Get<List<Ulaznica>>(new UlazniceSearchRequest() { Godina = idGodina, UtakmicaID = ut.UtakmicaID });
                    foreach (var ul in ulaznice)
                    {
                        brojUlaznica++;
                        var sektori = await _apiServiceSektori.Get<List<Sektor>>(new SektoriSearchRequest() { Naziv = ul.sektor });
                        foreach (var sek in sektori)
                        {
                            foreach (var t in tribine)
                            {
                                if (sek.TribinaID == t.TribinaID)
                                    UkupnaZarada += t.Cijena;
                            }
                        }
                    }
                }
                lista.Add(new IzvjesceGodine() { Stadion = s.Naziv, Grad = s.Grad, Zarada = UkupnaZarada, BrojProdanihUlaznica = brojUlaznica });
            }

            dgvIzvješće.DataSource = lista;


        }

        private async void CbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cbGodina.SelectedItem;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadIzvjesce(id);
            }
        }
    }
}
