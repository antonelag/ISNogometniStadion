﻿using ISNogometniStadion.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISNogometniStadion.WinUI.Tribine
{
    public partial class FrmTribine : Form
    {
        private readonly APIService _apiService = new APIService("Tribine");
        public FrmTribine()
        {
            InitializeComponent();
        }

        private async void BtnPretrazi_Click(object sender, EventArgs e)
        {
            var search = new TimoviSearchRequest()
            {
                Naziv = txtPretraga.Text
            };
            var res = await _apiService.Get<dynamic>(search);
            dgvTribine.AutoGenerateColumns = false;
            dgvTribine.DataSource = res;

        }

        private void DgvTribine_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvTribine.SelectedRows[0].Cells[0].Value;
            var frm = new FrmTribineDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
