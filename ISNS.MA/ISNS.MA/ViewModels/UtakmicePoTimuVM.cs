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
    public class UtakmicePoTimuVM : BaseViewModel
    {
        public UtakmicePoTimuVM()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Utakmica> utakmiceList { get; set; } = new ObservableCollection<Utakmica>();
        public ObservableCollection<Tim> timoviList { get; set; } = new ObservableCollection<Tim>();
        public ObservableCollection<Liga> ligeList { get; set; } = new ObservableCollection<Liga>();
        private readonly APIService _apiServiceUtakmice = new APIService("Utakmice");
        private readonly APIService _apiServiceTimovi = new APIService("Timovi");
        private readonly APIService _apiServiceLige = new APIService("Lige");
        private APIService _apiServiceKorisnici = new APIService("Korisnici");
        private APIService _apiServicePreporukePoTimu = new APIService("PreporukePoTimu");
        public Korisnik Korisnik { get; set; } = new Korisnik();
        public DateTime? d1 { get; set; } = DateTime.MinValue;
        public DateTime? d2 { get; set; } = DateTime.MinValue;
        public decimal? cijena { get; set; } = -1;

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
        public Liga _odabranaLiga = null;
        public Liga OdabranaLiga
        {
            get { return _odabranaLiga; }
            set
            {
                SetProperty(ref _odabranaLiga, value);
                if (value != null)
                    InitCommand.Execute(null);
            }
        }
        public Tim _odabraniTim = null;
        public Tim OdabraniTim
        {
            get { return _odabraniTim; }
            set
            {
                SetProperty(ref _odabraniTim, value);
                if (value != null)
                    InitCommand.Execute(null);
            }
        }
        public int liga { get; set; }
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            if (Korisnik != null)
                Korisnik = (await _apiServiceKorisnici.Get<List<Korisnik>>(new KorisniciSearchRequest() { KorisnickoIme = APIService.KorisnickoIme }))[0];

            if (ligeList.Count == 0)
            {
                var list = await _apiServiceLige.Get<List<Liga>>(null);
                foreach (var l in list)
                    ligeList.Add(l);
            }
            if (_odabranaLiga != null)
            {
                if (liga != _odabranaLiga.LigaID)
                {
                    if (timoviList.Count != 0)
                        timoviList.Clear();
                    var lista = await _apiServiceTimovi.Get<List<Tim>>(new TimoviSearchRequest() { LigaID = _odabranaLiga.LigaID });
                    foreach (var t in lista)
                        timoviList.Add(t);
                    liga = _odabranaLiga.LigaID;
                }
            }
            if (_odabraniTim != null)
            {
                if (utakmiceList.Count != 0)
                    utakmiceList.Clear();
                Zahtjev z = new Zahtjev { naziv = "timovi", id = _odabraniTim.TimID };
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
                foreach (var t in lista)
                    if (!utakmiceList.Contains(t))
                        utakmiceList.Add(t);

                List<PreporukaPoTimu> pr = await _apiServicePreporukePoTimu.Get<List<PreporukaPoTimu>>(new PreporukaSearchRequest() { KorisnikID = Korisnik.KorisnikID });
                if (pr.Count==0)
                    await _apiServicePreporukePoTimu.Insert<PreporukaPoTimu>(new PreporukePoTimuInsertRequest() { KorisnikID = Korisnik.KorisnikID,TimID=_odabraniTim.TimID });
                else
                    await _apiServicePreporukePoTimu.Update<PreporukaPoTimu>(pr[0].PreporukaID, new PreporukePoTimuInsertRequest() { KorisnikID = Korisnik.KorisnikID, TimID = _odabraniTim.TimID });
            }
        }
    }
}
