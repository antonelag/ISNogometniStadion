using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISNogometniStadion.WinUI.Drzave
{
    public partial class FrmDrzaveTemp : Form
    {
        public DrzaveApiService drzaveApiService = new DrzaveApiService("DrzaveGet");
        public FrmDrzaveTemp()
        {
            InitializeComponent();
        }
        private const int WM_CLOSE = 0x0010;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_CLOSE)
                AutoValidate = AutoValidate.Disable;
            base.WndProc(ref m);
        }

        private void TxtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                errorProvider1.SetError(txtNaziv, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtNaziv.Text, @"^[a-zA-Z ]+$"))
            {
                errorProvider1.SetError(txtNaziv, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtNaziv, null);
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                List<Drzava> lista = await drzaveApiService.Get<List<Drzava>>(new DrzaveSearchRequest() { Naziv = txtNaziv.Text });
                lista = lista.Where(s => s.Naziv.Equals(txtNaziv.Text)).ToList();
                if (lista.Count == 0)
                {
                    DrzaveInsertRequest req = new DrzaveInsertRequest() { Naziv = txtNaziv.Text };
                    try
                    {

                        await drzaveApiService.Insert<Drzava>(req);
                        MessageBox.Show("Operacija uspjela!");
                        this.Close();
                    }
                    catch (Exception)
                    {
                    }
                }
                else
                {
                    MessageBox.Show("Već postoji unesena država!");
                }
            }
            else
            {
                MessageBox.Show("Operacija nije uspjela!");
                this.Close();
            }
        }
    }
}
