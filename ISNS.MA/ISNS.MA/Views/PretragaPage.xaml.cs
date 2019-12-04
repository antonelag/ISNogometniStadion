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
    public partial class PretragaPage : ContentPage
    {
        public PretragaVM model;
        public PretragaPage()
        {
            InitializeComponent();
            BindingContext=model = new PretragaVM();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            PretragaViewModel s = e.SelectedItem as PretragaViewModel;
            if (s.Naslov == "Pretraži po lokaciji")
                await Navigation.PushAsync(new PretragaPoLokacijiPage());
            if (s.Naslov == "Pretraži po stadionu")
                await Navigation.PushAsync(new PretragaPoStadionuPage());
            if (s.Naslov == "Pretraži po timu")
                await Navigation.PushAsync(new PretragaPoTimuPage());
        }
    }
}