﻿using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISNogometniStadion.WinUI.Utakmice
{
    public partial class FrmUtakmiceDetalji : Form
    {
        private readonly int? _id = null;
        private readonly APIService _apiService = new APIService("Utakmice");
        private readonly APIService _apiServiceStadioni = new APIService("Stadioni");
        private readonly APIService _apiServiceTimovi = new APIService("Timovi");
        private readonly APIService _apiServiceLige = new APIService("Lige");
        private readonly ImageService _imageService = new ImageService();

        public FrmUtakmiceDetalji(int? id = null)
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
        private async void FrmUtakmiceDetalji_Load(object sender, EventArgs e)
        {
            await LoadDomaci();
            await LoadGosti();
            await LoadStadioni();
            await LoadLige();

            if (_id.HasValue)
            {
                Model.Utakmica a = await _apiService.GetById<Model.Utakmica>(_id);
                cbDomaci.SelectedValue = int.Parse(a.DomaciTimID.ToString());
                cbGosti.SelectedValue = int.Parse(a.GostujuciTimID.ToString());
                dtpDatum.Value = a.DatumOdigravanja;
                dtpVrijeme.Value = a.VrijemeOdigravanja;
                cbStadion.SelectedValue = int.Parse(a.StadionID.ToString());
                cbLiga.SelectedValue = int.Parse(a.LigaID.ToString());


                if (a.Slika.Length != 0)
                {
                    var img = _imageService.BytesToImage(a.Slika);
                    Image mythumb = _imageService.ImageToThumbnail(img);
                    pictureBox1.Image = mythumb;
                }
                else
                {
                    var noimg = _imageService.GetNoImage();
                    var th = _imageService.ImageToThumbnail(noimg);
                    pictureBox1.Image = th;
                }

            }

        }
        private async Task LoadStadioni()
        {
            var result = await _apiServiceStadioni.Get<List<Model.Stadion>>(null);
            cbStadion.DisplayMember = "Naziv";
            cbStadion.ValueMember = "StadionID";
            cbStadion.SelectedItem = null;
            cbStadion.SelectedText = "--Odaberite--";
            cbStadion.DataSource = result;
        }
        private async Task LoadLige()
        {
            var result = await _apiServiceLige.Get<List<Model.Liga>>(null);
            cbLiga.DisplayMember = "Naziv";
            cbLiga.ValueMember = "LigaID";
            cbLiga.SelectedItem = null;
            cbLiga.SelectedText = "--Odaberite--";
            cbLiga.DataSource = result;
        }
        private async Task LoadDomaci()
        {
            var result = await _apiServiceTimovi.Get<List<Model.Tim>>(null);
            cbDomaci.DisplayMember = "Naziv";
            cbDomaci.ValueMember = "TimID";
            cbDomaci.SelectedItem = null;
            cbDomaci.SelectedText = "--Odaberite--";
            cbDomaci.DataSource = result;

        }
        private async Task LoadGosti()
        {
            var result = await _apiServiceTimovi.Get<List<Model.Tim>>(null);

            cbGosti.DisplayMember = "Naziv";
            cbGosti.ValueMember = "TimID";
            cbGosti.SelectedItem = null;
            cbGosti.SelectedText = "--Odaberite--";
            cbGosti.DataSource = result;
        }

        private void CbDomaci_Validating(object sender, CancelEventArgs e)
        {
            if (cbDomaci.SelectedItem == null && int.Parse(cbDomaci.SelectedValue.ToString()) != int.Parse(cbGosti.SelectedValue.ToString()))
            {
                errorProvider1.SetError(cbDomaci, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(cbDomaci, null);
        }

        private void CbGosti_Validating(object sender, CancelEventArgs e)
        {
            if (cbGosti.SelectedItem == null)
            {
                errorProvider1.SetError(cbGosti, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(cbGosti, null);
        }

        private void CbStadion_Validating(object sender, CancelEventArgs e)
        {
            if (cbStadion.SelectedItem == null)
            {
                errorProvider1.SetError(cbStadion, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(cbStadion, null);
        }
        private void CbLiga_Validating(object sender, CancelEventArgs e)
        {
            if (cbLiga.SelectedItem == null)
            {
                errorProvider1.SetError(cbLiga, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(cbLiga, null);
        }

        private void DtpDatum_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dtpDatum.Value.Date.ToString()))
            {
                errorProvider1.SetError(dtpDatum, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(dtpDatum, null);

        }

        private void DtpVrijeme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dtpVrijeme.Value.TimeOfDay.ToString()))
            {
                errorProvider1.SetError(dtpVrijeme, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(dtpVrijeme, null);

        }
        UtakmiceInsertRequest req = new UtakmiceInsertRequest();
        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() && int.Parse(cbDomaci.SelectedValue.ToString()) != int.Parse(cbGosti.SelectedValue.ToString()))
            {


                //radi nemogucnosti nacina da na razini baze ogranicimo unos zamjene timova(gosti/domaci) a istog datuma
                var stadionid = int.Parse(cbStadion.SelectedValue.ToString());
                ; var t = await _apiService.Get<List<Model.Utakmica>>(null);
                var utakmiceSaIstimStadionom = await _apiService.Get<List<Model.Utakmica>>(new UtakmiceeSearchRequest() { StadionID = stadionid });
                var domaciid = int.Parse(cbDomaci.SelectedValue.ToString());
                var gostiid = int.Parse(cbGosti.SelectedValue.ToString());
                var obrnutiisti = false;
                var isti = false;
                var postojecaUtakmica = false;
                if (utakmiceSaIstimStadionom.Count != 0)
                {
                    foreach (var u in utakmiceSaIstimStadionom)
                    {
                        if (u.UtakmicaID != _id)
                            postojecaUtakmica = true;
                    }
                }


                foreach (var a in t)
                {
                    if ((a.GostujuciTimID == domaciid || a.DomaciTimID == gostiid) && DateTime.Compare(a.DatumOdigravanja.Date, dtpDatum.Value.Date) == 0 && a.UtakmicaID != _id)
                    {
                        obrnutiisti = true;
                        break;
                    }

                }
                foreach (var a in t)
                {
                    if ((a.GostujuciTimID == gostiid || a.DomaciTimID == domaciid) && DateTime.Compare(a.DatumOdigravanja.Date, dtpDatum.Value.Date) == 0 && a.UtakmicaID != _id)
                    {
                        isti = true;
                        break;
                    }

                }

                if (!obrnutiisti && !isti && !postojecaUtakmica)
                {

                    req.DatumOdigravanja = dtpDatum.Value.Date + dtpVrijeme.Value.TimeOfDay;
                    req.VrijemeOdigravanja = dtpDatum.Value.Date + dtpVrijeme.Value.TimeOfDay;
                    req.DomaciTimID = int.Parse(cbDomaci.SelectedValue.ToString());
                    req.GostujuciTimID = int.Parse(cbGosti.SelectedValue.ToString());
                    req.StadionID = int.Parse(cbStadion.SelectedValue.ToString());
                    req.LigaID = int.Parse(cbLiga.SelectedValue.ToString());


                    if (req.Slika == null && _id.HasValue)
                    {
                        Utakmica a = await _apiService.GetById<Utakmica>(_id);
                        req.Slika = a.Slika;
                        req.SlikaThumb = a.SlikaThumb;
                    }

                    //za slucaj da korisnik ne unese sliku
                    if (req.Slika == null && !_id.HasValue)
                    {
                        var img = _imageService.GetNoImage();
                        req.Slika = _imageService.ImageToBytes(img);
                        var th = _imageService.ImageToThumbnail(img);
                        req.SlikaThumb = _imageService.ImageToBytes(th);
                    }
                    if (_id.HasValue)
                    {
                        int i = (int)_id;
                        try
                        {
                            await _apiService.Update<dynamic>(i, req);
                            MessageBox.Show("Operacija uspjela");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Operacija nije uspjela");
                        }
                    }
                    else
                    {
                        try
                        {
                            await _apiService.Insert<dynamic>(req);
                            MessageBox.Show("Operacija uspjela");

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Operacija nije uspjela");
                        }

                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Operacija nije uspjela");
                    this.Close();
                }


            }
            else
            {
                MessageBox.Show("Operacija nije uspjela");
                this.Close();
            }
        }


        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                req.Slika = file;
                Image image = Image.FromFile(fileName);

                Image mythumb = _imageService.ImageToThumbnail(image);
                req.SlikaThumb = _imageService.ImageToBytes(mythumb);
                pictureBox1.Image = mythumb;

            }
        }

        
    }
}
