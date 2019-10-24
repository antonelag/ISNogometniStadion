using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
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
    public partial class OdabirSjedalaPage : ContentPage
    {
        SjedalaViewModel sjedalaViewModel = null;
        public OdabirSjedalaPage(Sektor sektor, Utakmica utakmica)
        {
            InitializeComponent();
            BindingContext = sjedalaViewModel = new SjedalaViewModel() { sektor = sektor, utakmica=utakmica };

        }

        protected async override void OnAppearing()
        {

            base.OnAppearing();
            await sjedalaViewModel.Init();
            sjedalaViewModel.IsBusy = false;
            var brSjedala = sjedalaViewModel.BrojSjedala;
            this.gridSjedala.Children.Clear();
            this.gridSjedala.RowDefinitions = new RowDefinitionCollection();
            this.gridSjedala.ColumnDefinitions = new ColumnDefinitionCollection();
            var brR = 0;
            this.gridSjedala.RowDefinitions.Add(new RowDefinition());

            var brK = 0;
            for (int i = 0; i < brSjedala; i++)
            {
               

                if (i % 14 == 0 && i!=0)
                {
                    brR++;
                    this.gridSjedala.RowDefinitions.Add(new RowDefinition { Height=30});
                    brK = 0;
                }
                this.gridSjedala.ColumnDefinitions.Add(new ColumnDefinition { Width=30});
                Button l = new Button { MinimumWidthRequest=50, Text = sjedalaViewModel.SjedalaList[i].Oznaka, TextColor = Color.White, CornerRadius = 25, IsEnabled=!sjedalaViewModel.SjedalaList[i].Status,
                HeightRequest=30,WidthRequest=30, FontSize=10 };
                l.Pressed += btn_Clicked;
                if (sjedalaViewModel.SjedalaList[i].Status == true)
                    l.BackgroundColor = Color.Gray;
                else
                    l.BackgroundColor = Color.Green;
                
                this.gridSjedala.Children.Add(l,brK,brR);
                brK++;
                
            }
          
        }

     

        private void btn_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            for (int i = 0; i < this.gridSjedala.ColumnDefinitions.Count; i++)
            {
                var btn2 = this.gridSjedala.Children[i] as Button;
                if (btn2.Text!=btn.Text && btn2.IsEnabled==false)
                {
                    btn2.IsEnabled= true;
                    btn2.BackgroundColor = Color.Green;
                }

            }
            
            btn.BackgroundColor = Color.Gray;
            btn.IsEnabled = false;
            this.nastavidalje.IsVisible = true;
            this.odabranoSjedalo.Text = btn.Text;
            this.poruka.Text = "Odabrali ste sjedalo sa oznakom: " + btn.Text + ". Nastavite dalje do plaćanja!";
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlacanjePage(sjedalaViewModel.utakmica, sjedalaViewModel.sektor, this.odabranoSjedalo.Text,DateTime.Now, sjedalaViewModel.Korisnik));
            this.nastavidalje.IsVisible = false;
        }
    }
}