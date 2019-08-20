using ISNogometniStadion.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ISNS.MA.ViewModels
{
    public class StadioniViewModel:BaseViewModel
    {
        private APIService _apiServiceStadioni = new APIService("Stadioni");
        private APIService _apiServiceGradovi = new APIService("Gradovi");
        public StadioniViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Stadion> StadioniList { get; set; } = new ObservableCollection<Stadion>();
        public ObservableCollection<Grad> GradoviList { get; set; } = new ObservableCollection<Grad>();
        Grad _selectedGrad = null;

        public Grad SelectedGrad
        {
            //u pickeru smo rekli: kada se promijeni item preko bindinga pozovi selectedliga property
            get { return _selectedGrad; }
            set
            {
                SetProperty(ref _selectedGrad, value); //kao value dobijemo odabrano i poziva se init komanda koja poziva init metodu
                if (value != null)
                    InitCommand.Execute(null); //ne moze init jer property ne podrzavaju async await pozive i iz toga razloga imamo i komandu
            }

        }



        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if (GradoviList.Count == 0)//u prvom slucaju odnosno kada nista nije odabrano...ako je nesto odabrano ovo preskacemo
            {
                var listgrad = await _apiServiceGradovi.Get<IEnumerable<Grad>>(null);
                foreach (var grad in listgrad)
                {
                    GradoviList.Add(grad);
                }
            }
            if (SelectedGrad != null)//dolazimo ovdje kada korisnik odabere nesto u dropdown listi
            {
                StadioniSearchRequest searchRequest = new StadioniSearchRequest
                {
                    GradID = SelectedGrad.GradID//uzimamo id i saljemo na api
                };
                var list = await _apiServiceStadioni.Get<IEnumerable<Stadion>>(searchRequest);
                StadioniList.Clear();
                foreach (var stadion in list)
                {
                    StadioniList.Add(stadion);
                }
            }

        }
    }
}
