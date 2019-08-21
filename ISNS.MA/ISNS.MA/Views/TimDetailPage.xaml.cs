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
    public partial class TimDetailPage : ContentPage
    {
        private TimDetailVM timDetailVM = null;
        public TimDetailPage(Tim tim)
        {
            InitializeComponent();
            BindingContext = timDetailVM = new TimDetailVM
            {
                Tim = tim
            };

        }
    }
}