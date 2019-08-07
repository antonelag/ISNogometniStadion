using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISNogometniStadion.WinUI
{
    public partial class frmLogin : Form
    {
        private readonly APIService _apiService = new APIService("Korisnici");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void TxtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtKorisnickoIme.Text))
            {
                errorProvider1.SetError(txtKorisnickoIme, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtKorisnickoIme, null);
        }

        private void TxtLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLozinka.Text))
            {
                errorProvider1.SetError(txtLozinka, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtLozinka, null);
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            APIService.KorisnickoIme = txtKorisnickoIme.Text;
            APIService.Lozinka = txtLozinka.Text;

            try
            {
                await _apiService.Get<dynamic>(null);
                var frm = new frmIndex();
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
