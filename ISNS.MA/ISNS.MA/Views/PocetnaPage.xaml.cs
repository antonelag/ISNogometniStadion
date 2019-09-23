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
    public partial class PocetnaPage : ContentPage
    {
        PreporuceneUtakmiceVM preporuceneUtakmiceVM = null;
        public PocetnaPage()
        {
            InitializeComponent();
            BindingContext = preporuceneUtakmiceVM = new PreporuceneUtakmiceVM();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await preporuceneUtakmiceVM.Init();
            if (preporuceneUtakmiceVM.preporuci)
                this.preporuka.IsVisible = true;
        }

        
        private async void ListView_ItemSelected_1(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Utakmica;
            await Navigation.PushAsync(new RezervacijaPage(item));
        }
    }
}