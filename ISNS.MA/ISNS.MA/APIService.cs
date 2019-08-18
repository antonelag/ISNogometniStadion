using Flurl.Http;
using ISNogometniStadion.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ISNS.MA
{
    public class APIService
    {
        private string _route;
        public static string KorisnickoIme;
        public static string Lozinka;
        //jer za svaki request koji dodje na api korisnik mora biti autenti.
        public APIService(string route)
        {
            _route = route;
        }

#if DEBUG
       private string _apiUrl = "http://localhost:50944/api";
#endif

#if RELEASE
       private string _apiUrl = "https://mywebsite.com/api/";

#endif

        public async Task<T> Get<T>(object search)
        {
            //SVAKA metoda koja je asinhrona mora da vraca task
            //i mora await eksterne resurse u ovom slucaju je to api
            //async mora biti u paru i treba ga staviti i na metodu

            var url = $"{_apiUrl}/{_route}";
            //linija koda ispod ceka sve dok se ne zavrsi api
            //ui thread koji crta nasu formu ce biti slobodan

            try
            {
            if (search != null)
            {
                url += "?";//jer query string pocinje s upitnikom
                url += await search.ToQueryString();
            }
            var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
            return result;
            }
            catch(FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste autentificirani", "OK");
                throw;
            }
        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";
            var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
            return result;
        }
        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";
            try
            {

            var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).PostJsonAsync(request).ReceiveJson<T>(); ;
            return result;
            }
            catch(FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();
                var stringBuilder = new StringBuilder();
                foreach(var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${ string.Join(",", error.Value)}");

                }
                await Application.Current.MainPage.DisplayAlert("Greška", "Niste autentificirani", "OK");
                return default(T);
            }
        }
        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{_apiUrl}/{_route}/{id}";
            try
            {
            var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).PutJsonAsync(request).ReceiveJson<T>(); ;
            return result;

            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();
                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${ string.Join(",", error.Value)}");

                }
                await Application.Current.MainPage.DisplayAlert("Greška", "Niste autentificirani", "OK");
                return default(T);
            }
        }

    }
}
