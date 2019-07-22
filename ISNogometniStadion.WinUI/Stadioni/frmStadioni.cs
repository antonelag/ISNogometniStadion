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

namespace ISNogometniStadion.WinUI.Stadioni
{
    public partial class frmStadioni : Form
    {
        private readonly APIService _apiService = new APIService("Stadioni");
        public frmStadioni()
        {
            InitializeComponent();
        }

        private async void BtnPretrazi_Click(object sender, EventArgs e)
        {
            var search = new StadioniSearchRequest()
            {
                Naziv = txtPretraga.Text
            };
            var res = await _apiService.Get<dynamic>(search);
            dgvStadioni.AutoGenerateColumns = false;
            dgvStadioni.DataSource = res;

        }

        private void DgvStadioni_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //odrediti na dgv full row select na selection mode!!
            var id = dgvStadioni.SelectedRows[0].Cells[0].Value;
            var frm = new frmStadionDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
