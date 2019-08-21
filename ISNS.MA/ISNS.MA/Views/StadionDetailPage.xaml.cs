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
    public partial class StadionDetailPage : ContentPage
    {
        private StadionDetailVM stadionDetailVM = null;
        public StadionDetailPage(Stadion stadion)
        {
            InitializeComponent();
            BindingContext = stadionDetailVM = new StadionDetailVM()
            {
                Stadion = stadion
            };
        }
    }
}