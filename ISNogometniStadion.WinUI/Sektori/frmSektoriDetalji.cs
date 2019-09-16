﻿using ISNogometniStadion.Model;
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

namespace ISNogometniStadion.WinUI.Utakmice
{
    public partial class frmSektoriDetalji : Form
    {
        private readonly APIService _apiServiceSektori = new APIService("Sektori");
        private readonly APIService _apiServiceTribine = new APIService("Tribine");
        private readonly int? _id = null;
        public frmSektoriDetalji(int? id=null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void FrmSektoriDetalji_Load(object sender, EventArgs e)
        {
           await LoadTribine();
            if (_id.HasValue)
            {
                Sektor a = await _apiServiceSektori.GetById<Sektor>(_id);
                txtNaziv.Text = a.Naziv;
                cbTribine.SelectedValue = int.Parse(a.TribinaID.ToString());
            }
        }
        private async Task LoadTribine()
        {
            var result = await _apiServiceTribine.Get<List<Model.Tribina>>(null);
            cbTribine.DisplayMember = "Naziv";
            cbTribine.ValueMember = "TribinaID";
            cbTribine.SelectedItem = null;
            cbTribine.SelectedText = "--Odaberite--";
            cbTribine.DataSource = result;
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var req = new SektoriInsertRequest()
                {
                    Naziv = txtNaziv.Text,
                    TribinaID = int.Parse(cbTribine.SelectedValue.ToString())
                };
                if (_id.HasValue)
                {
                    int i = (int)_id;
                    await _apiServiceSektori.Update<dynamic>(i, req);
                }
                else
                    await _apiServiceSektori.Insert<dynamic>(req);
                MessageBox.Show("Operacija uspjesna!");
                this.Close();
            }
            else
                MessageBox.Show("Operacija nije uspjela!");
        }

        private void TxtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider1.SetError(txtNaziv, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtNaziv.Text, @"^[a-zA-Z0-9 ]+$"))//brojevi i/ili slova
            {
                errorProvider1.SetError(txtNaziv, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtNaziv, null);
        }

        private void CbTribine_Validating(object sender, CancelEventArgs e)
        {

            if (cbTribine.SelectedItem == null)
            {
                errorProvider1.SetError(cbTribine, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(cbTribine, null);
        }
    }
}
