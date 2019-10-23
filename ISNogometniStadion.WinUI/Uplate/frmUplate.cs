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
            List<Utakmica> result = await _apiServiceUtakmice.Get<List<Model.Utakmica>>(null);
            comboBox1.DisplayMember = "UtakmicaPodaci";
            comboBox1.ValueMember = "UtakmicaID";
            comboBox1.DataSource = result;
            comboBox1.SelectedItem = null;
            comboBox1.SelectedText = "--Odaberite--";
        }
        private async Task LoadUplate(int id)
        {
            var result = await _apiService.Get<List<Model.Uplata>>(new UplateSearchRequest()
            {
                UtakmicaID = id
            });
            dgvUplate.DataSource = result;
        }



        private async void FrmUplate_Load(object sender, EventArgs e)
        {
            await LoadSveUtakmice();
        }

        private async void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var idObj = comboBox1.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadUplate(id);
            }
        }
    }
}
