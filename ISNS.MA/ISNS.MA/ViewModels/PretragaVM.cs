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
    public class PretragaVM
    {

        public ObservableCollection<PretragaViewModel> pretragaList { get; set; } = new ObservableCollection<PretragaViewModel>()
        {
            new PretragaViewModel() { Naslov = "Pretraži po lokaciji", Podnaslov = "Pretražite utakmice po željenoj lokaciji" },
            new PretragaViewModel() { Naslov = "Pretraži po stadionu", Podnaslov = "Pretražite utakmice po željenom stadionu" },
            new PretragaViewModel() { Naslov = "Pretraži po timu", Podnaslov = "Pretražite utakmice po željenom timu" }
        };
    }
}
