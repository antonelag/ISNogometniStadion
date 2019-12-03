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
    public partial class PretragaPoLokacijiPage : ContentPage
    {
        UtakmicePoLokacijiVM model = null;
        bool err = false;
        bool err1 = false;
        public PretragaPoLokacijiPage()
        {
            InitializeComponent();
            BindingContext = model = new UtakmicePoLokacijiVM();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            this.datumi.IsVisible = false;
            this.cijene.IsVisible = false;
        }

        private async void Cb_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (this.cb.IsChecked)
            {
                if (model._odabraniGrad == null)
                {
                    await DisplayAlert("Greška", "Morate odabrati državu i grad", "OK");
                    err = true;
                    this.cb.IsChecked = false;
                }
                else
                {
                    err = false;
                    this.datumi.IsVisible = true;
                }
            }
            else
            {
                if (!err)
                {
                    model.d1 = DateTime.MinValue;
                    model.d2 = DateTime.MinValue;
                    this.datumi.IsVisible = false;
                    this.cbCijena.IsChecked = false;
                    this.cijene.IsVisible = false;
                    model.cijena = -1;
                    await model.Init();
                }
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            model.d1 = this.d1.Date;
            model.d2 = this.d2.Date;
            await model.Init();
        }

        private async void CbCijena_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (this.cbCijena.IsChecked)
            {
                if (!this.cb.IsChecked)
                {
                    await DisplayAlert("Greška", "Morate odabrati datume", "OK");
                    err1 = true;
                    this.cbCijena.IsChecked = false;
                }
                else
                {
                    err1 = false;
                    this.cijene.IsVisible = true;
                }
            }
            else
            {
                if (!err1)
                {
                    this.cijene.IsVisible = false;
                    model.cijena = -1;
                    await model.Init();
                }
            }
        }


        private void SliderCijene_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.sliderresult.Text = $"Cijena: {this.sliderCijene.Value}";
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            model.cijena = decimal.Parse(this.sliderCijene.Value.ToString());
            await model.Init();
        }
    }
}