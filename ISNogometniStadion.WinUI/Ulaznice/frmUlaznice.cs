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

namespace ISNogometniStadion.WinUI.Ulaznice
{
    public partial class FrmUlaznice : Form
    {
        private readonly APIService _apiService = new APIService("Ulaznica");
        private readonly APIService _apiServiceKorisnici = new APIService("Korisnici");

        public FrmUlaznice()
        {
            InitializeComponent();
        }

        private void DgvUlaznice_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvUlaznice.SelectedRows[0].Cells[0].Value;
            FrmUlazniceDetalji frm = new FrmUlazniceDetalji(int.Parse(id.ToString()));
            frm.Show();
        }


        private async void CbKorisniciPretraga_SelectedIndexChanged(object sender, EventArgs e)
        {

            var idObj = cbKorisniciPretraga.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadUlaznice(id);
            }


        }
        private async Task LoadSviKorisnici()
        {
            var result = await _apiServiceKorisnici.Get<List<Model.Korisnik>>(null);
            cbKorisniciPretraga.DisplayMember = "KorisnikPodaci";
            cbKorisniciPretraga.ValueMember = "KorisnikID";
            result.Insert(0, new Model.Korisnik());
            cbKorisniciPretraga.DataSource = result;
            cbKorisniciPretraga.Text = "--Odaberite korisnika--";
        }
        private async Task LoadUlaznice(int id)
        {
            var result = await _apiService.Get<List<Model.Ulaznica>>(new UlazniceSearchRequest()
            {
                KorisnikID = id
            });
            dgvUlaznice.AutoGenerateColumns = false;
            dgvUlaznice.DataSource = result;
        }

        private async void FrmUlaznice_Load(object sender, EventArgs e)
        {
            await LoadSviKorisnici();
        }
    }
}
