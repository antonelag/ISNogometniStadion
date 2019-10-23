using ISNogometniStadion.WinUI.Drzave;
using ISNogometniStadion.WinUI.Gradovi;
using ISNogometniStadion.WinUI.Izvješća;
using ISNogometniStadion.WinUI.Korisnici;
using ISNogometniStadion.WinUI.Lige;
using ISNogometniStadion.WinUI.Sektori;
using ISNogometniStadion.WinUI.Sjedala;
using ISNogometniStadion.WinUI.Stadioni;
using ISNogometniStadion.WinUI.Timovi;
using ISNogometniStadion.WinUI.Tribine;
using ISNogometniStadion.WinUI.Ulaznice;
using ISNogometniStadion.WinUI.Uplate;
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

namespace ISNogometniStadion.WinUI
{
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;

        public frmIndex()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void PretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKorisnici frm = new FrmKorisnici();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();

        }

        private void NoviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmKorisniciDetalji();
            frm.Show();
        }

        private void PretraziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDrzave frm = new FrmDrzave();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void NovaDržavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDrzaveDetalji frm = new FrmDrzaveDetalji();
            frm.Show();
        }

        private void PretražiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmGradovi();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void NoviGradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmGradoviDetalji();
            frm.Show();
        }

        private void PretražiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new FrmSjedala();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void NovoSjedaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmSjedalaDetalji();
            frm.Show();
        }

        private void PretražiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var frm = new FrmStadioni();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void NoviStadionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmStadionDetalji();
            frm.Show();
        }

        private void PretraćiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmTimovi();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void NoviTimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmTimoviDetalji();
            frm.Show();
        }

        private void PretražiToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var frm = new FrmTribine();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void NovaTribinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmTribineDetalji();
            frm.Show();
        }

        private void PretražiToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var frm = new FrmUlaznice();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();

        }

        private void NovaUlaznicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmUlazniceDetalji();
            frm.Show();
        }

        private void PretražiToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var frm = new FrmUtakmice();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void NovaUtakmicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmUtakmiceDetalji();
            frm.Show();
        }

        private void NovaLigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmLige();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void NovaLigaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new FrmLigeDetalji();
            frm.Show();
        }

        private void PretražiToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var frm = new FrmSektori();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void NoviSektorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var frm = new frmSektoriDetalji();
            frm.Show();
        }

        private void GodineIStadioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmGodineIStadioniIzvjesce();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void PretražiToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            var frm = new FrmUplate();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }


    }
}
