using ISNogometniStadion.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ISNS.MA.ViewModels
{
    public class MojeUlazniceVM : BaseViewModel
    {
        private APIService _apiServiceUlaznice = new APIService("Ulaznica");
        private APIService _apiServiceKorisnici = new APIService("Korisnici");
        private APIService _apiServiceUtakmice = new APIService("Utakmice");
        private APIService _apiServiceUplate = new APIService("Uplate");

        public MojeUlazniceVM()
        {
            InitCommand = new Command(async () => await Init());
        }

        public Korisnik korisnik { get; set; }
        public ObservableCollection<Ulaznica> UlazniceList { get; set; } = new ObservableCollection<Ulaznica>();
        
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var korisnicko = APIService.KorisnickoIme;
            List<Korisnik> listKorisnici = await _apiServiceKorisnici.Get<List<Korisnik>>(null);
            foreach (var k in listKorisnici)
            {
                if (k.korisnickoIme == korisnicko)
                {
                    korisnik = k;
                    break;
                }
            }
            var list = await _apiServiceUlaznice.Get<IEnumerable<Ulaznica>>(new UlazniceSearchRequest() { KorisnikID = korisnik.KorisnikID });
            UlazniceList.Clear();
            foreach (var ulaznica in list)
            {
                Utakmica u = await _apiServiceUtakmice.GetById<Utakmica>(ulaznica.UtakmicaID);
                List<Uplata> uplata = await _apiServiceUplate.Get<List<Uplata>>(new UplateSearchRequest() { UlaznicaID = ulaznica.UlaznicaID });
                ulaznica.cijena = uplata[0].Iznos;
                if (u.DatumOdigravanja < DateTime.Now)
                    ulaznica.color = "LightGray";
                else
                    ulaznica.color = "LightGreen";
                
                UlazniceList.Add(ulaznica);
                
            }
        }

    }


}

