using ISNogometniStadion.Model;
using ISNS.MA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ISNS.MA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StadionDetailPage : ContentPage
    {
        private StadionDetailVM stadionDetailVM = null;
        private Stadion s = null;
        public StadionDetailPage(Stadion stadion)
        {
            InitializeComponent();
            BindingContext = stadionDetailVM = new StadionDetailVM()
            {
                Stadion = stadion
            };
            s = stadion;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!double.TryParse(s.lat, out double lat))
                return;
            if (!double.TryParse(s.lng, out double lng))
                return;

           await Map.OpenAsync(lat, lng, new MapLaunchOptions
            {
                Name = s.Naziv,
                NavigationMode = NavigationMode.None
            });

        }
    }
}