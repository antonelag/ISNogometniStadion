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
    public partial class UtakmicePage : ContentPage
    {
        UtakmiceViewModel utakmiceViewModel = null;
        public UtakmicePage()
        {
            InitializeComponent();
            BindingContext = utakmiceViewModel = new UtakmiceViewModel();

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await utakmiceViewModel.Init();
        }
    }
}