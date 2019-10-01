using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using ISNS.MA.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ISNS.MA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UrediProfilPage : ContentPage
    {
        public APIService _apiServiceKorisnici = new APIService("Korisnici");
        public KorisnikVM korisnikVM { get; set; }
        public UrediProfilPage(Korisnik k)
        {
            InitializeComponent();
            BindingContext = korisnikVM = new KorisnikVM() { korisnik = k };

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await korisnikVM.Init();
            this.gradovi.SelectedItem = korisnikVM.GradoviList.FirstOrDefault(s => s.GradID == korisnikVM.korisnik.gradID);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.Ime.Text, @"^[a-zA-Z]+$"))
            {
                await DisplayAlert("Greška", "Ime se sastoji samo od slova", "OK");
            }
            else if (!Regex.IsMatch(this.Prezime.Text, @"^[a-zA-Z]+$"))
            {
                await DisplayAlert("Greška", "Prezime se sastoji samo od slova", "OK");
            }
            else if (!Regex.IsMatch(this.Telefon.Text, @"^[0-9]+$"))
            {
                await DisplayAlert("Greška", "Telefon se sastoji samo od brojeva", "OK");
            }
            else if (!Regex.IsMatch(this.Email.Text, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"))
            {
                await DisplayAlert("Greška", "Neispravan format email-a!", "OK");

            }
            else if (string.IsNullOrWhiteSpace(this.Lozinka.Text))
            {
                await DisplayAlert("Greška", "Morate unijeti novu ili staru lozinku", "OK");

            }
            else if (this.Lozinka.Text != this.PotvrdaLozinke.Text)
            {
                await DisplayAlert("Greška", "Lozinke moraju biti iste", "OK");

            }
            else if (this.Lozinka.Text.Length < 8)
            {
                await DisplayAlert("Greška", "Lozinka ne smije biti kraća od 8 karaktera", "OK");
            }
            else if (this.gradovi.SelectedItem == null)
            {
                await DisplayAlert("Greška", "Morate odabrati grad", "OK");

            }
            else
            {
                try
                {
                    Grad g = this.gradovi.SelectedItem as Grad;
                    KorisniciInsertRequest req = new KorisniciInsertRequest()
                    {
                        DatumRodjenja = this.DatumRodjenja.Date,
                        email = this.Email.Text,
                        GradID = g.GradID,
                        Ime = this.Ime.Text,
                        Prezime = this.Prezime.Text,
                        korisnickoIme = this.KorisnickoIme.Text,
                        lozinka = this.Lozinka.Text,
                        potvrdaLozinke = this.PotvrdaLozinke.Text,
                        telefon = this.Telefon.Text
                    };
                    await _apiServiceKorisnici.Update<dynamic>(korisnikVM.korisnik.KorisnikID, req);
                    await DisplayAlert("OK", "Uspješno uneseni podaci", "OK");
                   
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }

        }

    }
}
