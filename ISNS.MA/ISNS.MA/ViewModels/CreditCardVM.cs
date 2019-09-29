using ISNogometniStadion.Model;
using Stripe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ISNS.MA.ViewModels
{
    public class CreditCardVM
    {
        public string CreditCardNumber { get; set; }
        public long ExpYear { get; set; }
        public long ExpMonth { get; set; }
        public string CVV { get; set; }
        public decimal amount { get; set; }
        public bool uspjesno { get; set; }
        PaymentAPIService PaymentAPIService = new PaymentAPIService("Payment");
        public CreditCardVM()
        {
            InitCommand = new Command(async () => await Init());

        }
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            StripeConfiguration.ApiKey = ("pk_test_DaPhATJ0sS0GJYJnXbgubW6C00oJqhvxio");

            var tokenOptions = new Stripe.TokenCreateOptions()
            {
                Card = new Stripe.CreditCardOptions()
                {
                    Number = CreditCardNumber,
                    ExpYear = ExpYear,
                    ExpMonth = ExpMonth,
                    Cvc = CVV
                }
            };
            var tokenService = new Stripe.TokenService();
            Stripe.Token stripeToken = tokenService.Create(tokenOptions);

            string token= stripeToken.Id; // This is the token
            uspjesno =await PaymentAPIService.Post<bool>(new PaymentModel() { Amount = amount, Token = token });
        }
    }

}
