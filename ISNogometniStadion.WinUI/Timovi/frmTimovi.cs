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

namespace ISNogometniStadion.WinUI.Timovi
{
    public partial class frmTimovi : Form
    {
        private readonly APIService _apiService = new APIService("Timovi");
        public frmTimovi()
        {
            InitializeComponent();
        }

        private async void BtnPretrazi_Click(object sender, EventArgs e)
        {
            var search = new TimoviSearchRequest()
            {
                Naziv = txtPretraga.Text
            };
            var res = await _apiService.Get<dynamic>(search);
            dgvTimovi.DataSource = res;
        }

        private void DgvTimovi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvTimovi.SelectedRows[0].Cells[0].Value;
            var frm = new frmTimoviDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
