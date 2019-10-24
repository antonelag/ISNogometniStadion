using ISNogometniStadion.Model;
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
    public partial class UlazniceInfoPage2 : ContentPage
    {
        public UlaznicaSimpleDetailVM ulaznicaSimpleDetailVM { get; set; }
        public UlazniceInfoPage2(Ulaznica ulaznica)
        {
            InitializeComponent();
            BindingContext = ulaznicaSimpleDetailVM = new UlaznicaSimpleDetailVM() { ulaznica = ulaznica };
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (ulaznicaSimpleDetailVM.ulaznica.DatumKupnje < DateTime.Now)
                ulaznicaSimpleDetailVM.ulaznica.color = "LightGray";
            else
                ulaznicaSimpleDetailVM.ulaznica.color = "LightGreen";
        }
    }
}