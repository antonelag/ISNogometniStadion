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

namespace ISNogometniStadion.WinUI.Gradovi
{
    public partial class frmGradovi : Form
    {
        private readonly APIService _apiService = new APIService("Gradovi");
        public frmGradovi()
        {
            InitializeComponent();
        }

        private async void BtnPretrazi_Click(object sender, EventArgs e)
        {
            var search = new GradoviSearchRequest()
            {
                Naziv = txtPretraga.Text
            };

            var result = await _apiService.Get<dynamic>(search);
            dgvGradovi.AutoGenerateColumns = false;
            dgvGradovi.DataSource = result;
        }

        private void DgvGradovi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvGradovi.SelectedRows[0].Cells[0].Value;
            var frm = new frmGradoviDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
