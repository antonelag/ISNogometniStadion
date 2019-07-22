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

namespace ISNogometniStadion.WinUI.Stadioni
{
    public partial class frmStadionDetalji : Form
    {
        private readonly int? _id = null;
        private readonly APIService _apiService = new APIService("Stadioni");
        public frmStadionDetalji(int? id = null)
        {
            _id = id;
            InitializeComponent();
        }

        private async void FrmStadionDetalji_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gradoviDataSet.Gradovi' table. You can move, or remove it, as needed.
            this.gradoviTableAdapter.Fill(this.gradoviDataSet.Gradovi);
            if (_id.HasValue)
            {
                var r = await _apiService.GetById<dynamic>(_id);
                txtNaziv.Text = r.naziv;
                cbStadioni.SelectedValue = int.Parse(r.gradID.ToString());
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

        private void CbStadioni_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbStadioni.SelectedValue.ToString()))
            {
                errorProvider1.SetError(cbStadioni, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;

            }
            else
                errorProvider1.SetError(cbStadioni, null);
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var req = new StadioniInsertRequest()
                {
                    Naziv = txtNaziv.Text,
                    GradID = int.Parse(cbStadioni.SelectedValue.ToString())
                };
            

                if (_id.HasValue)
                    await _apiService.Update<dynamic>(_id, req);
                else
                    await _apiService.Insert<dynamic>(req);
                MessageBox.Show("Operacija uspjesna!");
                this.Close();
            }
            else
                MessageBox.Show("Operacija nije uspjela");
        }

        }
    }

