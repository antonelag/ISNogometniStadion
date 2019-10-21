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
        public string msg { get; set; }
        PaymentAPIService PaymentAPIService = new PaymentAPIService("Payment");
        public CreditCardVM()
        {
            InitCommand = new Command(async () => await Init());

        }
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            PaymentModel vm = new PaymentModel()
            {
                CreditCard = new ISNogometniStadion.Model.CreditCardVM()
                {
                    amount = amount,
                    CreditCardNumber = CreditCardNumber,
                    CVV = CVV,
                    ExpMonth = ExpMonth,
                    ExpYear = ExpYear
                }

            };
            StripeError e = await PaymentAPIService.Post<StripeError>(vm);
            msg = e.Message;
            if (msg == null)
                msg = "Neuspješna uplata";


            if (msg == "Uspješna uplata")
                uspjesno = true;
            else
                uspjesno = false;
        }
    }

}
