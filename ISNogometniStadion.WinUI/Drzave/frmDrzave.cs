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

namespace ISNogometniStadion.WinUI.Drzave
{
    public partial class FrmDrzave : Form
    {
        private readonly APIService _apiService = new APIService("Drzave");
        public FrmDrzave()
        {
            InitializeComponent();
        }

        private async void BtnPretrazi_Click(object sender, EventArgs e)
        {
            var search = new DrzaveSearchRequest
            {
                Naziv = txtPretraga.Text
            };
            var result = await _apiService.Get<dynamic>(search);
            dgvDrzave.AutoGenerateColumns = false;
            dgvDrzave.DataSource = result;
        }

        private void DgvDrzave_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvDrzave.SelectedRows[0].Cells[0].Value;
            var frm = new FrmDrzaveDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

    }
}
