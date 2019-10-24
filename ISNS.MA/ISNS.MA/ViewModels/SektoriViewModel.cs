using ISNogometniStadion.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ISNS.MA.ViewModels
{
    public class SektoriViewModel : BaseViewModel
    {
        private APIService _apiServiceSektori = new APIService("Sektori");
        private APIService _apiServiceTribine = new APIService("Tribine");

        public SektoriViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }
        public ObservableCollection<Sektor> SektoriList { get; set; } = new ObservableCollection<Sektor>();
        public Utakmica Utakmica { get; set; }
        public int StadionID { get; set; }
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            IsBusy = true;
            List<Tribina> listTribina = await _apiServiceTribine.Get<List<Tribina>>(null);
            List<int> listazahtjev = new List<int>();
            foreach (var tribina in listTribina)
            {
                if (tribina.StadionID == StadionID)
                    listazahtjev.Add(tribina.TribinaID);
            }

            var list = await _apiServiceSektori.Get<IEnumerable<Sektor>>(null);
            SektoriList.Clear();
            foreach (var sektor in list)
            {
                if (listazahtjev.Contains(sektor.TribinaID))
                    SektoriList.Add(sektor);
            }

        }


    }
}
