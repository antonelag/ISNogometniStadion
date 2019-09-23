using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ISNS.MA.ViewModels
{
    public class PreporuceneUtakmiceVM
    {
        private APIService _apiServiceUtakmice = new APIService("Utakmice");
        private APIService _apiServicePreporuke = new APIService("Preporuke");
        private APIService _apiServiceKorisnici = new APIService("Korisnici");
        public Korisnik Korisnik { get; set; }
        public ObservableCollection<Utakmica> UtakmiceList { get; set; } = new ObservableCollection<Utakmica>();
        public bool preporuci { get; set; }
        public PreporuceneUtakmiceVM()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var korisnickoIme = APIService.KorisnickoIme;
            List<Korisnik> listKorisnici = await _apiServiceKorisnici.Get<List<Korisnik>>(null);
            List<Utakmica> listUtakmice = await _apiServiceUtakmice.Get<List<Utakmica>>(null);
            foreach (var korisnik in listKorisnici)
            {
                if (korisnik.korisnickoIme == korisnickoIme)
                {
                    Korisnik = korisnik;
                    break;
                }
            }

            List<Preporuka> preporuke = await _apiServicePreporuke.Get<List<Preporuka>>(new PreporukaSearchRequest() { KorisnikID = Korisnik.KorisnikID });
            UtakmiceList.Clear();
            if (preporuke.Count != 0)
                preporuci = true;
            if (preporuke.Count != 0)
            {
                var n = 5;
                if (preporuke.Count < 5)
                    n = preporuke.Count; 
            for(var i=0;i<n;i++)
            {
                foreach(var u in listUtakmice)
                {
                    if(preporuke[i].TimID==u.DomaciTimID || preporuke[i].TimID == u.GostujuciTimID)
                    {
                        if(!UtakmiceList.Contains(u))
                        UtakmiceList.Add(u);
                    }
                }
            }

            }
           
        }
    }
}
