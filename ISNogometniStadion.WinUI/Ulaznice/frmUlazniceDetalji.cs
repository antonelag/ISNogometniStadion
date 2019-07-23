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

namespace ISNogometniStadion.WinUI.Ulaznice
{
    public partial class frmUlazniceDetalji : Form
    {
        private readonly int? _id = null;
        private readonly APIService _apiService = new APIService("Ulaznica");
        public frmUlazniceDetalji(int? id=null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void FrmUlazniceDetalji_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'korisniciDBDataSet.Korisnici' table. You can move, or remove it, as needed.
            this.korisniciTableAdapter.Fill(this.korisniciDBDataSet.Korisnici);
            // TODO: This line of code loads data into the 'iSNogometniStadionDBDataSet.Korisnici' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'utakmiceDBDataSet.Utakmice' table. You can move, or remove it, as needed.
            this.utakmiceTableAdapter.Fill(this.utakmiceDBDataSet.Utakmice);
            // TODO: This line of code loads data into the 'sjedalaDBDataSet.Sjedala' table. You can move, or remove it, as needed.
            this.sjedalaTableAdapter.Fill(this.sjedalaDBDataSet.Sjedala);
            cbSjedala.SelectedItem = null;
            cbSjedala.SelectedText = "--Odaberite--";
            cbUtakmica.SelectedItem = null;
            cbUtakmica.SelectedText = "--Odaberite--";
            cbKorisnik.SelectedItem = null;
            cbKorisnik.SelectedText = "--Odaberite--";
            if (_id.HasValue)
            {
                var a = await _apiService.GetById<dynamic>(_id);
                cbSjedala.SelectedValue = int.Parse(a.sjedaloID.ToString());
                cbUtakmica.SelectedValue = int.Parse(a.utakmicaID.ToString());
                cbKorisnik.SelectedValue = int.Parse(a.korisnikID.ToString());
                dtpDatum.Value = a.datumKupnje;
                dtpVrijeme.Value = a.vrijemeKupnje;
            }
        }

        private void CbSjedala_Validating(object sender, CancelEventArgs e)
        {
            if (cbSjedala.SelectedItem == null)
            {
                errorProvider1.SetError(cbSjedala, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(cbSjedala, null);

        }

        private void CbUtakmica_Validating(object sender, CancelEventArgs e)
        {

            if (cbUtakmica.SelectedItem == null)
            {
                errorProvider1.SetError(cbUtakmica, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(cbUtakmica, null);
        }

        private void CbKorisnik_Validating(object sender, CancelEventArgs e)
        {
            if (cbKorisnik.SelectedItem==null)
            {
                errorProvider1.SetError(cbKorisnik, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(cbKorisnik, null);
        }

        private void DtpDatum_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dtpDatum.Value.ToString()))
            {
                errorProvider1.SetError(dtpDatum, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(dtpDatum, null);
        }

        private void DtpVrijeme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dtpVrijeme.Value.ToString()))
            {
                errorProvider1.SetError(dtpVrijeme, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(dtpVrijeme, null);
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var req = new UlazniceInsertRequest()
                {
                    DatumKupnje = dtpDatum.Value.Date+dtpVrijeme.Value.TimeOfDay,
                    VrijemeKupnje =dtpDatum.Value.Date + dtpVrijeme.Value.TimeOfDay,
                    KorisnikID = int.Parse(cbKorisnik.SelectedValue.ToString()),
                    SjedaloID = int.Parse(cbSjedala.SelectedValue.ToString()),
                    UtakmicaID = int.Parse(cbUtakmica.SelectedValue.ToString())
                };
                if (_id.HasValue)
                    await _apiService.Update<dynamic>(_id, req);
                else
                    await _apiService.Insert<dynamic>(req);

                MessageBox.Show("Operacija uspjela");
                this.Close();
            }
            else
                MessageBox.Show("Operacija nije uspjela!");
        }
    }
}
