using ISNogometniStadion.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ISNS.MA.ViewModels
{
    public class UlaznicaDetailVM
    {
        public string Oznaka { get; set; }
        public Sjedalo Sjedalo { get; set; }
        public Utakmica Utakmica { get; set; }
        public string utakmica { get; set; }
        public Sektor Sektor { get; set; }
        public string sektor { get; set; }
        public Korisnik Korisnik { get; set; }
        public string korisnik { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatumKupnje { get; set; }
        [DataType(DataType.Time)]
        public DateTime VrijemeKupnje { get; set; }
        public string Datum { get { return DatumKupnje.ToShortDateString(); } } 
        public string Vrijeme { get { return DatumKupnje.ToShortTimeString(); } }
        private APIService _apiServiceSjedala = new APIService("Sjedala");
        private APIService _apiServiceKorisnici = new APIService("Korisnici");
   
        public UlaznicaDetailVM()
        {
            InitCommand = new Command(async () => await Init());
        }

        ICommand InitCommand { get; set; }
        public async Task Init()
        {
          
            List<Sjedalo> listSjedala = await _apiServiceSjedala.Get<List<Sjedalo>>(null);
            foreach(var sjedalo in listSjedala)
            {
                if (sjedalo.Oznaka == Oznaka && sjedalo.SektorID==Sektor.SektorID) { 
                    Sjedalo = sjedalo;
                    break;
                }
            }
          
            
        }


    }
}
