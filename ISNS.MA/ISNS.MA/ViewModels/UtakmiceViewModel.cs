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
    public class UtakmiceViewModel
    {
        private readonly APIService _service = new APIService("Utakmice");
        public UtakmiceViewModel()
        {
            InitCommand = new Command(async () =>await Init());
        }
        public ObservableCollection<Utakmica> UtakmiceList { get; set; } = new ObservableCollection<Utakmica>();

        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            var list = await _service.Get<IEnumerable<Utakmica>>(null);
            UtakmiceList.Clear();
            foreach(var utakmica in list)
            {
                UtakmiceList.Add(utakmica);
            }
        }
    }
}
