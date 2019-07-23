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
        public frmUtakmiceDetalji(int? id=null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void FrmUtakmiceDetalji_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timovi2DBDataSet.Timovi' table. You can move, or remove it, as needed.
            this.timoviTableAdapter1.Fill(this.timovi2DBDataSet.Timovi);
            // TODO: This line of code loads data into the 'stadioniDataSet.Stadioni' table. You can move, or remove it, as needed.
            this.stadioniTableAdapter.Fill(this.stadioniDataSet.Stadioni);
            // TODO: This line of code loads data into the 'timoviDBDataSet.Timovi' table. You can move, or remove it, as needed.
            this.timoviTableAdapter.Fill(this.timoviDBDataSet.Timovi);
            cbDomaci.SelectedItem = null;
            cbDomaci.SelectedText = "--Odaberite--";
            cbGosti.SelectedItem = null;
            cbGosti.SelectedText = "--Odaberite--";
            cbStadion.SelectedItem = null;
            cbStadion.SelectedText = "--Odaberite--";

            if (_id.HasValue)
            {
                var a = await _apiService.GetById<dynamic>(_id);
                cbDomaci.SelectedValue = int.Parse(a.domaciTimID.ToString());
                cbGosti.SelectedValue = int.Parse(a.gostujuciTimID.ToString());
                dtpDatum.Value = a.datumOdigravanja;
                dtpVrijeme.Value = a.vrijemeOdigravanja;
                cbStadion.SelectedValue = int.Parse(a.stadionID.ToString());
            }

        }

        private void CbDomaci_Validating(object sender, CancelEventArgs e)
        {
            if (cbDomaci.SelectedItem == null)
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
            if (this.ValidateChildren())
            {

                var req = new UtakmiceInsertRequest()
                {
                    DatumOdigravanja = dtpDatum.Value.Date + dtpVrijeme.Value.TimeOfDay,
                    VrijemeOdigravanja = dtpDatum.Value.Date + dtpVrijeme.Value.TimeOfDay,
                    DomaciTimID = int.Parse(cbDomaci.SelectedValue.ToString()),
                    GostujuciTimID = int.Parse(cbGosti.SelectedValue.ToString()),
                    StadionID = int.Parse(cbStadion.SelectedValue.ToString())
                };
                if (_id.HasValue)
                    await _apiService.Update<dynamic>(_id, req);
                else
                    await _apiService.Insert<dynamic>(req);
                MessageBox.Show("Operacija uspjela");
                this.Close();
            }
            else
                MessageBox.Show("Operacija nije uspjela");
        }
    }
}
