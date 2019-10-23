using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using ISNogometniStadion.WinUI.Drzave;
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

namespace ISNogometniStadion.WinUI.Gradovi
{
    public partial class FrmGradoviTemp : Form
    {
        public DrzaveApiService _apiServiceDrzave = new DrzaveApiService("DrzaveGet");
        public GradoviApiService _apiServiceGradovi = new GradoviApiService("GradoviGet");
        public FrmGradoviTemp()
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

        private async void FrmGradoviTemp_Load(object sender, EventArgs e)
        {
            await LoadDrzave();
        }
        private async Task LoadDrzave()
        {
            var result = await _apiServiceDrzave.Get<List<Model.Grad>>(null);
            cbDrzava.DisplayMember = "Naziv";
            cbDrzava.ValueMember = "DrzavaID";
            cbDrzava.SelectedItem = null;
            cbDrzava.SelectedText = "--Odaberite--";
            cbDrzava.DataSource = result;
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
                List<Grad> lista = await _apiServiceGradovi.Get<List<Grad>>(new GradoviSearchRequest() { Naziv = txtNaziv.Text, DrzavaID = int.Parse(cbDrzava.SelectedValue.ToString()) });
                if (lista.Count == 0)
                {
                    GradoviInsertRequest req = new GradoviInsertRequest()
                    {
                        DrzavaID = int.Parse(cbDrzava.SelectedValue.ToString()),
                        Naziv = txtNaziv.Text
                    };

                    try
                    {
                        await _apiServiceGradovi.Insert<Grad>(req);
                        MessageBox.Show("Operacija uspjela!");
                        this.Close();
                    }
                    catch (Exception)
                    {
                    }
                }
                else
                {
                    MessageBox.Show("Već postoji uneseni grad u unesenoj državi");
                }
            }
            else
            {
                MessageBox.Show("Operacija nije uspjela.");
                this.Close();
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new FrmDrzaveTemp();
            frm.Show();
            this.Close();
        }
    }
}
