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
            this.success.IsVisible = false;
            this.fail.IsVisible = false;
            base.OnAppearing();
            await ccvm.Init();
            if (ccvm.uspjesno)
                this.success.IsVisible = true;
            else
                this.fail.IsVisible = true;
        }
    }
}