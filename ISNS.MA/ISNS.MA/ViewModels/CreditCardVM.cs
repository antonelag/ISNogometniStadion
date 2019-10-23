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
        public decimal Amount { get; set; }
        public bool Uspjesno { get; set; }
        public string Msg { get; set; }
        readonly PaymentAPIService PaymentAPIService = new PaymentAPIService("Payment");
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
                    amount = Amount,
                    CreditCardNumber = CreditCardNumber,
                    CVV = CVV,
                    ExpMonth = ExpMonth,
                    ExpYear = ExpYear
                }

            };
            StripeError e = await PaymentAPIService.Post<StripeError>(vm);
            Msg = e.Message;
            if (Msg == null)
                Msg = "Neuspješna uplata";


            if (Msg == "Uspješna uplata")
                Uspjesno = true;
            else
                Uspjesno = false;
        }
    }

}
