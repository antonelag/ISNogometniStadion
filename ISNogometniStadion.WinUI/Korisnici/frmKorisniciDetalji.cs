using ISNogometniStadion.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISNogometniStadion.WinUI.Korisnici
{
    public partial class frmKorisniciDetalji : Form
    {
        private readonly int? _id = null;
        private readonly APIService _apiService = new APIService("Korisnici");
        private readonly APIService _apiServiceGradovi = new APIService("Gradovi");
        public frmKorisniciDetalji(int? KorisnikID=null)
        {
            _id = KorisnikID;
            InitializeComponent();
        }

        private async void  BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
             

                var request = new KorisniciInsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    email = txtEmail.Text,
                    DatumRodjenja = dpdatumRodjenja.Value,
                    telefon = txtTelefon.Text,
                    korisnickoIme = txtKorisnickoIme.Text,
                    lozinka = txtLozinka.Text,
                    potvrdaLozinke = txtPotvrdaLozinke.Text,
                    GradID = (int)comboBox.SelectedValue
                };
                if (_id.HasValue)
                    await _apiService.Update<dynamic>(_id, request);
                else
                    await _apiService.Insert<dynamic>(request);
                MessageBox.Show("Operacija uspjesna!");


                if (_id.HasValue)
                {

                }
             
                this.Close();
            }
            else
                MessageBox.Show("Operacija nije uspjela");
            
        }

        private async void FrmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            await LoadGradovi();
            if (_id != null)
            {
                var korisnik = await _apiService.GetById<dynamic>(_id);
                txtIme.Text = korisnik.ime;
                txtPrezime.Text = korisnik.prezime;
                dpdatumRodjenja.Value = (DateTime)korisnik.datumRodjenja;
                txtEmail.Text = korisnik.email;
                txtKorisnickoIme.Text = korisnik.korisnickoIme;
                txtTelefon.Text = korisnik.telefon;
                comboBox.SelectedValue = int.Parse(korisnik.gradID.ToString());
                
            }
        }
        private async Task LoadGradovi()
        {
            var result = await _apiServiceGradovi.Get<List<Model.Grad>>(null);
            comboBox.DisplayMember = "Naziv";
            comboBox.ValueMember = "GradID";
            comboBox.SelectedItem = null;
            comboBox.SelectedText = "--Odaberite--";
            comboBox.DataSource = result;
        }

        private void TxtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                errorProvider.SetError(txtIme, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;//zaustaviti procesiranje forme
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void TxtPrezime_Validating(object sender, CancelEventArgs e)
        {
                if (string.IsNullOrEmpty(txtPrezime.Text))
                {
                    errorProvider.SetError(txtPrezime, Properties.Resources.ObaveznoPolje);
                    e.Cancel = true;//zaustaviti procesiranje forme
                }
                else
                {
                    errorProvider.SetError(txtPrezime, null);
                }
        }

        private void TxtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelefon.Text))
            {
                errorProvider.SetError(txtTelefon, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;//zaustaviti procesiranje forme
            }
            else
            {
                errorProvider.SetError(txtTelefon, null);
            }
        }

        private void ComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox.SelectedItem==null)
            {
                errorProvider.SetError(comboBox, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;//zaustaviti procesiranje forme
            }
            else
            {
                errorProvider.SetError(comboBox, null);
            }
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;//zaustaviti procesiranje forme
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void TxtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtKorisnickoIme.Text) || txtKorisnickoIme.Text.Length<4)
            {
                errorProvider.SetError(txtKorisnickoIme,Properties.Resources.ObaveznoPolje);
                e.Cancel = true;//zaustaviti procesiranje forme
            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);
            }
        }

        private void TxtLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLozinka.Text))
            {
                errorProvider.SetError(txtLozinka, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;//zaustaviti procesiranje forme
            }
            else
            {
                errorProvider.SetError(txtLozinka, null);
            }
        }

        private void TxtPotvrdaLozinke_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPotvrdaLozinke.Text))
            {
                errorProvider.SetError(txtPotvrdaLozinke, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;//zaustaviti procesiranje forme
            }
            else if(txtPotvrdaLozinke.Text != txtLozinka.Text)
            {
                errorProvider.SetError(txtPotvrdaLozinke, "Lozinke se ne poklapaju!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPotvrdaLozinke, null);
            }
        }

       
    }
}
