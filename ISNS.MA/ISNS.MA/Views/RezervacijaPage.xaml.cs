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
    public partial class RezervacijaPage : ContentPage
    {
        private SektoriViewModel sektoriViewModel = null;
        public RezervacijaPage(Utakmica utakmica)
        {
            InitializeComponent();
            BindingContext = sektoriViewModel = new SektoriViewModel() { StadionID=utakmica.StadionID
            ,Utakmica=utakmica};
        }
        protected async override void OnAppearing()
        {
            //pozivanje init metode u samom kodu
            //kada se pojavi utakmice page na uredjaju ova ce se metoda pokrenuti
            base.OnAppearing();
            await sektoriViewModel.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Sektor;
            await Navigation.PushAsync(new OdabirSjedalaPage(item, sektoriViewModel.Utakmica));
        }

    }
}