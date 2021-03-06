﻿using ISNogometniStadion.Model;
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
            else if (!Regex.IsMatch(this.Telefon.Text, @"^[+]{1}\d{3}[ ]?\d{2}[ ]?\d{3}[ ]?\d{3}"))
            {
                await DisplayAlert("Greška", "Format telefona je: +123 45 678 910", "OK");
            }
            else if (!Regex.IsMatch(this.Email.Text, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"))
            {
                await DisplayAlert("Greška", "Neispravan format email-a!", "OK");

            }
            else if (!Regex.IsMatch(this.KorisnickoIme.Text, @"^(?=.{4,40}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$"))
            {
                await DisplayAlert("Greška", "Neispravan format ili dužina korisničkog imena (4-40)", "OK");
            }
            else if (string.IsNullOrWhiteSpace(this.Lozinka.Text))
            {
                await DisplayAlert("Greška", "Morate unijeti novu ili staru lozinku", "OK");

            }
            else if (this.Lozinka.Text != this.PotvrdaLozinke.Text)
            {
                await DisplayAlert("Greška", "Lozinke moraju biti iste", "OK");

            }
            else if (this.Lozinka.Text.Length < 4)
            {
                await DisplayAlert("Greška", "Lozinka ne smije biti kraća od 4 karaktera", "OK");
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
                    List<Korisnik> k = await _apiServiceKorisnici.Get<List<Korisnik>>(new KorisniciSearchRequest() { KorisnickoIme = this.KorisnickoIme.Text });
                    List<Korisnik> k2 = await _apiServiceKorisnici.Get<List<Korisnik>>(new KorisniciSearchRequest() { KorisnickoIme = APIService.KorisnickoIme });

                    if (k.Count>0 && k[0].KorisnikID!=k2[0].KorisnikID)
                    {
                        await DisplayAlert("GREŠKA", "Korisnik sa tim korisničkim imenom već postoji", "OK");
                    }
                    else
                    {
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
                        var lozinka = APIService.Lozinka;
                        var korisnicko = APIService.KorisnickoIme;
                        await _apiServiceKorisnici.Update<dynamic>(korisnikVM.korisnik.KorisnikID, req);
                        await DisplayAlert("OK", "Uspješno uneseni podaci", "OK");
                        if (lozinka != this.Lozinka.Text || korisnicko != this.KorisnickoIme.Text)
                        {
                            App.Current.MainPage = new LoginPage();
                        }
                    }
                   

                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }

        }

    }
}
