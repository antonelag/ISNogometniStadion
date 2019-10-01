using ISNS.MA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ISNS.MA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlacanjeInfoPage : ContentPage
    {
        CreditCardVM ccvm = null;
        UlaznicaDetailVM detailVM = null;
        public PlacanjeInfoPage( CreditCardVM creditCardVM, UlaznicaDetailVM ulaznicaDetailVM)
        {
            InitializeComponent();
            ccvm = creditCardVM;
            detailVM = ulaznicaDetailVM;
        }

        protected async override void OnAppearing()
        {
        
            base.OnAppearing();
            await ccvm.Init();
            if (ccvm.uspjesno)
            {
                try
                {
                    detailVM.Iznos = ccvm.amount;
                    await detailVM.Init();

                }
                catch (Exception)
                {
                    this.fail.IsVisible = true;
                    this.failmsg.Text = "Neuspješna uplata.";
                }
                this.success.IsVisible = true;
                this.successmsg.Text = ccvm.msg;

            }

            else { 
                this.fail.IsVisible = true;
                this.failmsg.Text = ccvm.msg;
        }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UlaznicaInfoPage(detailVM));
        }
    }
}