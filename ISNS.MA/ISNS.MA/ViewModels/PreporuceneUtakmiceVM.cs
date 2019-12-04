using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using ISNS.MA.Decision;
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
    public class PreporuceneUtakmiceVM
    {
        private APIService _apiServiceUtakmice = new APIService("Utakmice");
        private APIService _apiServicePreporuke = new APIService("Preporuke");
        private APIService _apiServicePreporukePoLokaciji = new APIService("PreporukePoLokaciji");
        private APIService _apiServicePreporukePoStadionu = new APIService("PreporukePoStadionu");
        private APIService _apiServicePreporukePoTimu = new APIService("PreporukePoTimu");

        private APIService _apiServiceKorisnici = new APIService("Korisnici");
        public Korisnik Korisnik { get; set; }
        public ObservableCollection<Utakmica> UtakmiceList { get; set; } = new ObservableCollection<Utakmica>();
        public ObservableCollection<Utakmica> UtakmicePoLokacijiList { get; set; } = new ObservableCollection<Utakmica>();
        public ObservableCollection<Utakmica> UtakmicePoStadionuList { get; set; } = new ObservableCollection<Utakmica>();
        public ObservableCollection<Utakmica> UtakmicePoTimuList { get; set; } = new ObservableCollection<Utakmica>();
        public bool preporuci { get; set; }
        public bool preporuciPoLokaciji { get; set; }
        public bool preporuciPoStadionu { get; set; }
        public bool preporuciPoTimu { get; set; }
        public PreporuceneUtakmiceVM()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }



        public async Task Init()
        {
            var korisnickoIme = APIService.KorisnickoIme;
            List<Korisnik> listKorisnici = await _apiServiceKorisnici.Get<List<Korisnik>>(new KorisniciSearchRequest() { KorisnickoIme = korisnickoIme });
            if (listKorisnici.Count != 0)
                Korisnik = listKorisnici[0];

            //pretrazivane lokacije
            List<PreporukaPoLokaciji> preporukaPoLokaciji = await _apiServicePreporukePoLokaciji.Get<List<PreporukaPoLokaciji>>(new PreporukaSearchRequest() { KorisnikID = Korisnik.KorisnikID });
            if (preporukaPoLokaciji.Count > 0)
            {
                if (UtakmicePoLokacijiList.Count != 0)
                    UtakmicePoLokacijiList.Clear();
                var temp = await _apiServiceUtakmice.Get<List<Utakmica>>(new UtakmiceeSearchRequest() { GradID = preporukaPoLokaciji[0].GradID });
                foreach (var t in temp)
                {
                    if (!UtakmicePoLokacijiList.Contains(t))
                    {
                        if (UtakmicePoLokacijiList.Count < 3)
                            UtakmicePoLokacijiList.Add(t);
                        else
                            break;

                    }
                }
                if (UtakmicePoLokacijiList.Count > 0)
                    preporuciPoLokaciji = true;
            }
            else
                preporuciPoLokaciji = false;


            //kupljene ulaznice
            List<Preporuka> preporuke = await _apiServicePreporuke.Get<List<Preporuka>>(new PreporukaSearchRequest() { KorisnikID = Korisnik.KorisnikID });
            if (UtakmiceList.Count != 0)
                UtakmiceList.Clear();

            if (preporuke.Count != 0)
            {
                List<Utakmica> tmp = new List<Utakmica>();
                foreach (var p in preporuke)
                {
                    List<Utakmica> temp = await _apiServiceUtakmice.Get<List<Utakmica>>(new UtakmiceeSearchRequest() { TimID = p.TimID });
                    foreach (Utakmica t in temp)
                    {
                        if (!tmp.Any(s => s.UtakmicaID == t.UtakmicaID))
                        {
                        if (tmp.Count < 3)
                            tmp.Add(t);
                        else
                            break;
                        }

                    }

                }
                if (tmp.Count > 0)
                {
                    foreach (var m in tmp)
                            UtakmiceList.Add(m);
                    preporuci = true;
                }
            }
            //pretrazivani stadioni
            List<PreporukaPoStadionu> preporukaPoStadionu = await _apiServicePreporukePoStadionu.Get<List<PreporukaPoStadionu>>(new PreporukaSearchRequest() { KorisnikID = Korisnik.KorisnikID });
            if (preporukaPoStadionu.Count > 0)
            {
                if (UtakmicePoStadionuList.Count != 0)
                    UtakmicePoStadionuList.Clear();
                var temp = await _apiServiceUtakmice.Get<List<Utakmica>>(new UtakmiceeSearchRequest() { StadionID = preporukaPoStadionu[0].StadionID });
                foreach (var t in temp)
                {
                    if (!UtakmicePoStadionuList.Contains(t))
                    {
                        if (UtakmicePoStadionuList.Count < 3)
                            UtakmicePoStadionuList.Add(t);
                        else
                            break;

                    }
                }
                if (UtakmicePoStadionuList.Count > 0)
                    preporuciPoStadionu = true;
            }
            else
                preporuciPoStadionu = false;

            //pretrazivani timovi
            List<PreporukaPoTimu> preporukaPoTimu = await _apiServicePreporukePoTimu.Get<List<PreporukaPoTimu>>(new PreporukaSearchRequest() { KorisnikID = Korisnik.KorisnikID });
            if (preporukaPoTimu.Count > 0)
            {
                if (UtakmicePoTimuList.Count != 0)
                    UtakmicePoTimuList.Clear();
                var temp = await _apiServiceUtakmice.Get<List<Utakmica>>(new UtakmiceeSearchRequest() { TimID = preporukaPoTimu[0].TimID });
                foreach (var t in temp)
                {
                    if (!UtakmicePoTimuList.Contains(t))
                    {
                        if (UtakmicePoTimuList.Count < 3)
                            UtakmicePoTimuList.Add(t);
                        else
                            break;

                    }
                }
                if (UtakmicePoTimuList.Count > 0)
                    preporuciPoTimu = true;
            }
            else
                preporuciPoTimu = false;

        }
    }
}
