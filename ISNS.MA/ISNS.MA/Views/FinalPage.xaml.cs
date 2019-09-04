using ISNogometniStadion.Model;
using ISNS.MA.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ISNS.MA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinalPage : ContentPage
    {
        public FinalPage(Ulaznica ulaznica, string brojKartice, DateTime datumIsteka,string cvv)
        {
            InitializeComponent();
        }



    }
}