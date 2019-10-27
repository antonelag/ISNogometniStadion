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
            else if (!Regex.IsMatch(this.Telefon.Text, @"^[+]{1}\d{3}[ ]?\d{2}[ ]?\d{3}[ ]?\d{3}"))
            {
                await DisplayAlert("Greška", "Format telefona je: +123 45 678 910", "OK");
            }
            else if (!Regex.IsMatch(this.Email.Text, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"))
            {
                await DisplayAlert("Greška", "Neispravan format email-a!", "OK");

            }
            else if (string.IsNullOrWhiteSpace(this.Lozinka.Text))
            {
                await DisplayAlert("Greška", "Morate unijeti lozinku", "OK");

            }
            else if (this.Lozinka.Text != this.PotvrdaLozinke.Text)
            {
                await DisplayAlert("Greška", "Lozinke moraju biti iste", "OK");

            }
            else if (this.Lozinka.Text.Length < 4)
            {
                await DisplayAlert("Greška", "Lozinka ne smije biti kraća od 4 karaktera", "OK");
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