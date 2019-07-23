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

namespace ISNogometniStadion.WinUI.Tribine
{
    public partial class frmTribineDetalji : Form
    {
        private readonly int? _id = null;
        private readonly APIService _apiService = new APIService("Tribine");
        public frmTribineDetalji(int? id=null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void FrmTribineDetalji_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stadioniDataSet.Stadioni' table. You can move, or remove it, as needed.
            this.stadioniTableAdapter.Fill(this.stadioniDataSet.Stadioni);
            if (_id.HasValue)
            {
                var a = await _apiService.GetById<dynamic>(_id);
                txtNaziv.Text = a.naziv;
                cbTribine.SelectedValue = int.Parse(a.stadionID.ToString());
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

        private void CbTribine_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbTribine.SelectedValue.ToString()))
            {
                errorProvider1.SetError(cbTribine, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(cbTribine, null);
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var req = new TribineInsertRequest()
                {
                    Naziv = txtNaziv.Text,
                    StadionID = int.Parse(cbTribine.SelectedValue.ToString())
                };
                if (_id.HasValue)
                    await _apiService.Update<dynamic>(_id, req);
                else
                    await _apiService.Insert<dynamic>(req);
                MessageBox.Show("Operacija uspjela!");
                this.Close();

            }
            else
                MessageBox.Show("Operacija nije uspjela");
        }
    }
}
