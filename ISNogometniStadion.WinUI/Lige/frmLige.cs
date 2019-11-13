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

        private async Task LoadSveDrzave()
        {
            var result = await _apiServiceDrzave.Get<List<Model.Drzava>>(null);
            cbDrzave.DisplayMember = "Naziv";
            cbDrzave.ValueMember = "DrzavaID";
            result.Insert(0, new Model.Drzava());
            cbDrzave.DataSource = result;
            cbDrzave.Text = "--Odaberite državu--";
        }
        private async Task LoadLige(int id)
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
            await LoadSveDrzave();
        }


        private void DgvLige_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvLige.SelectedRows[0].Cells[0].Value;
            var frm = new FrmLigeDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void CbDrzave_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cbDrzave.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadLige(id);
            }
        }
    }
}
