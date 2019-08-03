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
    public partial class frmTimovi : Form
    {
        private readonly APIService _apiService = new APIService("Timovi");
        private readonly ImageService _imageService = new ImageService();
        public frmTimovi()
        {
            InitializeComponent();
        }
        public bool ThumbnailCallback()
        {
            return false;
        }
        private async void BtnPretrazi_Click(object sender, EventArgs e)
        {
        
            var search = new TimoviSearchRequest()
            {
                Naziv = txtPretraga.Text
            };
            var res = await _apiService.Get<List<Tim>>(search);
            dgvTimovi.DataSource = res;
            dgvTimovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvTimovi.AutoResizeColumns();
            for (var j=0;j < res.Count;j++)
            {
                    dgvTimovi.Rows[j].Cells["SlikaThumb"].Value = _imageService.BytesToImage(res[j].SlikaThumb);
            }
        }

        private void DgvTimovi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvTimovi.SelectedRows[0].Cells[0].Value;
            var frm = new frmTimoviDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    



    }
}
