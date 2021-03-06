﻿using ISNogometniStadion.Model;
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
        readonly SjedalaViewModel SjedalaViewModel = null;
        public OdabirSjedalaPage(Sektor sektor, Utakmica utakmica)
        {
            InitializeComponent();
            BindingContext = SjedalaViewModel = new SjedalaViewModel() { sektor = sektor, utakmica=utakmica };

        }

        protected async override void OnAppearing()
        {

            base.OnAppearing();
            await SjedalaViewModel.Init();
            SjedalaViewModel.IsBusy = false;
            var brSjedala = SjedalaViewModel.BrojSjedala;
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
                this.gridSjedala.ColumnDefinitions.Add(new ColumnDefinition { Width=40});
                Button l = new Button { MinimumWidthRequest=40, Text = SjedalaViewModel.SjedalaList[i].Oznaka, TextColor = Color.White, CornerRadius = 10, IsEnabled=!SjedalaViewModel.SjedalaList[i].Status,
                HeightRequest=30,WidthRequest=40, FontSize=10 };
                l.Pressed += btn_Clicked;
                if (SjedalaViewModel.SjedalaList[i].Status == true)
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
            await Navigation.PushAsync(new PlacanjePage(SjedalaViewModel.utakmica, SjedalaViewModel.sektor, this.odabranoSjedalo.Text,DateTime.Now, SjedalaViewModel.Korisnik));
            this.nastavidalje.IsVisible = false;
        }
    }
}