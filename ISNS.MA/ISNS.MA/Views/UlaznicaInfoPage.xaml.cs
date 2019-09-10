﻿using ISNogometniStadion.Model;
using ISNS.MA.ViewModels;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ISNS.MA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UlaznicaInfoPage : ContentPage
    {
        UlaznicaDetailVM ulaznicaDetailVM = null;
        public UlaznicaInfoPage(Utakmica utakmica, Sektor sektor, string OznakaSjedala, DateTime datum, Korisnik korisnik)
        {
            InitializeComponent();
            BindingContext = ulaznicaDetailVM = new UlaznicaDetailVM() { Utakmica = utakmica, Sektor = sektor, Korisnik = korisnik, korisnik = korisnik.KorisnikPodaci, Oznaka = OznakaSjedala, DatumKupnje = datum, VrijemeKupnje = datum, sektor = sektor.SektorPodaci, utakmica = utakmica.UtakmicaPodaci };
           
        }


        protected async override void OnAppearing()
        {
            base.OnAppearing();
            
            await ulaznicaDetailVM.Init();


        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.barcode.Source = ImageSource.FromStream(()=>new MemoryStream(ulaznicaDetailVM.barcode));
            this.btn.IsEnabled = false;
        }
    }
}