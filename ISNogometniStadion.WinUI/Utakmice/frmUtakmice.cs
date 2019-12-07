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

namespace ISNogometniStadion.WinUI.Utakmice
{
    public partial class FrmUtakmice : Form
    {
        private readonly APIService _apiService = new APIService("Utakmice");
        private readonly APIService _apiServiceLige = new APIService("Lige");
        public FrmUtakmice()
        {
            InitializeComponent();
        }

        private void DgvUtakmice_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvUtakmice.SelectedRows[0].Cells[0].Value;
            var frm = new FrmUtakmiceDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
        private async Task LoadSveLige()
        {
            var result = await _apiServiceLige.Get<List<Model.Liga>>(null);
            cbLiga.DisplayMember = "Naziv";
            cbLiga.ValueMember = "LigaID";
            result.Insert(0, new Model.Liga());
            cbLiga.DataSource = result;
            cbLiga.Text = "--Odaberite ligu--";
        }
        private async Task LoadUtakmice(int id)
        {
            var result = await _apiService.Get<List<Model.Utakmica>>(new UtakmiceeSearchRequest()
            {
                LigaID = id
            });
            dgvUtakmice.AutoGenerateColumns = false;
            dgvUtakmice.DataSource = result;
        }

        private async void FrmUtakmice_Load(object sender, EventArgs e)
        {
            await LoadSveLige();
        }

        private async void CbLiga_SelectedIndexChanged(object sender, EventArgs e)
        {

            var idObj = cbLiga.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadUtakmice(id);
            }
        }
    }
}
