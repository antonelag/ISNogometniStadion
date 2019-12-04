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
        public PretragaVM()
        {
            InitCommand = new Command(() => Init());
        }
        public ICommand InitCommand { get; set; }
        public ObservableCollection<PretragaViewModel> pretragaList { get; set; } = new ObservableCollection<PretragaViewModel>();
        public void Init()
        {
            if (pretragaList.Count != 0)
                pretragaList.Clear();
            pretragaList.Add(new PretragaViewModel() { Naslov = "Pretraži po lokaciji", Podnaslov = "Pretražite utakmice po željenoj lokaciji" });
            pretragaList.Add(new PretragaViewModel() { Naslov = "Pretraži po stadionu", Podnaslov = "Pretražite utakmice po željenom stadionu" });
            pretragaList.Add(new PretragaViewModel() { Naslov = "Pretraži po timu", Podnaslov = "Pretražite utakmice po željenom timu" });

        }

    }
}

