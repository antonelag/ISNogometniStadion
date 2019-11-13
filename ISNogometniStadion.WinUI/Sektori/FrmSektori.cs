using ISNogometniStadion.Model;
using ISNogometniStadion.WinUI.Utakmice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISNogometniStadion.WinUI.Sektori
{
    public partial class FrmSektori : Form
    {
        private readonly APIService _apiServiceSektori = new APIService("Sektori");
        private readonly APIService _apiServiceTribine = new APIService("Tribine");

        public FrmSektori()
        {
            InitializeComponent();
        }
        private async Task loadSveTribine()
        {
            var result = await _apiServiceTribine.Get<List<Model.Tribina>>(null);
            cbTribine.DisplayMember = "Naziv";
            cbTribine.ValueMember = "TribinaID";
            result.Insert(0, new Model.Tribina());
            cbTribine.DataSource = result;
            cbTribine.Text = "--Odaberite tribinu--";
        }
        private async Task LoadSektori(int id)
        {
            var result = await _apiServiceSektori.Get<List<Model.Sektor>>(new SektoriSearchRequest()
            {
                TribinaID = id
            });
            dgvSektori.AutoGenerateColumns = false;
            dgvSektori.DataSource = result;
        }

        private async void FrmSektori_Load(object sender, EventArgs e)
        {
            await loadSveTribine();
        }

        private async void CbTribine_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cbTribine.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadSektori(id);
            }
        }

        private void DgvSektori_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvSektori.SelectedRows[0].Cells[0].Value;
            var frm = new frmSektoriDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
