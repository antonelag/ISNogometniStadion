using ISNogometniStadion.Model;
using ISNS.MA.Decision;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ISNS.MA.ViewModels
{
    public class UtakmicePoLokacijiVM : BaseViewModel
    {
        public UtakmicePoLokacijiVM()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ICommand InitCommand { get; set; }
        private APIService _apiServiceDrzave = new APIService("Drzave");
        private APIService _apiServiceGradovi = new APIService("Gradovi");
        private APIService _apiServiceUtakmice = new APIService("Utakmice");
        public ObservableCollection<Drzava> drzaveList { get; set; } = new ObservableCollection<Drzava>();
        public ObservableCollection<Grad> gradoviList { get; set; } = new ObservableCollection<Grad>();
        public ObservableCollection<Utakmica> utakmiceList { get; set; } = new ObservableCollection<Utakmica>();
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
        public Grad _odabraniGrad = null;
        public Grad OdabraniGrad
        {
            get { return _odabraniGrad; }
            set
            {
                SetProperty(ref _odabraniGrad, value);
                if (value != null)
                    InitCommand.Execute(null);
            }
        }
        public int drzava { get; set; }
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
                        lista = await _apiServiceUtakmice.Get<List<Utakmica>>(new UtakmiceeSearchRequest() { GradID = z.id, sveUtakmice = true });
                    }
                    else if (z.naziv == "stadioni")
                    {
                        lista = await _apiServiceUtakmice.Get<List<Utakmica>>(new UtakmiceeSearchRequest() { StadionID = z.id, sveUtakmice = true });

                    }
                    else
                    {
                        lista = await _apiServiceUtakmice.Get<List<Utakmica>>(new UtakmiceeSearchRequest() { TimID = z.id, sveUtakmice = true });

                    }
                    return lista;
                },
                Positive = new DecisionResult() { result = true, utakmice = new List<Utakmica>() },
                Negative=new DecisionResult() { result=false, utakmice=new List<Utakmica>()}
            };
            var datumi = new DecisionQuery
            {
                Title = "Datumi",
                Test = async (z) =>
                {
                    UtakmiceeSearchRequest req = new UtakmiceeSearchRequest() { sveUtakmice=true};
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
                    if (z.d1 != DateTime.MinValue && z.d2!=DateTime.MinValue)
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
                    UtakmiceeSearchRequest req = new UtakmiceeSearchRequest() { sveUtakmice = true };
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
                    if (z.cijena!=-1)
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

            if (drzaveList.Count == 0)
            {
                var list = await _apiServiceDrzave.Get<List<Drzava>>(null);
                foreach (var d in list)
                    drzaveList.Add(d);
            }

            if (_odabranaDrzava != null)
            {
                if (drzava != _odabranaDrzava.DrzavaID)
                {
                    if (gradoviList.Count != 0)
                        gradoviList.Clear();

                    var gradovi = await _apiServiceGradovi.Get<List<Grad>>(new GradoviSearchRequest() { DrzavaID = _odabranaDrzava.DrzavaID });
                    foreach (var g in gradovi)
                        gradoviList.Add(g);
                    drzava = _odabranaDrzava.DrzavaID;
                }
            }
            if (_odabraniGrad != null)
            {

                Zahtjev z = new Zahtjev { naziv = "lokacija", id = _odabraniGrad.GradID };
                if(d1!=DateTime.MinValue && d2 != DateTime.MinValue)
                {
                    z.d1 = d1;
                    z.d2 = d2;
                }
                if (cijena!=-1)
                    z.cijena = cijena;

                var trunk = MainDecisionTree();
                var lista = new List<Utakmica>();
                await trunk.Evaluate(z);
                    lista = trunk.listaUtakmica;
                   
                //var req = new UtakmiceeSearchRequest() { GradID = _odabraniGrad.GradID, sveUtakmice = true };
                //var list = await _apiServiceUtakmice.Get<List<Utakmica>>(req);
                if (utakmiceList.Count != 0)
                    utakmiceList.Clear();
                foreach (var u in lista)
                    utakmiceList.Add(u);
            }


        }

    }
}
