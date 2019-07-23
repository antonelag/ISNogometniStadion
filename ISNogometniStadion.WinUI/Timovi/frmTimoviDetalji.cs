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

namespace ISNogometniStadion.WinUI.Timovi
{
    public partial class frmTimoviDetalji : Form
    {
        private readonly int? _id = null;
        private readonly APIService _apiService = new APIService("Timovi");
        public frmTimoviDetalji(int? id=null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void FrmTimoviDetalji_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stadioniDataSet.Stadioni' table. You can move, or remove it, as needed.
            this.stadioniTableAdapter.Fill(this.stadioniDataSet.Stadioni);
            // TODO: This line of code loads data into the 'iSNogometniStadionDBDataSet.Stadioni' table. You can move, or remove it, as needed.
            if (_id.HasValue)
            {
                var a = await _apiService.GetById<dynamic>(_id);
                txtNaziv.Text = a.naziv;
                txtOpis.Text = a.opis;
                cbTimovi.SelectedValue = int.Parse(a.stadionID.ToString());
            }
        }

        private void TxtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                errorProvider1.SetError(txtNaziv, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtNaziv, null);
        }

        private void TxtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOpis.Text))
            {
                errorProvider1.SetError(txtOpis, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtOpis, null);
        }

        private void CbTimovi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbTimovi.SelectedValue.ToString()))
            {
                errorProvider1.SetError(cbTimovi, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(cbTimovi, null);
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var res = new TimoviInsertRequest()
                {
                    Naziv = txtNaziv.Text,
                    Opis = txtOpis.Text,
                    StadionID = int.Parse(cbTimovi.SelectedValue.ToString())
                };

                if (_id.HasValue)
                    await _apiService.Update<dynamic>(_id, res);
                else
                    await _apiService.Insert<dynamic>(res);
                MessageBox.Show("Operacija je uspjela.");
                this.Close();
            }
            
            else
                MessageBox.Show("Operacija nije uspjela");
        }
    }
}
