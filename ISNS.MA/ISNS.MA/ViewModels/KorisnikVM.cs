using ISNogometniStadion.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ISNS.MA.ViewModels
{
    public class KorisnikVM
    {
        private APIService _apiServiceGradovi= new APIService("Gradovi");
        public Korisnik korisnik { get; set; }
        //lista gradova
        public ObservableCollection<Grad> GradoviList { get; set; } = new ObservableCollection<Grad>();

        public ICommand InitCommand { get; set; }
        public string grad { get; set; }

        public KorisnikVM()
        {
            InitCommand = new Command(async () => await Init());
        }
        public async Task Init()
        {

            var list = await _apiServiceGradovi.Get<List<Grad>>(null);
            foreach(var g in list)
            {
                GradoviList.Add(g);
            }
        }
    }
}
