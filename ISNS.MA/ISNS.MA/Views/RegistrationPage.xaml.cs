using ISNogometniStadion.Model;
using ISNS.MA.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ISNS.MA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        RegistrationViewModel vm = null;
        public RegistrationPage()
        {
            InitializeComponent();
            BindingContext = vm = new RegistrationViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await vm.Init();
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
            else if (this.Gradovi.SelectedItem == null)
            {
                await DisplayAlert("Greška", "Morate odabrati grad", "OK");

            }
            else
            {
                vm.Ime = this.Ime.Text;
                vm.Prezime = this.Prezime.Text;
                vm.DatumRodjenja = this.DatumRodjenja.Date;
                vm.Telefon = this.Telefon.Text;
                vm.Email = this.Email.Text;
                vm.KorisnickoIme = this.KorisnickoIme.Text;
                vm.Lozinka = this.Lozinka.Text;
                vm.PotvrdaLozinke = this.PotvrdaLozinke.Text;
                Grad g = this.Gradovi.SelectedItem as Grad;
                vm.GradID = g.GradID;

                await vm.Registration();
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Application.Current.MainPage = new LoginPage();
        }
    }
}