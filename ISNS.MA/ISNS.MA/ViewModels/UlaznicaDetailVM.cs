using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ISNS.MA.ViewModels
{
    public class UlaznicaDetailVM : BaseViewModel
    {
        public string Oznaka { get; set; }
        public Sjedalo Sjedalo { get; set; }
        public Utakmica Utakmica { get; set; }
        public string UtakmicaPodaci { get; set; }
        public Sektor Sektor { get; set; }
        public string SektorPodaci { get; set; }
        public Korisnik Korisnik { get; set; }
        public string KorisnikPodaci { get; set; }
        public decimal Iznos { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatumKupnje { get; set; }
        [DataType(DataType.Time)]
        public DateTime VrijemeKupnje { get; set; }
        public string Datum { get { return DatumKupnje.ToShortDateString(); } }
        public string Vrijeme { get { return DatumKupnje.ToShortTimeString(); } }
        private readonly APIService _apiServiceSjedala = new APIService("Sjedala");
        private readonly APIService _apiServiceKorisnici = new APIService("Korisnici");
        private readonly APIService _apiServiceUlaznice = new APIService("Ulaznica");
        private readonly APIService _apiServicePreporuke = new APIService("Preporuke");
        private readonly APIService _apiServiceUtakmica = new APIService("Utakmice");
        private readonly APIService _apiServiceUplate = new APIService("Uplate");

        public Ulaznica Ulaznica { get; set; }
        public byte[] Barcode { get; set; }
        public UlaznicaDetailVM()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            IsBusy = true;
            List<Sjedalo> list = await _apiServiceSjedala.Get<List<Sjedalo>>(new SjedalaSearchRequest() { Oznaka = Oznaka, SektorID = Sektor.SektorID });
            Sjedalo = list[0];
            Korisnik k = await _apiServiceKorisnici.GetById<Korisnik>(Korisnik.KorisnikID);
            UlazniceInsertRequest req = new UlazniceInsertRequest()
            {
                DatumKupnje = DatumKupnje,
                VrijemeKupnje = VrijemeKupnje,
                KorisnikID = Korisnik.KorisnikID,
                SjedaloID = Sjedalo.SjedaloID,
                UtakmicaID = Utakmica.UtakmicaID,
                cijena=Iznos
            };
            Sjedalo s1 = await _apiServiceSjedala.GetById<Sjedalo>(req.SjedaloID);
            s1.Status = true;
            SjedalaInsertRequest req2 = new SjedalaInsertRequest()
            {
                Oznaka = s1.Oznaka,
                SektorID = s1.SektorID,
                Status = s1.Status
            };

            Ulaznica u;
            try
            {
                u = await _apiServiceUlaznice.Insert<Ulaznica>(req);
                await _apiServiceSjedala.Update<dynamic>(req.SjedaloID, req2);
                Barcode = u.barcodeimg;

            }
            catch (Exception)
            {
                throw;

            }
            //SPREMANJE UPLATA

            UplateInsertRequest requestUplate = new UplateInsertRequest()
            {
                Iznos = Iznos,
                UlaznicaID = u.UlaznicaID
            };
            try
            {
                await _apiServiceUplate.Insert<Uplata>(requestUplate);
            }
            catch (Exception)
            {
                throw;
            }

            //SPREMANJE PREPORUKA
            Utakmica utakmica = await _apiServiceUtakmica.GetById<Utakmica>(req.UtakmicaID);
            var prviTim = utakmica.DomaciTimID;
            var drugiTim = utakmica.GostujuciTimID;
            List<Preporuka> rezultat = await _apiServicePreporuke.Get<List<Preporuka>>(new PreporukaSearchRequest() { KorisnikID = k.KorisnikID, PrviTimID = prviTim, DrugiTimID = drugiTim });
            if (rezultat.Count == 1)
            {
                rezultat[0].BrojKupljenihUlaznica++;
                PreporukaInsertRequest reqP;
                if (rezultat[0].TimID == prviTim)
                {
                    reqP = new PreporukaInsertRequest
                    {
                        TimID = drugiTim,
                        BrojKupljenihUlaznica = 1,
                        KorisnikID = k.KorisnikID
                    };

                }
                else
                {
                    reqP = new PreporukaInsertRequest
                    {
                        TimID = prviTim,
                        BrojKupljenihUlaznica = 1,
                        KorisnikID = k.KorisnikID
                    };
                }


                PreporukaInsertRequest reqPU = new PreporukaInsertRequest
                {
                    TimID = rezultat[0].TimID,
                    KorisnikID = rezultat[0].KorisnikID,
                    BrojKupljenihUlaznica = rezultat[0].BrojKupljenihUlaznica
                };
                await _apiServicePreporuke.Insert<Preporuka>(reqP);
                await _apiServicePreporuke.Update<Preporuka>(rezultat[0].PreporukaID, reqPU);

            }
            else if (rezultat.Count == 2)
            {
                PreporukaInsertRequest req1 = new PreporukaInsertRequest
                {
                    TimID = rezultat[0].TimID,
                    BrojKupljenihUlaznica = ++rezultat[0].BrojKupljenihUlaznica,
                    KorisnikID = rezultat[0].KorisnikID
                };
                PreporukaInsertRequest req3 = new PreporukaInsertRequest
                {
                    TimID = rezultat[1].TimID,
                    BrojKupljenihUlaznica = ++rezultat[1].BrojKupljenihUlaznica,
                    KorisnikID = rezultat[1].KorisnikID
                };

                await _apiServicePreporuke.Update<Preporuka>(rezultat[0].PreporukaID, req1);
                await _apiServicePreporuke.Update<Preporuka>(rezultat[1].PreporukaID, req3);

            }
            else//ako je 0
            {
                PreporukaInsertRequest req1 = new PreporukaInsertRequest
                {
                    TimID = prviTim,
                    BrojKupljenihUlaznica = 1,
                    KorisnikID = k.KorisnikID
                };
                PreporukaInsertRequest req3 = new PreporukaInsertRequest
                {
                    TimID = drugiTim,
                    BrojKupljenihUlaznica = 1,
                    KorisnikID = k.KorisnikID
                };

                await _apiServicePreporuke.Insert<Preporuka>(req1);
                await _apiServicePreporuke.Insert<Preporuka>(req3);
            }

        }



    }
}
