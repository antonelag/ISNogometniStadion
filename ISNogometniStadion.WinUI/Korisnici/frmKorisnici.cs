using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using ISNogometniStadion.Model;

namespace ISNogometniStadion.WinUI.Korisnici
{
    public partial class FrmKorisnici : Form
    {
        private readonly APIService _APIService = new APIService("Korisnici");
        public FrmKorisnici()
        {
            InitializeComponent();
        }

        private async void BtnPrikazi_Click(object sender, EventArgs e)
        {
            //pozivamo api
            //async await- da ne ceka api
            var search = new KorisniciSearchRequest()
            {
                ImePrezime = txtPretraga.Text
            };
            var result = await _APIService.Get<dynamic>(search);
            dgvKorisnici.AutoGenerateColumns = false; // da ne generise sama kontrole
            dgvKorisnici.DataSource = result;

        }

        private void DgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKorisnici.SelectedRows[0].Cells[0].Value;
            var frm = new FrmKorisniciDetalji(int.Parse(id.ToString()));
            frm.Show();

        }
    }
}
