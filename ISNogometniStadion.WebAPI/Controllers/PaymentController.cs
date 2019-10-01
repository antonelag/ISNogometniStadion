using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISNogometniStadion.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Stripe;

namespace ISNogometniStadion.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : Controller
    {
        [HttpPost]
        public string Post([FromBody]PaymentModel payment)
        {
            StripeConfiguration.ApiKey = ("pk_test_DaPhATJ0sS0GJYJnXbgubW6C00oJqhvxio");
            var tokenOptions = new Stripe.TokenCreateOptions()
            {
                Card = new Stripe.CreditCardOptions()
                {
                    Number = payment.CreditCard.CreditCardNumber,
                    ExpYear = payment.CreditCard.ExpYear,
                    ExpMonth = payment.CreditCard.ExpMonth,
                    Cvc = payment.CreditCard.CVV
                }
            };
            var tokenService = new Stripe.TokenService();
            Stripe.Token stripeToken;
            try
            {
                stripeToken = tokenService.Create(tokenOptions);
            }
            catch (StripeException ex)
            {
                StripeError stripeError = ex.StripeError;
                return stripeError.Message;
            }

            string token = stripeToken.Id; // This is the token

            // You can optionally create a customer first, and attached this to the CustomerId
            StripeConfiguration.ApiKey = ("sk_test_02wLfkfPFikWAuf5q8QwhcEb00RHbAsnJc");

            var charge = new Stripe.ChargeCreateOptions
            {
                Amount = Convert.ToInt32(payment.CreditCard.amount *100), // Ocekuje request u najmanjoj jedinici pa *100 da se pretvori
                Currency = "BAM", // or the currency you are dealing with
                Description = "Informacijski sistem za nogometni stadion",
                Source = token
            };
            var service = new ChargeService();
            try
            {
                var response = service.Create(charge);
                // Record or do something with the charge information
            }
            catch (StripeException ex)
            {
                StripeError stripeError = ex.StripeError;
                // Handle error
                return  stripeError.Message;
            }
            // Ideally you would put in additional information, but you can just return true or false for the moment0
            StripeError stripeError1 = new StripeError() { Message = "Uspješna uplata" };
            return stripeError1.Message;
        }
    }
}