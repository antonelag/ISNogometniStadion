using Flurl.Http;
using ISNogometniStadion.Model;
using Stripe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Application = Xamarin.Forms.Application;

namespace ISNS.MA
{
    public class PaymentAPIService
    {
        public static string KorisnickoIme { get; set; }
        public static string Lozinka { get; set; }

        private readonly string _route;

#if DEBUG
        private readonly string _apiUrl = "http://localhost:50944/api";
#endif
#if RELEASE
        private string apiUrl = "https://mywebsite.com/api";

#endif
        public PaymentAPIService(string route)
        {
            _route = route;
        }

       

        public async Task<StripeError> Post<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";

            try
            {
                var ret= await url.WithBasicAuth(KorisnickoIme, Lozinka).PostJsonAsync(request).ReceiveString();
                return new StripeError() { Message=ret};
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseStringAsync();

                return new StripeError() { Message = errors };
            }

        }

    }
}
