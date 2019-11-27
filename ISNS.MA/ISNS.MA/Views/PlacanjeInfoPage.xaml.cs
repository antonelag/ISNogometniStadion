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
        readonly CreditCardVM ccvm = null;
        readonly UlaznicaDetailVM detailVM = null;
        public bool Uspjesno { get; set; }
        public PlacanjeInfoPage(CreditCardVM creditCardVM, UlaznicaDetailVM ulaznicaDetailVM)
        {
            InitializeComponent();
            ccvm = creditCardVM;
            detailVM = ulaznicaDetailVM;
        }

        protected override bool OnBackButtonPressed()
        {
            if (Uspjesno)
                return true;
            return false;
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();
            await ccvm.Init();
            if (ccvm.Uspjesno)
            {
                try
                {
                    detailVM.Iznos = ccvm.Amount;
                    await detailVM.Init();
                    this.loadingOverlay.IsVisible = false;
                    this.success.IsVisible = true;
                    this.successmsg.Text = ccvm.Msg;
                    Uspjesno = true;
                }
                catch (Exception)
                {
                    this.fail.IsVisible = true;
                    this.failmsg.Text = "Neuspješna uplata.";
                    this.loadingOverlay.IsVisible = false;
                    Uspjesno = false;
                }


            }

            else
            {
                this.loadingOverlay.IsVisible = false;
                this.fail.IsVisible = true;
                this.failmsg.Text = ccvm.Msg;
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UlaznicaInfoPage(detailVM));
        }
    }
}