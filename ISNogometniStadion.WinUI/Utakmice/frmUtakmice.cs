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
    public partial class frmUtakmice : Form
    {
        private readonly APIService _apiService = new APIService("Utakmice");
        public frmUtakmice()
        {
            InitializeComponent();
        }

        private async void BtnPretrazi_Click(object sender, EventArgs e)
        {
            var search = new UtakmiceeSearchRequest
            {
                NazivTima = txtPretraga.Text
            };
            var res = await _apiService.Get<dynamic>(search);
            dgvUtakmice.DataSource = res;
        }

        private void DgvUtakmice_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvUtakmice.SelectedRows[0].Cells[0].Value;
            var frm = new frmUtakmiceDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
