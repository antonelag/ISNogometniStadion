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

namespace ISNogometniStadion.WinUI.Sjedala
{
    public partial class frmSjedalaDetalji : Form
    {
        private readonly int? _id = null;
        private readonly APIService _apiService = new APIService("Sjedala");
        private readonly APIService _apiServiceSektori = new APIService("Sektori");
        public frmSjedalaDetalji(int? id = null)
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

        private async void FrmSjedalaDetalji_Load(object sender, EventArgs e)
        {
            await LoadSektori();
            if (_id.HasValue)
            {
                Sjedalo r = await _apiService.GetById<Sjedalo>(_id);
                txtOznaka.Text = r.Oznaka;
                cbSektori.SelectedValue = int.Parse(r.SektorID.ToString());
                cbxStatus.Checked = r.Status;
            }
        }
        private async Task LoadSektori()
        {
            var result = await _apiServiceSektori.Get<List<Model.Sektor>>(null);
            cbSektori.DisplayMember = "SektorPodaci";
            cbSektori.ValueMember = "SektorID";

            cbSektori.DataSource = result;
            cbSektori.SelectedItem = null;
            cbSektori.SelectedText = "--Odaberite--";
        }

        private async void BtnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                List<Sjedalo> lista = await _apiService.Get<List<Sjedalo>>(new SjedalaSearchRequest() { Oznaka = txtOznaka.Text, SektorID = int.Parse(cbSektori.SelectedValue.ToString()) });
                if (lista.Count == 0)
                {
                    var req = new SjedalaInsertRequest()
                    {
                        Oznaka = txtOznaka.Text,
                        SektorID = int.Parse(cbSektori.SelectedValue.ToString()),
                        Status = cbxStatus.Checked
                    };

                    if (_id.HasValue)
                    {
                        try
                        {
                            int i = (int)_id;
                            await _apiService.Update<dynamic>(i, req);
                            MessageBox.Show("Operacija uspjesna!");
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
                            MessageBox.Show("Operacija uspjesna!");
                            this.Close();
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Uneseno sjedalo već postoji za isti sektor!");
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Operacija nije uspjela");
                this.Close();
            }

        }

        private void TxtOznaka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOznaka.Text))
            {
                errorProvider1.SetError(txtOznaka, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtOznaka.Text, @"^[a-zA-Z0-9 ]+$"))//brojevi i/ili slova
            {
                errorProvider1.SetError(txtOznaka, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtOznaka, null);
        }

        private void CbSjedala_Validating(object sender, CancelEventArgs e)
        {
            if (cbSektori.SelectedItem == null)
            {
                errorProvider1.SetError(cbSektori, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(cbSektori, null);
        }



    }
}
