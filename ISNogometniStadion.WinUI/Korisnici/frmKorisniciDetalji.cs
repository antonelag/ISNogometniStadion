using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISNogometniStadion.WinUI.Korisnici
{
    public partial class FrmKorisniciDetalji : Form
    {
        private readonly int? _id = null;
        private readonly APIService _apiService = new APIService("Korisnici");
        private readonly APIService _apiServiceGradovi = new APIService("Gradovi");
        public FrmKorisniciDetalji(int? KorisnikID = null)
        {
            _id = KorisnikID;
            InitializeComponent();
        }

        private const int WM_CLOSE = 0x0010;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_CLOSE)
                AutoValidate = AutoValidate.Disable;
            base.WndProc(ref m);
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                List<Korisnik> lista = await _apiService.Get<List<Korisnik>>(new KorisniciSearchRequest() { KorisnickoIme = txtKorisnickoIme.Text });
                lista = lista.Where(s => s.korisnickoIme.Equals(txtKorisnickoIme.Text)).ToList();
                //slican razlog i ovdje kao za drzave
                if (lista.Count == 0 || (lista.Count == 1 && lista[0].KorisnikID == _id))
                {
                    var request = new KorisniciInsertRequest()
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        email = txtEmail.Text,
                        DatumRodjenja = dpdatumRodjenja.Value.Date,
                        telefon = txtTelefon.Text,
                        korisnickoIme = txtKorisnickoIme.Text,
                        lozinka = txtLozinka.Text,
                        potvrdaLozinke = txtPotvrdaLozinke.Text,
                        GradID = (int)comboBox.SelectedValue
                    };
                    if (_id.HasValue)
                    {
                        int i = (int)_id;
                        //Da li trenutni korisnik mijenja svoju lozinku
                        bool izmjena = false;
                        var korisnicko = APIService.KorisnickoIme;
                        var lozinka = APIService.Lozinka;
                        Korisnik k = await _apiService.GetById<Korisnik>(_id);
                        if (korisnicko == k.korisnickoIme && lozinka!=txtLozinka.Text)
                            izmjena = true;
                        try
                        {
                            await _apiService.Update<dynamic>(i, request);
                            MessageBox.Show("Operacija uspjesna!");
                            this.Close();

                            if (izmjena)
                            {
                                foreach(Form f in Application.OpenForms)
                                {
                                    //da se ponovo logira
                                    if (f.Text != "frmLogin")
                                        f.Close();
                                }
                            }

                        }
                        catch (Exception)
                        {
                        }
                    }
                    else
                    {
                        try
                        {
                            await _apiService.Insert<dynamic>(request);
                            MessageBox.Show("Operacija uspjesna!");
                            this.Close();
                        }
                        catch (Exception)
                        {
                        }
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
            else if (!Regex.IsMatch(txtIme.Text, @"^[a-zA-Z ]+$"))
            {
                errorProvider.SetError(txtIme, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
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
            else if (!Regex.IsMatch(txtPrezime.Text, @"^[a-zA-Z -]+$"))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
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
            else if (!Regex.IsMatch(txtTelefon.Text, @"^[+]{1}\d{3}[ ]?\d{2}[ ]?\d{3}[ ]?\d{3}"))
            {
                errorProvider.SetError(txtTelefon, "Format telefona je: +123 45 678 910");
                e.Cancel = true;//zaustaviti procesiranje forme
            }
            else
            {
                errorProvider.SetError(txtTelefon, null);
            }
        }

        private void ComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox.SelectedItem == null)
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
            else if (!Regex.IsMatch(txtEmail.Text, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.NeispravanFormat);
                e.Cancel = true;//zaustaviti procesiranje forme
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void TxtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtKorisnickoIme.Text) || txtKorisnickoIme.Text.Length < 4)
            {
                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;//zaustaviti procesiranje forme
            }

            else if (!Regex.IsMatch(txtKorisnickoIme.Text, @"^(?=.{6,40}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$"))
            {

                errorProvider.SetError(txtKorisnickoIme, "Neispravan format ili dužina imena (8-40)");
                e.Cancel = true;
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
            else if (txtLozinka.Text.Length < 4)
            {

                errorProvider.SetError(txtLozinka, "Lozinka mora sadrzavati minimalno 4 znaka.");
                e.Cancel = true;
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
            else if (txtPotvrdaLozinke.Text != txtLozinka.Text)
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
