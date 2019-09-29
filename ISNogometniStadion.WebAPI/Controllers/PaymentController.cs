using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISNogometniStadion.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace ISNogometniStadion.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : Controller
    {
        [HttpPost]
        public bool Post([FromBody]PaymentModel payment)
        {
            // You can optionally create a customer first, and attached this to the CustomerId
            StripeConfiguration.ApiKey = ("sk_test_02wLfkfPFikWAuf5q8QwhcEb00RHbAsnJc");

            var charge = new Stripe.ChargeCreateOptions
            {
                Amount = Convert.ToInt32(payment.Amount*100), // In cents, not dollars, times by 100 to convert
                Currency = "BAM", // or the currency you are dealing with
                Description = "something awesome",
                Source = payment.Token
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
                return false;
            }

            // Ideally you would put in additional information, but you can just return true or false for the moment.
            return true;
        }
    }
}