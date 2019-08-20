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
        private readonly APIService _apiServiceFradovi = new APIService("Gradovi");

        public frmStadionDetalji(int? id = null)
        {
            _id = id;
            InitializeComponent();
        }

        private async void FrmStadionDetalji_Load(object sender, EventArgs e)
        {
            await LoadGradovi();
            if (_id.HasValue)
            {
                var r = await _apiService.GetById<dynamic>(_id);
                txtNaziv.Text = r.naziv;
                txtOpis.Text = r.opis;
                cbStadioni.SelectedValue = int.Parse(r.gradID.ToString());
            }

        }
        private async Task LoadGradovi()
        {
            var result = await _apiServiceFradovi.Get<List<Model.Grad>>(null);
            cbStadioni.DisplayMember = "Naziv";
            cbStadioni.ValueMember = "GradID";
            cbStadioni.SelectedItem = null;
            cbStadioni.SelectedText = "--Odaberite--";
            cbStadioni.DataSource = result;
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
            if (cbStadioni.SelectedItem==null)
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
                    Opis=txtOpis.Text,
                    GradID = int.Parse(cbStadioni.SelectedValue.ToString())
                };
            

                if (_id.HasValue)
                {
                    int i = (int)_id;
                    await _apiService.Update<dynamic>(i, req);
                }
                else
                    await _apiService.Insert<dynamic>(req);
                MessageBox.Show("Operacija uspjesna!");
                this.Close();
            }
            else
                MessageBox.Show("Operacija nije uspjela");
        }

        private void TxtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOpis.Text))
            {
                errorProvider1.SetError(txtOpis, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;

            }
            else
                errorProvider1.SetError(txtOpis, null);
        }
    }
    }

