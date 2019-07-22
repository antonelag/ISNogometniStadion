﻿using ISNogometniStadion.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISNogometniStadion.WinUI.Sjedala
{
    public partial class frmSjedalaDetalji : Form
    {
        private readonly int? _id = null;
        private readonly APIService _apiService = new APIService("Sjedala");
        public frmSjedalaDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void FrmSjedalaDetalji_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iSNogometniStadionDBDataSet.Tribine' table. You can move, or remove it, as needed.
            this.tribineTableAdapter.Fill(this.iSNogometniStadionDBDataSet.Tribine);
            if (_id.HasValue)
            {
                var r = await _apiService.GetById<dynamic>(_id);
                txtOznaka.Text = r.oznaka;
                cbSjedala.SelectedValue = int.Parse(r.tribinaID.ToString());
            }
        }

        private async void BtnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var req = new SjedalaInsertRequest()
                {
                    Oznaka = txtOznaka.Text,
                    TribinaID = (int)cbSjedala.SelectedValue
                };
                if (_id.HasValue)
                    await _apiService.Update<dynamic>(_id, req);
                else
                    await _apiService.Insert<dynamic>(req);
                MessageBox.Show("Operacija uspjesna!");
                this.Close();
            }
            else
                MessageBox.Show("Operacija nije uspjela!");
        }

        private void TxtOznaka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOznaka.Text))
            {
                errorProvider1.SetError(txtOznaka, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtOznaka, null);
        }

        private void CbSjedala_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(cbSjedala.SelectedValue.ToString()))
            {
                errorProvider1.SetError(cbSjedala, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(cbSjedala, null);
        }


      
    }
}
