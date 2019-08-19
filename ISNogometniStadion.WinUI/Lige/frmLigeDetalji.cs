using ISNogometniStadion.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISNogometniStadion.WinUI.Lige
{
    public partial class frmLigeDetalji : Form
    {
        private readonly int? _id = null;
        private readonly APIService _apiService = new APIService("Lige");

        private readonly APIService _apiServiceDrzave = new APIService("Drzave");
        public frmLigeDetalji(int? id=null)
        {

            InitializeComponent();
            _id = id;
        }

        private async Task LoadDrzave()
        {
            var result = await _apiServiceDrzave.Get<List<Model.Drzava>>(null);
            cbDrzave.DisplayMember = "Naziv";
            cbDrzave.ValueMember = "DrzavaID";
            cbDrzave.SelectedItem = null;
            cbDrzave.SelectedText = "--Odaberite--";
            cbDrzave.DataSource = result;
        }

        private void TxtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text) == null)
            {
                errorProvider1.SetError(txtNaziv, Properties.Resources.ObaveznoPolje);
            }
            else
                errorProvider1.SetError(txtNaziv, null);
        }

        private void CbDrzave_Validating(object sender, CancelEventArgs e)
        {
            if (cbDrzave.SelectedItem == null)
            {
                errorProvider1.SetError(cbDrzave, Properties.Resources.ObaveznoPolje);
            }
            else
                errorProvider1.SetError(cbDrzave, null);
        }

        private async void FrmLigeDetalji_Load(object sender, EventArgs e)
        {
            await LoadDrzave();
            if (_id.HasValue)
            {
                var a = await _apiService.GetById<dynamic>(_id);
                txtNaziv.Text = a.naziv;
                cbDrzave.SelectedValue = int.Parse(a.drzavaID.ToString());
            }
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var req = new LigaInsertRequest()
                {
                    Naziv=txtNaziv.Text,
                    DrzavaID= int.Parse(cbDrzave.SelectedValue.ToString())
                };
                if (_id.HasValue)
                {
                    int i = (int)_id;
                    await _apiService.Update<dynamic>(i, req);
                }
                else
                    await _apiService.Insert<dynamic>(req);

                MessageBox.Show("Operacija uspjela");
                this.Close();
            }
            else
                MessageBox.Show("Operacija nije uspjela!");
        }
    }
}
