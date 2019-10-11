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
    public partial class frmDrzaveDetalji : Form
    {
        private readonly int? _id = null;
        private readonly APIService _apiService = new APIService("Drzave");

        public frmDrzaveDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private const int WM_CLOSE = 0x0010;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_CLOSE)
                AutoValidate = AutoValidate.Disable;
            base.WndProc(ref m);
        }
        private void TextBox1_Validating(object sender, CancelEventArgs e)
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
                List<Drzava> lista = await _apiService.Get<List<Drzava>>(new DrzaveSearchRequest() { Naziv = txtNaziv.Text });
                if (lista.Count == 0)
                {
                    var req = new DrzaveInsertRequest()
                    {
                        Naziv = txtNaziv.Text
                    };
                    if (_id.HasValue)
                    {
                        int i = (int)_id;
                        try
                        {
                            await _apiService.Update<dynamic>(i, req);
                            MessageBox.Show("Operacija je uspjela!");
                            this.Close();
                        }
                        catch (Exception)
                        {
                        }
                    }
                    else
                    {
                        try
                        {
                            await _apiService.Insert<dynamic>(req);
                            MessageBox.Show("Operacija je uspjela!");
                            this.Close();
                        }
                        catch (Exception)
                        {
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Unesena država već postoji!");
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("Operacija nije uspjela!");
                this.Close();
            }
        }

        private async void FrmDrzaveDetalji_Load(object sender, EventArgs e)
        {
            if (_id != null)
            {
                var res = await _apiService.GetById<dynamic>(_id);
                txtNaziv.Text = res.naziv;
            }
        }
    }
}
