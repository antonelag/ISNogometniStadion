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
            frmKorisnici frm = new frmKorisnici();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();

        }

        private void NoviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmKorisniciDetalji();
            frm.Show();
        }

        private void PretraziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrzave frm = new frmDrzave();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void NovaDržavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrzaveDetalji frm = new frmDrzaveDetalji();
            frm.Show();
        }

        private void PretražiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmGradovi();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void NoviGradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmGradoviDetalji();
            frm.Show();
        }

        private void PretražiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frmSjedala();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void NovoSjedaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmSjedalaDetalji();
            frm.Show();
        }

        private void PretražiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var frm = new frmStadioni();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void NoviStadionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmStadionDetalji();
            frm.Show();
        }

        private void PretraćiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmTimovi();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void NoviTimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmTimoviDetalji();
            frm.Show();
        }

        private void PretražiToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var frm = new frmTribine();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void NovaTribinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmTribineDetalji();
            frm.Show();
        }

        private void PretražiToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var frm = new frmUlaznice();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();

        }

        private void NovaUlaznicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmUlazniceDetalji();
            frm.Show();
        }

        private void PretražiToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var frm = new frmUtakmice();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void NovaUtakmicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmUtakmiceDetalji();
            frm.Show();
        }

        private void NovaLigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmLige();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void NovaLigaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frmLigeDetalji();
            frm.Show();
        }

        private void PretražiToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var frm = new frmSektori();
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
            var frm = new frmGodineIStadioniIzvjesce();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void PretražiToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            var frm = new frmUplate();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

       
    }
}
