using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using ISNS.MA.Decision;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ISNS.MA.ViewModels
{
    public class UtakmicePoStadionuVM : BaseViewModel
    {
        public UtakmicePoStadionuVM()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Utakmica> utakmiceList { get; set; } = new ObservableCollection<Utakmica>();
        public ObservableCollection<Drzava> DrzaveList { get; set; } = new ObservableCollection<Drzava>();
        public ObservableCollection<Stadion> stadioniList { get; set; } = new ObservableCollection<Stadion>();
        private readonly APIService _apiServiceUtakmice = new APIService("Utakmice");
        private readonly APIService _apiServiceDrzave = new APIService("Drzave");
        private readonly APIService _apiServiceStadioni = new APIService("Stadioni");
        private APIService _apiServiceKorisnici = new APIService("Korisnici");
        private APIService _apiServicePreporukePoStadionu = new APIService("PreporukePoStadionu");
        public Korisnik Korisnik { get; set; } = new Korisnik();
        public DateTime? d1 { get; set; } = DateTime.MinValue;
        public DateTime? d2 { get; set; } = DateTime.MinValue;
        public decimal? cijena { get; set; } = -1;
        public Drzava _odabranaDrzava = null;
        public Drzava OdabranaDrzava
        {
            get { return _odabranaDrzava; }
            set
            {
                SetProperty(ref _odabranaDrzava, value);
                if (value != null)
                    InitCommand.Execute(null);
            }
        }
        public Stadion _odabraniStadion = null;
        public Stadion OdabraniStadion
        {
            get { return _odabraniStadion; }
            set
            {
                SetProperty(ref _odabraniStadion, value);
                if (value != null)
                    InitCommand.Execute(null);
            }
        }
        public int drzava { get; set; }
        public ICommand InitCommand { get; set; }
        private DecisionQuery MainDecisionTree()
        {
            var check = new DecisionQuery
            {
                Title = "Provjera",
                Test = async (z) =>
                {
                    List<Utakmica> lista = new List<Utakmica>();
                    if (z.naziv == "lokacija")
                    {
                        lista = await _apiServiceUtakmice.Get<List<Utakmica>>(new UtakmiceeSearchRequest() { GradID = z.id});
                    }
                    else if (z.naziv == "stadioni")
                    {
                        lista = await _apiServiceUtakmice.Get<List<Utakmica>>(new UtakmiceeSearchRequest() { StadionID = z.id});

                    }
                    else
                    {
                        lista = await _apiServiceUtakmice.Get<List<Utakmica>>(new UtakmiceeSearchRequest() { TimID = z.id});

                    }
                    return lista;
                },
                Positive = new DecisionResult() { result = true, utakmice = new List<Utakmica>() },
                Negative = new DecisionResult() { result = false, utakmice = new List<Utakmica>() }
            };
            var datumi = new DecisionQuery
            {
                Title = "Datumi",
                Test = async (z) =>
                {
                    UtakmiceeSearchRequest req = new UtakmiceeSearchRequest();
                    if (z.naziv == "lokacija")
                        req.GradID = z.id;
                    else if (z.naziv == "stadioni")
                        req.StadionID = z.id;
                    else
                        req.TimID = z.id;
                    if (z.d1 != DateTime.MinValue && z.d2 != DateTime.MinValue)
                    {
                        req.d1 = z.d1;
                        req.d2 = z.d2;
                    }
                    var lista = await _apiServiceUtakmice.Get<List<Utakmica>>(req);
                    return lista;
                },
                Positive = check,
                Negative = new DecisionResult() { result = false, utakmice = new List<Utakmica>() }
            };
            var cijene = new DecisionQuery
            {
                Title = "Cijene",
                Test = async (z) =>
                {
                    UtakmiceeSearchRequest req = new UtakmiceeSearchRequest();
                    if (z.naziv == "lokacija")
                    {
                        req.GradID = z.id;
                        req.PoLokaciji = true;
                    }
                    else if (z.naziv == "stadioni")
                    {
                        req.StadionID = z.id;
                        req.PoStadionu = true;
                    }
                    else
                    {
                        req.TimID = z.id;
                        req.PoTimu = true;
                    }
                    if (z.d1 != DateTime.MinValue && z.d2 != DateTime.MinValue)
                    {
                        req.d1 = z.d1;
                        req.d2 = z.d2;
                    }
                    if (z.cijena != -1)
                        req.cijena = z.cijena;

                    var lista = await _apiServiceUtakmice.Get<List<Utakmica>>(req);
                    return lista;
                },
                Positive = datumi,
                Negative = new DecisionResult() { result = false, utakmice = new List<Utakmica>() }
            };





            return cijene;




        }

        public async Task Init()
        {
            if (Korisnik != null)
                Korisnik = (await _apiServiceKorisnici.Get<List<Korisnik>>(new KorisniciSearchRequest() { KorisnickoIme = APIService.KorisnickoIme }))[0];

            if (DrzaveList.Count == 0)
            {
                var list = await _apiServiceDrzave.Get<List<Drzava>>(null);
                foreach (var l in list)
                    DrzaveList.Add(l);
            }
            if (_odabranaDrzava != null)
            {
                if (drzava != _odabranaDrzava.DrzavaID)
                {
                    if (stadioniList.Count != 0)
                        stadioniList.Clear();
                    var lista = await _apiServiceStadioni.Get<List<Stadion>>(new StadioniSearchRequest() { DrzavaID = _odabranaDrzava.DrzavaID });
                    foreach (var t in lista)
                        stadioniList.Add(t);
                    drzava = _odabranaDrzava.DrzavaID;
                }
            }
            if (_odabraniStadion != null)
            {
                Zahtjev z = new Zahtjev { naziv = "stadioni", id = _odabraniStadion.StadionID };
                if (d1 != DateTime.MinValue && d2 != DateTime.MinValue)
                {
                    z.d1 = d1;
                    z.d2 = d2;
                }
                if (cijena != -1)
                    z.cijena = cijena;

                var trunk = MainDecisionTree();
                var lista = new List<Utakmica>();
                await trunk.Evaluate(z);
                lista = trunk.listaUtakmica;
               
                if (utakmiceList.Count != 0)
                    utakmiceList.Clear();
                foreach (var t in lista)
                    utakmiceList.Add(t);

                List<PreporukaPoStadionu> pr = await _apiServicePreporukePoStadionu.Get<List<PreporukaPoStadionu>>(new PreporukaSearchRequest() { KorisnikID = Korisnik.KorisnikID });
                if (pr.Count == 0)
                    await _apiServicePreporukePoStadionu.Insert<PreporukaPoStadionu>(new PreporukePoStadionuInsertRequest() { KorisnikID = Korisnik.KorisnikID, StadionID = _odabraniStadion.StadionID });
                else
                    await _apiServicePreporukePoStadionu.Update<PreporukaPoStadionu>(pr[0].PreporukaID, new PreporukePoStadionuInsertRequest() { KorisnikID = Korisnik.KorisnikID, StadionID = _odabraniStadion.StadionID });
            }
        }
    }
}
