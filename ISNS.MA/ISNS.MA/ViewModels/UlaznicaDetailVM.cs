using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Media.Imaging;
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
        private APIService _apiServiceUlaznice = new APIService("Ulaznica");
        public Ulaznica ulaznica { get; set; }
        public byte[] barcode { get; set; }
        public UlaznicaDetailVM()
        {
            InitCommand = new Command(async () => await Init());
        }

        ICommand InitCommand { get; set; }
        public async Task Init()
        {

            List<Sjedalo> listSjedala = await _apiServiceSjedala.Get<List<Sjedalo>>(null);
            foreach (var sjedalo in listSjedala)
            {
                if (sjedalo.Oznaka == Oznaka && sjedalo.SektorID == Sektor.SektorID)
                {
                    Sjedalo = sjedalo;
                    break;
                }
            }
            Korisnik k = await _apiServiceKorisnici.GetById<Korisnik>(Korisnik.KorisnikID);
            UlazniceInsertRequest req = new UlazniceInsertRequest()
            {
                DatumKupnje = DatumKupnje,
                VrijemeKupnje = VrijemeKupnje,
                KorisnikID = Korisnik.KorisnikID,
                SjedaloID = Sjedalo.SjedaloID,
                UtakmicaID = Utakmica.UtakmicaID
            };
            Sjedalo s1 = await _apiServiceSjedala.GetById<Sjedalo>(req.SjedaloID);
            s1.Status = true;
            SjedalaInsertRequest req2 = new SjedalaInsertRequest()
            {
                Oznaka = s1.Oznaka,
                SektorID = s1.SektorID,
                Status = s1.Status
            };

            try
            {
                Ulaznica u = await _apiServiceUlaznice.Insert<Ulaznica>(req);
                await _apiServiceSjedala.Update<dynamic>(req.SjedaloID, req2);
                barcode = u.barcodeimg;

            }
            catch (Exception)
            {

                throw;
            }

        }



    }
}
