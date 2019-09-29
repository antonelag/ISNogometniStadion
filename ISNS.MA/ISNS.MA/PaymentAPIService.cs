using Flurl.Http;
using ISNogometniStadion.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ISNS.MA
{
    public class PaymentAPIService
    {
        public static string KorisnickoIme { get; set; }
        public static string Lozinka { get; set; }

        private readonly string _route;

#if DEBUG
        private string _apiUrl = "http://localhost:50944/api";
#endif
#if RELEASE
        private string apiUrl = "https://mywebsite.com/api";

#endif
        public PaymentAPIService(string route)
        {
            _route = route;
        }

       

        public async Task<T> Post<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";

            try
            {
                return await url.WithBasicAuth(KorisnickoIme, Lozinka).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }
                await Application.Current.MainPage.DisplayAlert("Greška", "Niste autentificirani", "OK");

                return default(T);
            }

        }

    }
}
