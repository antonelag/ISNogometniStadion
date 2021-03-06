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

namespace ISNogometniStadion.WinUI.Stadioni
{
    public partial class FrmStadioni : Form
    {
        private readonly APIService _apiService = new APIService("Stadioni");
        private readonly APIService _apiServiceGradovi = new APIService("Gradovi");
        public FrmStadioni()
        {
            InitializeComponent();
        }

        private async Task LoadSviGradovi()
        {
            var result = await _apiServiceGradovi.Get<List<Model.Grad>>(null);
            cbGradovi.DisplayMember = "Naziv";
            cbGradovi.ValueMember = "GradID";
            result.Insert(0, new Model.Grad());
            cbGradovi.DataSource = result;
            cbGradovi.Text = "--Odaberite grad--";
        }
        private async Task LoadStadioni(int id)
        {
            var result = await _apiService.Get<List<Model.Stadion>>(new StadioniSearchRequest()
            {
                GradID = id
            });
            dgvStadioni.AutoGenerateColumns = false;
            dgvStadioni.DataSource = result;
        }
        private void DgvStadioni_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //odrediti na dgv full row select na selection mode!!
            var id = dgvStadioni.SelectedRows[0].Cells[0].Value;
            var frm = new FrmStadionDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void FrmStadioni_Load(object sender, EventArgs e)
        {
            await LoadSviGradovi();
        }

        private async void CbGradovi_SelectedIndexChanged(object sender, EventArgs e)
        {

            var idObj = cbGradovi.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadStadioni(id);
            }
        }
    }
}
