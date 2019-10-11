using ISNogometniStadion.Model;
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

namespace ISNogometniStadion.WinUI.Ulaznice
{
    public partial class frmUlazniceDetalji : Form
    {
        private readonly int? _id = null;
        private readonly APIService _apiService = new APIService("Ulaznica");
        private readonly APIService _apiServiceSjedala = new APIService("Sjedala");
        private readonly APIService _apiServiceSektori = new APIService("Sektori");
        private readonly APIService _apiServiceTribine = new APIService("Tribine");
        private readonly APIService _apiServicePreporuke = new APIService("Preporuke");
        private readonly APIService _apiServiceTimovi = new APIService("Timovi");

        private readonly APIService _apiServiceUtakmica = new APIService("Utakmice");
        private readonly APIService _apiServiceKorisnici = new APIService("Korisnici");
        public frmUlazniceDetalji(int? id = null)
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
        private async void FrmUlazniceDetalji_Load(object sender, EventArgs e)
        {
            await LoadUtakmica();
            //await LoadSektori();
            //await LoadSjedala();
            await LoadKorisnici();
            if (_id.HasValue)
            {

                Ulaznica a = await _apiService.GetById<Ulaznica>(_id);
                Sjedalo sjedalo = await _apiServiceSjedala.GetById<Sjedalo>(a.SjedaloID);
                cbUtakmica.SelectedValue = int.Parse(a.UtakmicaID.ToString());
                cbSektor.SelectedValue = int.Parse(sjedalo.SektorID.ToString());
                cbKorisnik.SelectedValue = int.Parse(a.KorisnikID.ToString());
                cbSjedala.SelectedValue = int.Parse(a.SjedaloID.ToString());
                dtpDatum.Value = a.DatumKupnje;
                dtpVrijeme.Value = a.VrijemeKupnje;
            }
        }
        private async Task LoadSjedala()
        {
            var result = await _apiServiceSjedala.Get<List<Model.Sjedalo>>(null);
            cbSjedala.DisplayMember = "Oznaka";
            cbSjedala.ValueMember = "SjedaloID";
            cbSjedala.DataSource = result;
            cbSjedala
                .SelectedItem = null;
            cbSjedala.SelectedText = "--Odaberite--";

        }
        private async Task LoadSektori()
        {
            var result = await _apiServiceSektori.Get<List<Model.Sektor>>(null);
            cbSektor
                .DisplayMember = "SektorPodaci";
            cbSektor.ValueMember = "SektorID";
            cbSektor.DataSource = result;
            cbSektor.SelectedItem = null;
            cbSektor.SelectedText = "--Odaberite--";
        }
        private async Task LoadUtakmica()
        {
            var result = await _apiServiceUtakmica.Get<List<Model.Utakmica>>(null);
            cbUtakmica.DataSource = result;
            cbUtakmica.DisplayMember = "UtakmicaPodaci";
            cbUtakmica.ValueMember = "UtakmicaID";
            cbUtakmica.SelectedItem = null;
            cbUtakmica.SelectedText = "--Odaberite--";
        }
        private async Task LoadKorisnici()
        {
            var result = await _apiServiceKorisnici.Get<List<Model.Korisnik>>(null);
            cbKorisnik.DisplayMember = "KorisnikPodaci";
            cbKorisnik.ValueMember = "KorisnikID";
            cbKorisnik.DataSource = result;
            cbKorisnik.SelectedItem = null;
            cbKorisnik.SelectedText = "--Odaberite--";
        }

        private void CbSjedala_Validating(object sender, CancelEventArgs e)
        {
            if (cbSjedala.SelectedItem == null)
            {
                errorProvider1.SetError(cbSjedala, Properties.Resources.ObaveznoPolje);
            }
            else
                errorProvider1.SetError(cbSjedala, null);

        }

