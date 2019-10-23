using ISNogometniStadion.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISNogometniStadion.WinUI.Timovi
{
    public partial class FrmTimovi : Form
    {
        private readonly APIService _apiService = new APIService("Timovi");
        private readonly APIService _apiServiceLige = new APIService("Lige");
        private readonly ImageService _imageService = new ImageService();
        public FrmTimovi()
        {
            InitializeComponent();
        }
        public bool ThumbnailCallback()
        {
            return false;
        }

        private async Task LoadSveLige()
        {
            var result = await _apiServiceLige.Get<List<Model.Liga>>(null);
            cbLiga.DisplayMember = "Naziv";
            cbLiga.ValueMember = "LigaID";
            result.Insert(0, new Model.Liga());
            cbLiga.DataSource = result;
        }
        private async Task LoadLige(int id)
        {
            var result = await _apiService.Get<List<Model.Tim>>(new TimoviSearchRequest()
            {
                LigaID = id
            });
            dgvTimovi.DataSource = result;
        }
        private void DgvTimovi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvTimovi.SelectedRows[0].Cells[0].Value;
            var frm = new FrmTimoviDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void FrmTimovi_Load(object sender, EventArgs e)
        {
            await LoadSveLige();
        }

        private async void CbLiga_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cbLiga.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadLige(id);
            }
        }
    }
}
