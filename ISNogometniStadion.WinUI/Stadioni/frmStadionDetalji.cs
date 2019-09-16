using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISNogometniStadion.WinUI.Stadioni
{
    public partial class frmStadionDetalji : Form
    {
        private readonly int? _id = null;
        private readonly APIService _apiService = new APIService("Stadioni");
        private readonly APIService _apiServiceFradovi = new APIService("Gradovi");
        private readonly ImageService _imageService = new ImageService();


        public frmStadionDetalji(int? id = null)
        {
            _id = id;
            InitializeComponent();
        }

        private async void FrmStadionDetalji_Load(object sender, EventArgs e)
        {
            await LoadGradovi();
            if (_id.HasValue)
            {
                Stadion r = await _apiService.GetById<Stadion>(_id);
                txtNaziv.Text = r.Naziv;
                txtOpis.Text = r.Opis;
                cbStadioni.SelectedValue = int.Parse(r.GradID.ToString());
                txtlat.Text = r.lat;
                txtlng.Text = r.lng;


                if (r.Slika.Length != 0)
                {
                    var img = _imageService.BytesToImage(r.Slika);
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
        private async Task LoadGradovi()
        {
            var result = await _apiServiceFradovi.Get<List<Model.Grad>>(null);
            cbStadioni.DisplayMember = "Naziv";
            cbStadioni.ValueMember = "GradID";
            cbStadioni.SelectedItem = null;
            cbStadioni.SelectedText = "--Odaberite--";
            cbStadioni.DataSource = result;
        }

        private void TxtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                errorProvider1.SetError(txtNaziv, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;

            }
            else if (!Regex.IsMatch(txtNaziv.Text, @"^[a-zA-Z ]+$")) //samoslova
            {
                errorProvider1.SetError(txtNaziv, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtNaziv, null);
        }

        private void CbStadioni_Validating(object sender, CancelEventArgs e)
        {
            if (cbStadioni.SelectedItem==null)
            {
                errorProvider1.SetError(cbStadioni, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;

            }
            else
                errorProvider1.SetError(cbStadioni, null);
        }
        StadioniInsertRequest req = new StadioniInsertRequest();
        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                req.Naziv = txtNaziv.Text;
                req.Opis = txtOpis.Text;
                req.GradID = int.Parse(cbStadioni.SelectedValue.ToString());
                req.lat = txtlat.Text;
                req.lng = txtlng.Text;
               
                //spremanje slike u request se radi prilikom klika na dodaj 
                //ako nije dodao novu sliku(UPDATE), samim time nije kliknuo na dodaj, trebala bi slika ostati nepromijenjena
                if (req.Slika == null && _id.HasValue)
                {
                    Stadion a = await _apiService.GetById<Stadion>(_id);
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
                    await _apiService.Update<dynamic>(i, req);
                }
                else
                    await _apiService.Insert<dynamic>(req);
                MessageBox.Show("Operacija uspjesna!");
                this.Close();
            }
            else
                MessageBox.Show("Operacija nije uspjela");
        }

        private void TxtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOpis.Text))
            {
                errorProvider1.SetError(txtOpis, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;

            }
            else
                errorProvider1.SetError(txtOpis, null);
        }
        public bool ThumbnailCallback()
        {
            return false;
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

        private void TextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtlat.Text))
            {
                errorProvider1.SetError(txtlat, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;

            }
            else
                errorProvider1.SetError(txtlng
                    , null);
        }

        private void Txtlng_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtlng.Text))
            {
                errorProvider1.SetError(txtlng, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;

            }
            else
                errorProvider1.SetError(txtlng
                    , null);
        }
    }
    }

