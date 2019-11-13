using ISNogometniStadion.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISNogometniStadion.WinUI.Uplate
{
    public partial class FrmUplate : Form
    {
        private readonly APIService _apiService = new APIService("Uplate");
        private readonly APIService _apiServiceUtakmice = new APIService("Utakmice");
        public FrmUplate()
        {
            InitializeComponent();
        }


        private async Task LoadSveUtakmice()
        {
            List<Utakmica> result = await _apiServiceUtakmice.Get<List<Model.Utakmica>>(new UtakmiceeSearchRequest() { sveUtakmice=true});
            cbUtakmice.DisplayMember = "UtakmicaPodaci";
            cbUtakmice.ValueMember = "UtakmicaID";
            cbUtakmice.DataSource = result;
            cbUtakmice.SelectedItem = null;
            cbUtakmice.Text = "--Odaberite utakmicu--";
        }
        private async Task LoadUplate(int id)
        {
            var result = await _apiService.Get<List<Model.Uplata>>(new UplateSearchRequest()
            {
                UtakmicaID = id
            });
            dgvUplate.AutoGenerateColumns = false;
            dgvUplate.DataSource = result;
        }



        private async void FrmUplate_Load(object sender, EventArgs e)
        {
            await LoadSveUtakmice();
        }

        private async void CbUtakmice_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var idObj = cbUtakmice.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadUplate(id);
            }
        }
    }
}