        private void CbUtakmica_Validating(object sender, CancelEventArgs e)
        {

            if (cbUtakmica.SelectedItem == null)
            {
                errorProvider1.SetError(cbUtakmica, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(cbUtakmica, null);
        }

        private void CbKorisnik_Validating(object sender, CancelEventArgs e)
        {
            if (cbKorisnik.SelectedItem == null)
            {
                errorProvider1.SetError(cbKorisnik, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(cbKorisnik, null);
        }

        private void DtpDatum_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dtpDatum.Value.ToString()))
            {
                errorProvider1.SetError(dtpDatum, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(dtpDatum, null);
        }

        private void DtpVrijeme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dtpVrijeme.Value.ToString()))
            {
                errorProvider1.SetError(dtpVrijeme, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(dtpVrijeme, null);
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                int prosloSjedalo = -1;
                int proslaUtakmica = -1;
                int prosliKorisnik = -1;
                if (_id.HasValue)
                {
                    Ulaznica u = await _apiService.GetById<Ulaznica>(_id);
                    prosloSjedalo = u.SjedaloID;
                    proslaUtakmica = u.UtakmicaID;
                    prosliKorisnik = u.KorisnikID;
                }
                Korisnik k = await _apiServiceKorisnici.GetById<Korisnik>(int.Parse(cbKorisnik.SelectedValue.ToString()));
                var req = new UlazniceInsertRequest()
                {
                    DatumKupnje = dtpDatum.Value.Date + dtpVrijeme.Value.TimeOfDay,
                    VrijemeKupnje = dtpDatum.Value.Date + dtpVrijeme.Value.TimeOfDay,
                    KorisnikID = int.Parse(cbKorisnik.SelectedValue.ToString()),
                    SjedaloID = int.Parse(cbSjedala.SelectedValue.ToString()),
                    UtakmicaID = int.Parse(cbUtakmica.SelectedValue.ToString())
                };
                Sjedalo s1 = await _apiServiceSjedala.GetById<Sjedalo>(req.SjedaloID);
                s1.Status = true;
                SjedalaInsertRequest r1 = new SjedalaInsertRequest()
                {
                    Oznaka = s1.Oznaka,
                    SektorID = s1.SektorID,
                    Status = s1.Status
                };
                Sjedalo s2 = null;
                SjedalaInsertRequest r2 = null;
                if (prosloSjedalo != -1)
                {
                    s2 = await _apiServiceSjedala.GetById<Sjedalo>(prosloSjedalo);
                    s2.Status = false;
                    r2 = new SjedalaInsertRequest();
                    r2.Oznaka = s2.Oznaka;
                    r2.SektorID = s2.SektorID;
                    r2.Status = s2.Status;
                }


              


                if (_id.HasValue)
                {
                    int i = (int)_id;
                    await _apiService.Update<dynamic>(i, req);
                    await _apiServiceSjedala.Update<dynamic>(s1.SjedaloID, r1);
                    if (prosloSjedalo != -1)
                        await _apiServiceSjedala.Update<dynamic>(s2.SjedaloID, r2);
                }
                else
                {
                    await _apiService.Insert<dynamic>(req);
                    await _apiServiceSjedala.Update<dynamic>(s1.SjedaloID, r1);

                }



                //spremanje u preporuke

                //update
                if (proslaUtakmica != -1 || prosliKorisnik!=-1)
                {
                    Utakmica proslaU = await _apiServiceUtakmica.GetById<Utakmica>(proslaUtakmica);
                    List<Preporuka> preporuke = await _apiServicePreporuke.Get<List<Preporuka>>(new PreporukaSearchRequest()
                    {
                        KorisnikID = prosliKorisnik,
                        PrviTimID = proslaU.DomaciTimID,
                        DrugiTimID = proslaU.GostujuciTimID
                    });
                    foreach (var p in preporuke)
                    {
                        p.BrojKupljenihUlaznica--;
                        await _apiServicePreporuke.Update<Preporuka>(p.PreporukaID, new PreporukaInsertRequest()
                        {
                            BrojKupljenihUlaznica = p.BrojKupljenihUlaznica,
                            KorisnikID = p.KorisnikID,
                            TimID = p.TimID
                        });
                    }

                }

                //insert
                Utakmica utakmica = await _apiServiceUtakmica.GetById<Utakmica>(req.UtakmicaID);
                var prviTim = utakmica.DomaciTimID;
                var drugiTim = utakmica.GostujuciTimID;
                List<Preporuka> rezultat = await _apiServicePreporuke.Get<List<Preporuka>>(new PreporukaSearchRequest() { KorisnikID = k.KorisnikID, PrviTimID = prviTim, DrugiTimID = drugiTim });

                if (rezultat.Count == 1)
                {
                    rezultat[0].BrojKupljenihUlaznica++;
                    PreporukaInsertRequest reqP = null;
                    if (rezultat[0].TimID == prviTim)
                    {
                        reqP = new PreporukaInsertRequest
                        {
                            TimID = drugiTim,
                            BrojKupljenihUlaznica = 1,
                            KorisnikID = k.KorisnikID
                        };

                    }
                    else
                    {
                        reqP = new PreporukaInsertRequest
                        {
                            TimID = prviTim,
                            BrojKupljenihUlaznica = 1,
                            KorisnikID = k.KorisnikID
                        };
                    }


                    PreporukaInsertRequest reqPU = new PreporukaInsertRequest
                    {
                        TimID = rezultat[0].TimID,
                        KorisnikID = rezultat[0].KorisnikID,
                        BrojKupljenihUlaznica = rezultat[0].BrojKupljenihUlaznica
                    };
                    await _apiServicePreporuke.Insert<Preporuka>(reqP);
                    await _apiServicePreporuke.Update<Preporuka>(rezultat[0].PreporukaID, reqPU);

                }
                else if (rezultat.Count == 2)
                {
                    PreporukaInsertRequest req1 = new PreporukaInsertRequest
                    {
                        TimID = rezultat[0].TimID,
                        BrojKupljenihUlaznica = ++rezultat[0].BrojKupljenihUlaznica,
                        KorisnikID = rezultat[0].KorisnikID
                    };
                    PreporukaInsertRequest req2 = new PreporukaInsertRequest
                    {
                        TimID = rezultat[1].TimID,
                        BrojKupljenihUlaznica = ++rezultat[1].BrojKupljenihUlaznica,
                        KorisnikID = rezultat[1].KorisnikID
                    };

                    await _apiServicePreporuke.Update<Preporuka>(rezultat[0].PreporukaID, req1);
                    await _apiServicePreporuke.Update<Preporuka>(rezultat[1].PreporukaID, req2);

                }
                else//ako je 0
                {
                    PreporukaInsertRequest req1 = new PreporukaInsertRequest
                    {
                        TimID = prviTim,
                        BrojKupljenihUlaznica = 1,
                        KorisnikID = k.KorisnikID
                    };
                    PreporukaInsertRequest req2 = new PreporukaInsertRequest
                    {
                        TimID = drugiTim,
                        BrojKupljenihUlaznica = 1,
                        KorisnikID = k.KorisnikID
                    };

                    await _apiServicePreporuke.Insert<Preporuka>(req1);
                    await _apiServicePreporuke.Insert<Preporuka>(req2);
                }



                MessageBox.Show("Operacija uspjela");
                this.Close();
            }
            else
            {
                MessageBox.Show("Operacija nije uspjela!");
                this.Close();
            }
        }







        private async void CbUtakmica_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Model.Utakmica utakmica = (Model.Utakmica)cbUtakmica.SelectedItem;
            if (utakmica != null)
            {
                cbSektor.DataSource = null;
                cbSektor.Items.Clear();
                cbSjedala.DataSource = null;
                cbSjedala.Items.Clear();

                var id = utakmica.StadionID;
                List<Model.Sektor> sektori = await _apiServiceSektori.Get<List<Model.Sektor>>(null);
                List<Model.Tribina> tribine = await _apiServiceTribine.Get<List<Model.Tribina>>(null);
                List<Model.Sektor> listaSektora = new List<Model.Sektor>();
                foreach (var tribina in tribine)
                {
                    if (tribina.StadionID == id)
                    {
                        foreach (var sektor in sektori)
                        {
                            if (sektor.TribinaID == tribina.TribinaID)
                            {
                                listaSektora.Add(sektor);
                            }
                        }
                    }

                }

                cbSektor.DataSource = listaSektora;
                cbSektor.DisplayMember = "SektorPodaci";
                cbSektor.ValueMember = "SektorID";
                cbSektor.SelectedItem = null;
                cbSektor.SelectedText = "--Odaberite--";
            }
        }

        private async void CbSektor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Sektor sektor = (Sektor)cbSektor.SelectedItem;

            if (sektor != null)
            {
                cbSjedala.DataSource = null;
                cbSjedala.Items.Clear();
                List<Model.Sjedalo> sjedala = await _apiServiceSjedala.Get<List<Model.Sjedalo>>(null);
                List<Model.Sjedalo> listaSjedala = new List<Model.Sjedalo>();
                foreach (var sjedalo in sjedala)
                {
                    if (sjedalo.SektorID == sektor.SektorID && sjedalo.Status == false)
                        listaSjedala.Add(sjedalo);
                }

                cbSjedala.DataSource = listaSjedala;
                cbSjedala.DisplayMember = "Oznaka";
                cbSjedala.ValueMember = "SjedaloID";
                cbSjedala.SelectedItem = null;
                cbSjedala.SelectedText = "--Odaberite--";

            }
        }
    }
}


