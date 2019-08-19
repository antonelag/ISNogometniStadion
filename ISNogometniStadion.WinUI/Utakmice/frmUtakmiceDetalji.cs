using ISNogometniStadion.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISNogometniStadion.WinUI.Utakmice
{
    public partial class frmUtakmiceDetalji : Form
    {
        private readonly int? _id = null;
        private readonly APIService _apiService = new APIService("Utakmice");
        private readonly APIService _apiServiceStadioni = new APIService("Stadioni");
        private readonly APIService _apiServiceTimovi = new APIService("Timovi");
        private readonly APIService _apiServiceLige = new APIService("Lige");
        public frmUtakmiceDetalji(int? id=null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void FrmUtakmiceDetalji_Load(object sender, EventArgs e)
        {
            await LoadDomaci();
            await LoadGosti();
            await LoadStadioni();
            await LoadLige();

            if (_id.HasValue)
            {
                var a = await _apiService.GetById<dynamic>(_id);
                cbDomaci.SelectedValue = int.Parse(a.domaciTimID.ToString());
                cbGosti.SelectedValue = int.Parse(a.gostujuciTimID.ToString());
                dtpDatum.Value = a.datumOdigravanja;
                dtpVrijeme.Value = a.vrijemeOdigravanja;
                cbStadion.SelectedValue = int.Parse(a.stadionID.ToString());
                cbLiga.SelectedValue = int.Parse(a.ligaID.ToString());

            }

        }
        private async Task LoadStadioni()
        {
            var result = await _apiServiceStadioni.Get<List<Model.Stadion>>(null);
            cbStadion.DisplayMember = "Naziv";
            cbStadion.ValueMember = "StadionID";
            cbStadion.SelectedItem = null;
            cbStadion.SelectedText = "--Odaberite--";
            cbStadion.DataSource = result;
        }
        private async Task LoadLige()
        {
            var result = await _apiServiceLige.Get<List<Model.Liga>>(null);
            cbLiga.DisplayMember = "Naziv";
            cbLiga.ValueMember = "LigaID";
            cbLiga.SelectedItem = null;
            cbLiga.SelectedText = "--Odaberite--";
            cbLiga.DataSource = result;
        }
        private async Task LoadDomaci()
        {
            var result = await _apiServiceTimovi.Get<List<Model.Tim>>(null);
            cbDomaci.DisplayMember = "Naziv";
            cbDomaci.ValueMember = "TimID";
            cbDomaci.SelectedItem = null;
            cbDomaci.SelectedText = "--Odaberite--";
            cbDomaci.DataSource = result;
           
        }
        private async Task LoadGosti()
        {
            var result = await _apiServiceTimovi.Get<List<Model.Tim>>(null);
            
            cbGosti.DisplayMember = "Naziv";
            cbGosti.ValueMember = "TimID";
            cbGosti.SelectedItem = null;
            cbGosti.SelectedText = "--Odaberite--";
            cbGosti.DataSource = result;
        }

        private void CbDomaci_Validating(object sender, CancelEventArgs e)
        {
            if (cbDomaci.SelectedItem == null && int.Parse(cbDomaci.SelectedValue.ToString())!= int.Parse(cbGosti.SelectedValue.ToString()))
            {
                errorProvider1.SetError(cbDomaci, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(cbDomaci, null);
        }

        private void CbGosti_Validating(object sender, CancelEventArgs e)
        {
            if (cbGosti.SelectedItem == null)
            {
                errorProvider1.SetError(cbGosti, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(cbGosti, null);
        }

        private void CbStadion_Validating(object sender, CancelEventArgs e)
        {
            if (cbStadion.SelectedItem == null)
            {
                errorProvider1.SetError(cbStadion, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(cbStadion, null);
        }

        private void DtpDatum_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dtpDatum.Value.Date.ToString()))
            {
                errorProvider1.SetError(dtpDatum, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
            errorProvider1.SetError(dtpDatum, null);

        }

        private void DtpVrijeme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dtpVrijeme.Value.TimeOfDay.ToString()))
            {
                errorProvider1.SetError(dtpVrijeme, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(dtpVrijeme, null);

        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() && int.Parse(cbDomaci.SelectedValue.ToString()) != int.Parse(cbGosti.SelectedValue.ToString()))
            {


                //radi nemogucnosti nacina da na razini baze ogranicimo unos zamjene timova(gosti/domaci) a istog datuma

                var t = await _apiService.Get<List<Model.Utakmica>>(null);
                var domaciid = int.Parse(cbDomaci.SelectedValue.ToString());
                var gostiid = int.Parse(cbGosti.SelectedValue.ToString());
                var obrnutiisti = false;
                var isti = false;
                foreach (var a in t)
                {
                    if ((a.GostujuciTimID == domaciid || a.DomaciTimID == gostiid) && DateTime.Compare(a.DatumOdigravanja.Date, dtpDatum.Value.Date) == 0 && a.UtakmicaID != _id)
                    {
                        obrnutiisti = true;
                        break;
                    }

                }
                foreach (var a in t)
                {
                    if ((a.GostujuciTimID == gostiid || a.DomaciTimID == domaciid) && DateTime.Compare(a.DatumOdigravanja.Date, dtpDatum.Value.Date) == 0 && a.UtakmicaID!=_id)
                    {
                        isti = true;
                        break;
                    }

                }

                if (!obrnutiisti && !isti)
                {
                    var req = new UtakmiceInsertRequest()
                    {
                        DatumOdigravanja = dtpDatum.Value.Date + dtpVrijeme.Value.TimeOfDay,
                        VrijemeOdigravanja = dtpDatum.Value.Date + dtpVrijeme.Value.TimeOfDay,
                        DomaciTimID = int.Parse(cbDomaci.SelectedValue.ToString()),
                        GostujuciTimID = int.Parse(cbGosti.SelectedValue.ToString()),
                        StadionID = int.Parse(cbStadion.SelectedValue.ToString()),
                        LigaID = int.Parse(cbLiga.SelectedValue.ToString())

                    };
                    if (_id.HasValue)
                    {
                        int i = (int)_id;
                        await _apiService.Update<dynamic>(i, req);
                    }
                    else
                        await _apiService.Insert<dynamic>(req);
                    MessageBox.Show("Operacija uspjela");
                    this.Close();
                }
                else
                    MessageBox.Show("Operacija nije uspjela");

                
            }
            else
                MessageBox.Show("Operacija nije uspjela");
        }
    }
}
