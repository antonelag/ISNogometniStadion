using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using ISNS.MA.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ISNS.MA.ViewModels
{
    public class RegistrationViewModel:BaseViewModel
    {


        public RegistrationViewModel()
        {
            InitCommand = new Command(async () => await Init());
            RegistrationCommand = new Command(async () => await Registration());

        }


        public ICommand RegistrationCommand { get; set; }
        public ICommand InitCommand { get; set; }

        private KorisniciAPIService _service = new KorisniciAPIService("KorisniciInsert");
        private GradoviAPIService _apiServiceGradovi = new GradoviAPIService("GradoviGet");
        public ObservableCollection<Grad> GradoviList { get; set; } = new ObservableCollection<Grad>();

        public async Task Init()
        {
            var list = await _apiServiceGradovi.Get<List<Grad>>(null);
            GradoviList.Clear();
            foreach (var g in list)
            {
                GradoviList.Add(g);
            }
        }
    
        public async Task Registration()
        {
            IsBusy = true;

            var response = await _service.Get<List<Korisnik>>(new KorisniciSearchRequest() { KorisnickoIme = _korisnickoIme });
            if (response.Count == 0)
            {

            try
            {//
                await _service.Insert<Korisnik>(new KorisniciInsertRequest() {
                    Ime=_ime,
                    Prezime=_prezime,
                    DatumRodjenja=_datumRodjenja,
                    telefon=_telefon,
                    email=_email,
                    korisnickoIme=_korisnickoIme,
                    lozinka=_lozinka,
                    GradID=_gradID,
                    potvrdaLozinke=_potvrdaLozinke
                });
                
                Application.Current.MainPage = new LoginPage();
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Neispravni podaci", "OK");
            }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Korisničko ime već postoji", "OK");
            }
        }



        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }
        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }
        DateTime _datumRodjenja = DateTime.Now;
        public DateTime DatumRodjenja
        {
            get { return _datumRodjenja; }
            set { SetProperty(ref _datumRodjenja, value); }
        }
        string _telefon = string.Empty;
        public string Telefon
        {
            get { return _telefon; }
            set { SetProperty(ref _telefon, value); }
        }
        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        string _korisnickoIme = string.Empty;
        public string KorisnickoIme
        {
            get { return _korisnickoIme; }
            set { SetProperty(ref _korisnickoIme, value); }
        }

        string _lozinka = string.Empty;
        public string Lozinka
        {
            get { return _lozinka; }
            set { SetProperty(ref _lozinka, value); }
        }
        string _potvrdaLozinke = string.Empty;
        public string PotvrdaLozinke
        {
            get { return _potvrdaLozinke; }
            set { SetProperty(ref _potvrdaLozinke, value); }
        }
        int _gradID = 0;
        public int GradID
        {
            get { return _gradID; }
            set { SetProperty(ref _gradID, value); }
        }
    }
}
