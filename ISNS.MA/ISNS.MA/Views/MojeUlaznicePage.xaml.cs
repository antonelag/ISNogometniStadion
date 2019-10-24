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
    public partial class MojeUlaznicePage : ContentPage
    {
        public MojeUlazniceVM mojeUlazniceVM { get; set; }
        public MojeUlaznicePage()
        {
            InitializeComponent();
            BindingContext = mojeUlazniceVM = new MojeUlazniceVM();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await mojeUlazniceVM.Init();
            
        }
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Ulaznica;
            await Navigation.PushAsync(new UlazniceInfoPage2(item));
        }
    }
}