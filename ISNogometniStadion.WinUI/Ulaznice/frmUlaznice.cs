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

namespace ISNogometniStadion.WinUI.Ulaznice
{
    public partial class frmUlaznice : Form
    {
        private readonly APIService _apiService = new APIService("Ulaznica");
        public frmUlaznice()
        {
            InitializeComponent();
        }

        private async void BtnPretrazi_Click(object sender, EventArgs e)
        {
            var search = new UlazniceSearchRequest()
            {
                OznakaSjedala = txtPretraga.Text
            };
            var a = await _apiService.Get<dynamic>(search);
            dgvUlaznice.DataSource = a;

        }

        private void DgvUlaznice_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvUlaznice.SelectedRows[0].Cells[0].Value;
            var frm = new frmUlazniceDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private void FrmUlaznice_Load(object sender, EventArgs e)
        {

        }
    }
}
