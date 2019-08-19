﻿using ISNS.MA.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ISNS.MA.ViewModels
{
    public class LoginViewModel:BaseViewModel
    {
        private readonly APIService _apiService=new APIService("Korisnici");
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => { await Login(); });
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
        //interfejs koji ce nam omoguciti da povezujemo buttone itd sa odredjenim komandama
        public ICommand LoginCommand { get; set; }

        async Task Login()
        {
            IsBusy = true;
            APIService.KorisnickoIme = KorisnickoIme;
            APIService.Lozinka = Lozinka;
            try
            {
                await _apiService.Get<dynamic>(null);
                Application.Current.MainPage = new MainPage();
            }
            catch (Exception)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Niste autentificirani", "OK");
                throw;
            }
        }
    }
}
