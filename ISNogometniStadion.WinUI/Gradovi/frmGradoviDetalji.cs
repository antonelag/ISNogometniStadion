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

namespace ISNogometniStadion.WinUI.Gradovi
{
    public partial class frmGradoviDetalji : Form
    {
        private readonly int? _id = null;
        private readonly APIService _apiService = new APIService("Gradovi");
        private readonly APIService _apiServiceDrzave = new APIService("Drzave");

        public frmGradoviDetalji(int? id = null)
        {
            _id = id;
            InitializeComponent();
        }

        private async void FrmGradoviDetalji_Load(object sender, EventArgs e)
        {
            await LoadDrzave();
            if (_id.HasValue)
            {
                var a = await _apiService.GetById<dynamic>(_id);
                txtNaziv.Text = a.naziv;
                cbDrzave.SelectedValue = a.drzavaID;
            };
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var req = new GradoviInsertRequest
                {
                    Naziv = txtNaziv.Text,
                    DrzavaID = (int)cbDrzave.SelectedValue
                };
                if (_id.HasValue)
                {
                    int i =(int) _id;
                    await _apiService.Update<dynamic>(i, req);
                }
                else
                    await _apiService.Insert<dynamic>(req);

                MessageBox.Show("Operacija uspjela!");
                this.Close();

            }
            else
            {
                MessageBox.Show("Operacija nije uspjela!");
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

        private void CbDrzave_Validating(object sender, CancelEventArgs e)
        {
            if (cbDrzave.SelectedItem==null)
            {
                errorProvider1.SetError(cbDrzave, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(cbDrzave, null);
        }
        private async Task LoadDrzave()
        {
            var result = await _apiServiceDrzave.Get<List<Model.Drzava>>(null);
            cbDrzave.DisplayMember = "Naziv";
            cbDrzave.ValueMember = "DrzavaID";
            cbDrzave.DataSource = result;
            cbDrzave.SelectedItem = null;
            cbDrzave.SelectedText = "--Odaberite--";
        }
    }
}
    
