﻿using ISNogometniStadion.Model;
using ISNS.MA.ViewModels;
using Newtonsoft.Json;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CreditCardVM = ISNS.MA.ViewModels.CreditCardVM;

namespace ISNS.MA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlacanjePage : ContentPage
    {
        public CreditCardVM CreditCardVM = null;
        public UlaznicaDetailVM UlaznicaDetailVM = null;
        public bool ValidCard { get; set; }
        public bool ValidMonth { get; set; }
        public bool ValidYear { get; set; }
        public bool ValidCVV { get; set; }
        public bool ValidExpDate { get; set; }

        
        public PlacanjePage(Utakmica utakmica, Sektor sektor, string OznakaSjedala, DateTime datum, Korisnik korisnik)
        {
            InitializeComponent();
            CreditCardVM = new CreditCardVM();
            BindingContext = UlaznicaDetailVM = new UlaznicaDetailVM() { Utakmica = utakmica, Sektor = sektor, Korisnik = korisnik, KorisnikPodaci = korisnik.KorisnikPodaci, Oznaka = OznakaSjedala, DatumKupnje = datum, VrijemeKupnje = datum, SektorPodaci = sektor.SektorPodaci, UtakmicaPodaci = utakmica.UtakmicaPodaci };
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (CheckFields() && ValidCard && ValidMonth && ValidYear && ValidCVV)
            {
                var year = int.Parse(this.exy.Text);
                var month = int.Parse(this.exm.Text);
                var lastDateOfExpiryMonth = DateTime.DaysInMonth(year, month); //get actual expiry date
                var cardExpiry = new DateTime(year, month, lastDateOfExpiryMonth, 23, 59, 59);

                if (!(cardExpiry > DateTime.Now && cardExpiry < DateTime.Now.AddYears(6)))
                {
                    this.greska.IsVisible = true;
                    this.greska.Text = "Datum isteka nije validan.";
                    ValidExpDate = false;
                }
                else
                {
                    this.greska.IsVisible = false;
                    ValidExpDate = true;
                }

                if (ValidExpDate)
                {
                    CreditCardVM.CreditCardNumber = this.ccn.Text;
                    CreditCardVM.ExpMonth = int.Parse(this.exm.Text);
                    CreditCardVM.ExpYear = int.Parse(this.exy.Text);
                    CreditCardVM.CVV = this.cvv.Text;
                    CreditCardVM.Amount = decimal.Parse(UlaznicaDetailVM.Sektor.Cijena);

                    this.ccn.Text = "";
                    this.exy.Text = "";
                    this.exm.Text = "";
                    this.cvv.Text = "";
                    this.greska.IsVisible = false;
                    await Navigation.PushAsync(new PlacanjeInfoPage(CreditCardVM, UlaznicaDetailVM));
                }
                else
                {
                    this.greska.Text = "Neispravni podaci.";
                    this.btn.IsEnabled = true;
                }

            }

            else
            {
                this.greska.Text = "Morate unijeti podatke.";
                this.btn.IsEnabled = true;
            }
        }

        private void Ccn_TextChanged(object sender, TextChangedEventArgs e)
        {
            //1298|1267|4512|4567|8901|8933|
            //postaviti cemo stripe pocetke testnih kartica
            var cardCheck = new Regex(@"^(4242|4000|5000|2223|5200|5150|3782|3714|6011|3056|3622|3566|6200)([\-\s]?[0-9]{4}){3}$");
            if (!cardCheck.IsMatch(this.ccn.Text)) // <1>check card number is valid
            {
                this.greska.IsVisible = true;
                this.greska.Text = "Broj kartice nije validan";
                ValidCard = false;
            }
            else
            {
                this.greska.IsVisible = false;
                ValidCard = true;
            }


        }

        private void Exm_TextChanged(object sender, TextChangedEventArgs e)
        {
            var monthCheck = new Regex(@"^(0[1-9]|1[0-2])$");
            if (!monthCheck.IsMatch(this.exm.Text)) // <3 - 6>
            {
                this.greska.IsVisible = true;
                this.greska.Text = "Mjesec nije validan";
                ValidMonth = false;
            }
            else
            {
                this.greska.IsVisible = false;
                ValidMonth = true;
            }
        }

        private void Exy_TextChanged(object sender, TextChangedEventArgs e)
        {
            var yearCheck = new Regex(@"^20[0-9]{2}$");
            if (!yearCheck.IsMatch(this.exy.Text)) // <3 - 6>
            {
                this.greska.IsVisible = true;
                this.greska.Text = "Godina nije validna";
                ValidYear = false;
            }
            else
            {
                this.greska.IsVisible = false;
                ValidYear = true;
            }
        }

        private void Cvv_TextChanged(object sender, TextChangedEventArgs e)
        {
            var cvvCheck = new Regex(@"^\d{3}$");
            if (!cvvCheck.IsMatch(this.cvv.Text)) // <2>check cvv is valid as "999"
            {
                this.greska.IsVisible = true;
                this.greska.Text = "CVV nije validan";
                ValidCVV = false;
            }
            else
            {
                this.greska.IsVisible = false;
                ValidCVV = true;
            }
        }

        private bool CheckFields()
        {
            return (!string.IsNullOrWhiteSpace(this.ccn.Text) && !string.IsNullOrWhiteSpace(this.exm.Text) &&
                !string.IsNullOrWhiteSpace(this.exy.Text) && !string.IsNullOrWhiteSpace(this.cvv.Text));
        }
    }
}