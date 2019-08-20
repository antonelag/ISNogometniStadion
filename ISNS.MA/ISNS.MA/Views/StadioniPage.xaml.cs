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
    public partial class StadioniPage : ContentPage
    {
        StadioniViewModel stadioniViewModel = null;
        public StadioniPage()
        {
            InitializeComponent();
            BindingContext = stadioniViewModel = new StadioniViewModel();
        }

        protected async override void OnAppearing()
        {
            //pozivanje init metode u samom kodu
            //kada se pojavi utakmice page na uredjaju ova ce se metoda pokrenuti
            base.OnAppearing();
            await stadioniViewModel.Init();
        }
    }
}