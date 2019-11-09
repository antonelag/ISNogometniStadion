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

namespace ISNogometniStadion.WinUI.Lige
{
    public partial class FrmLige : Form
    {
        private readonly APIService _apiService = new APIService("Lige");
        private readonly APIService _apiServiceDrzave = new APIService("Drzave");
        public FrmLige()
        {
            InitializeComponent();
        }

        private async Task loadSveDrzave()
        {
            var result = await _apiServiceDrzave.Get<List<Model.Drzava>>(null);
            cbLige.DisplayMember = "Naziv";
            cbLige.ValueMember = "DrzavaID";
            result.Insert(0, new Model.Drzava());
            cbLige.DataSource = result;
            cbLige.Text = "--Odaberite državu--";
        }
        private async Task LoadDrzave(int id)
        {
            var result = await _apiService.Get<List<Model.Liga>>(new LigaSearchRequest()
            {
                DrzavaID = id
            });
            dgvLige.AutoGenerateColumns = false;
            dgvLige.DataSource = result;
        }

        private async void FrmLige_Load(object sender, EventArgs e)
        {
            await loadSveDrzave();
        }

        private async void CbLige_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cbLige.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadDrzave(id);
            }
        }

        private void DgvLige_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvLige.SelectedRows[0].Cells[0].Value;
            var frm = new FrmLigeDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
