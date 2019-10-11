using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using ISNogometniStadion.WinUI.Gradovi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISNogometniStadion.WinUI
{
    public partial class frmRegistracija : Form
    {
        public GradoviApiService _apiServiceGradovi = new GradoviApiService("GradoviGet");
        public KorisniciApiService _apiServiceKorisnici = new KorisniciApiService("KorisniciInsert");
        public frmRegistracija()
        {
            InitializeComponent();
        }

        private const int WM_CLOSE = 0x0010;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_CLOSE)
                AutoValidate = AutoValidate.Disable;
            base.WndProc(ref m);
        }

        private void TxtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                errorProvider1.SetError(txtIme, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;//zaustaviti procesiranje forme
            }
            else if (!Regex.IsMatch(txtIme.Text, @"^[a-zA-Z ]+$"))
            {
                errorProvider1.SetError(txtIme, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtIme, null);
            }
        }

        private void TxtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                errorProvider1.SetError(txtPrezime, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;//zaustaviti procesiranje forme
            }
            else if (!Regex.IsMatch(txtPrezime.Text, @"^[a-zA-Z ]+$"))
            {
                errorProvider1.SetError(txtPrezime, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPrezime, null);
            }
        }

        private void TxtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelefon.Text))
            {
                errorProvider1.SetError(txtTelefon, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;//zaustaviti procesiranje forme
            }
            else if (!Regex.IsMatch(txtTelefon.Text, @"^[+]{1}\d{3}[ ]?\d{2}[ ]?\d{3}[ ]?\d{3}"))
            {
                errorProvider1.SetError(txtTelefon, "Format telefona je: +/// // /// ///");
                e.Cancel = true;//zaustaviti procesiranje forme
            }
            else
            {
                errorProvider1.SetError(txtTelefon, null);
            }
        }

        private void ComboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                errorProvider1.SetError(comboBox1, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;//zaustaviti procesiranje forme
            }
            else
            {
                errorProvider1.SetError(comboBox1, null);
            }
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;//zaustaviti procesiranje forme
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^[a-z0-9][-a-z0-9.!#$%&'*+-=?^_`{|}~\/]+@([-a-z0-9]+\.)+[a-z]{2,5}$"))
            {
                errorProvider1.SetError(txtEmail, Properties.Resources.NeispravanFormat);
                e.Cancel = true;//zaustaviti procesiranje forme
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void TxtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtKorisnickoIme.Text) || txtKorisnickoIme.Text.Length < 4)
            {
                errorProvider1.SetError(txtKorisnickoIme, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;//zaustaviti procesiranje forme
            }

            else if (!Regex.IsMatch(txtKorisnickoIme.Text, @"^(?=.{8,40}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$"))
            {

                errorProvider1.SetError(txtKorisnickoIme, "Neispravan format ili dužina imena (8-40)");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtKorisnickoIme, null);
            }
        }

        private void TxtLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLozinka.Text))
            {
                errorProvider1.SetError(txtLozinka, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;//zaustaviti procesiranje forme
            }
            else if (txtLozinka.Text.Length < 8)
            {

                errorProvider1.SetError(txtLozinka, "Lozinka mora sadrzavati minimalno 8 znakova.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtLozinka, null);
            }
        }

        private void TxtPotvrdaLozinke_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPotvrdaLozinke.Text))
            {
                errorProvider1.SetError(txtPotvrdaLozinke, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;//zaustaviti procesiranje forme
            }
            else if (txtPotvrdaLozinke.Text != txtLozinka.Text)
            {
                errorProvider1.SetError(txtPotvrdaLozinke, "Lozinke se ne poklapaju!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPotvrdaLozinke, null);
            }
        }

        private async void FrmRegistracija_Load(object sender, EventArgs e)
        {
            await LoadGradovi();

        }

        private async Task LoadGradovi()
        {
            var result = await _apiServiceGradovi.Get<List<Model.Grad>>(null);
            comboBox1.DisplayMember = "Naziv";
            comboBox1.ValueMember = "GradID";
            comboBox1.SelectedItem = null;
            comboBox1.SelectedText = "--Odaberite--";
            comboBox1.DataSource = result;
        }

        private async void BtnRegistrirajSe_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                List<Korisnik> lista = await _apiServiceKorisnici.Get<List<Korisnik>>(new KorisniciSearchRequest() { KorisnickoIme = txtKorisnickoIme.Text });
                if (lista.Count == 0)
                {
                    var request = new KorisniciInsertRequest()
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        email = txtEmail.Text,
                        DatumRodjenja = dtpDatumRodjenja.Value,
                        telefon = txtTelefon.Text,
                        korisnickoIme = txtKorisnickoIme.Text,
                        lozinka = txtLozinka.Text,
                        potvrdaLozinke = txtPotvrdaLozinke.Text,
                        GradID = (int)comboBox1.SelectedValue
                    };

                        try
                        {
                            await _apiServiceKorisnici.Insert<dynamic>(request);
                            MessageBox.Show("Operacija uspjesna!");
                            this.Close();
                        }
                        catch (Exception)
                        {
                        }
                    
                }
                else
                {
                    MessageBox.Show("Zauzeto korisnicko ime!");
                }
            }
            else
            {
                MessageBox.Show("Operacija nije uspjela");
                this.Close();
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new frmGradoviTemp();
            frm.Show();
            this.Close();
        }
    }
}
