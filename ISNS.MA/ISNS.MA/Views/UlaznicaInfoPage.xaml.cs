using ISNogometniStadion.Model;
using ISNS.MA.ViewModels;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ISNS.MA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UlaznicaInfoPage : ContentPage
    {
        UlaznicaDetailVM ulaznicaDetailVM = null;
        public UlaznicaInfoPage(UlaznicaDetailVM vm)
        {
            InitializeComponent();
            BindingContext = ulaznicaDetailVM = vm;
            NavigationPage.SetHasBackButton(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

    }
}