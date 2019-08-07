using System;
using System.Collections.Generic;
using Flurl.Http;
using Flurl;
using System.Threading.Tasks;
using ISNogometniStadion.Model;
namespace ISNogometniStadion.WinUI
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

        public async Task<T> Get<T>(object search)
        {
            //SVAKA metoda koja je asinhrona mora da vraca task
            //i mora await eksterne resurse u ovom slucaju je to api
            //async mora biti u paru i treba ga staviti i na metodu

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
            //linija koda ispod ceka sve dok se ne zavrsi api
            //ui thread koji crta nasu formu ce biti slobodan

            if (search != null)
            {
                url += "?";//jer query string pocinje s upitnikom
                url += await search.ToQueryString();
            }
            var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
            return result;
        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";
            var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
            return result;
        }
        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
            var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).PostJsonAsync(request).ReceiveJson<T>(); ;
            return result;
        }
        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";
            var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).PutJsonAsync(request).ReceiveJson<T>(); ;
            return result;
        }

    }

}
