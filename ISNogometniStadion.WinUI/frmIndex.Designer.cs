namespace ISNogometniStadion.WinUI
{
    partial class frmIndex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drzaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaDržavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretražiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviGradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sjedalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretražiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoSjedaloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stadioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretražiToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.noviStadionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraćiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviTimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tribineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretražiToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.novaTribinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ulazniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretražiToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.novaUlaznicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utakmiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretražiToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.novaUtakmicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.drzaveToolStripMenuItem,
            this.gradoviToolStripMenuItem,
            this.sjedalaToolStripMenuItem,
            this.stadioniToolStripMenuItem,
            this.timoviToolStripMenuItem,
            this.tribineToolStripMenuItem,
            this.ulazniceToolStripMenuItem,
            this.utakmiceToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.noviKorisnikToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.PretragaToolStripMenuItem_Click);
            // 
            // noviKorisnikToolStripMenuItem
            // 
            this.noviKorisnikToolStripMenuItem.Name = "noviKorisnikToolStripMenuItem";
            this.noviKorisnikToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.noviKorisnikToolStripMenuItem.Text = "Novi korisnik";
            this.noviKorisnikToolStripMenuItem.Click += new System.EventHandler(this.NoviKorisnikToolStripMenuItem_Click);
            // 
            // drzaveToolStripMenuItem
            // 
            this.drzaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretraziToolStripMenuItem,
            this.novaDržavaToolStripMenuItem});
            this.drzaveToolStripMenuItem.Name = "drzaveToolStripMenuItem";
            this.drzaveToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.drzaveToolStripMenuItem.Text = "Drzave";
            // 
            // pretraziToolStripMenuItem
            // 
            this.pretraziToolStripMenuItem.Name = "pretraziToolStripMenuItem";
            this.pretraziToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.pretraziToolStripMenuItem.Text = "Pretraži";
            this.pretraziToolStripMenuItem.Click += new System.EventHandler(this.PretraziToolStripMenuItem_Click);
            // 
            // novaDržavaToolStripMenuItem
            // 
            this.novaDržavaToolStripMenuItem.Name = "novaDržavaToolStripMenuItem";
            this.novaDržavaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.novaDržavaToolStripMenuItem.Text = "Nova država";
            this.novaDržavaToolStripMenuItem.Click += new System.EventHandler(this.NovaDržavaToolStripMenuItem_Click);
            // 
            // gradoviToolStripMenuItem
            // 
            this.gradoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretražiToolStripMenuItem,
            this.noviGradToolStripMenuItem});
            this.gradoviToolStripMenuItem.Name = "gradoviToolStripMenuItem";
            this.gradoviToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.gradoviToolStripMenuItem.Text = "Gradovi";
            // 
            // pretražiToolStripMenuItem
            // 
            this.pretražiToolStripMenuItem.Name = "pretražiToolStripMenuItem";
            this.pretražiToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.pretražiToolStripMenuItem.Text = "Pretraži";
            this.pretražiToolStripMenuItem.Click += new System.EventHandler(this.PretražiToolStripMenuItem_Click);
            // 
            // noviGradToolStripMenuItem
            // 
            this.noviGradToolStripMenuItem.Name = "noviGradToolStripMenuItem";
            this.noviGradToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.noviGradToolStripMenuItem.Text = "Novi grad";
            this.noviGradToolStripMenuItem.Click += new System.EventHandler(this.NoviGradToolStripMenuItem_Click);
            // 
            // sjedalaToolStripMenuItem
            // 
            this.sjedalaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretražiToolStripMenuItem1,
            this.novoSjedaloToolStripMenuItem});
            this.sjedalaToolStripMenuItem.Name = "sjedalaToolStripMenuItem";
            this.sjedalaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.sjedalaToolStripMenuItem.Text = "Sjedala";
            // 
            // pretražiToolStripMenuItem1
            // 
            this.pretražiToolStripMenuItem1.Name = "pretražiToolStripMenuItem1";
            this.pretražiToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.pretražiToolStripMenuItem1.Text = "Pretraži";
            this.pretražiToolStripMenuItem1.Click += new System.EventHandler(this.PretražiToolStripMenuItem1_Click);
            // 
            // novoSjedaloToolStripMenuItem
            // 
            this.novoSjedaloToolStripMenuItem.Name = "novoSjedaloToolStripMenuItem";
            this.novoSjedaloToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.novoSjedaloToolStripMenuItem.Text = "Novo sjedalo";
            this.novoSjedaloToolStripMenuItem.Click += new System.EventHandler(this.NovoSjedaloToolStripMenuItem_Click);
            // 
            // stadioniToolStripMenuItem
            // 
            this.stadioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretražiToolStripMenuItem2,
            this.noviStadionToolStripMenuItem});
            this.stadioniToolStripMenuItem.Name = "stadioniToolStripMenuItem";
            this.stadioniToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.stadioniToolStripMenuItem.Text = "Stadioni";
            // 
            // pretražiToolStripMenuItem2
            // 
            this.pretražiToolStripMenuItem2.Name = "pretražiToolStripMenuItem2";
            this.pretražiToolStripMenuItem2.Size = new System.Drawing.Size(141, 22);
            this.pretražiToolStripMenuItem2.Text = "Pretraži";
            this.pretražiToolStripMenuItem2.Click += new System.EventHandler(this.PretražiToolStripMenuItem2_Click);
            // 
            // noviStadionToolStripMenuItem
            // 
            this.noviStadionToolStripMenuItem.Name = "noviStadionToolStripMenuItem";
            this.noviStadionToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.noviStadionToolStripMenuItem.Text = "Novi stadion";
            this.noviStadionToolStripMenuItem.Click += new System.EventHandler(this.NoviStadionToolStripMenuItem_Click);
            // 
            // timoviToolStripMenuItem
            // 
            this.timoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretraćiToolStripMenuItem,
            this.noviTimToolStripMenuItem});
            this.timoviToolStripMenuItem.Name = "timoviToolStripMenuItem";
            this.timoviToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.timoviToolStripMenuItem.Text = "Timovi";
            // 
            // pretraćiToolStripMenuItem
            // 
            this.pretraćiToolStripMenuItem.Name = "pretraćiToolStripMenuItem";
            this.pretraćiToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.pretraćiToolStripMenuItem.Text = "Pretraži";
            this.pretraćiToolStripMenuItem.Click += new System.EventHandler(this.PretraćiToolStripMenuItem_Click);
            // 
            // noviTimToolStripMenuItem
            // 
            this.noviTimToolStripMenuItem.Name = "noviTimToolStripMenuItem";
            this.noviTimToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.noviTimToolStripMenuItem.Text = "Novi tim";
            this.noviTimToolStripMenuItem.Click += new System.EventHandler(this.NoviTimToolStripMenuItem_Click);
            // 
            // tribineToolStripMenuItem
            // 
            this.tribineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretražiToolStripMenuItem3,
            this.novaTribinaToolStripMenuItem});
            this.tribineToolStripMenuItem.Name = "tribineToolStripMenuItem";
            this.tribineToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.tribineToolStripMenuItem.Text = "Tribine";
            // 
            // pretražiToolStripMenuItem3
            // 
            this.pretražiToolStripMenuItem3.Name = "pretražiToolStripMenuItem3";
            this.pretražiToolStripMenuItem3.Size = new System.Drawing.Size(139, 22);
            this.pretražiToolStripMenuItem3.Text = "Pretraži";
            this.pretražiToolStripMenuItem3.Click += new System.EventHandler(this.PretražiToolStripMenuItem3_Click);
            // 
            // novaTribinaToolStripMenuItem
            // 
            this.novaTribinaToolStripMenuItem.Name = "novaTribinaToolStripMenuItem";
            this.novaTribinaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.novaTribinaToolStripMenuItem.Text = "Nova tribina";
            this.novaTribinaToolStripMenuItem.Click += new System.EventHandler(this.NovaTribinaToolStripMenuItem_Click);
            // 
            // ulazniceToolStripMenuItem
            // 
            this.ulazniceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretražiToolStripMenuItem4,
            this.novaUlaznicaToolStripMenuItem});
            this.ulazniceToolStripMenuItem.Name = "ulazniceToolStripMenuItem";
            this.ulazniceToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ulazniceToolStripMenuItem.Text = "Ulaznice";
            // 
            // pretražiToolStripMenuItem4
            // 
            this.pretražiToolStripMenuItem4.Name = "pretražiToolStripMenuItem4";
            this.pretražiToolStripMenuItem4.Size = new System.Drawing.Size(148, 22);
            this.pretražiToolStripMenuItem4.Text = "Pretraži";
            this.pretražiToolStripMenuItem4.Click += new System.EventHandler(this.PretražiToolStripMenuItem4_Click);
            // 
            // novaUlaznicaToolStripMenuItem
            // 
            this.novaUlaznicaToolStripMenuItem.Name = "novaUlaznicaToolStripMenuItem";
            this.novaUlaznicaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.novaUlaznicaToolStripMenuItem.Text = "Nova ulaznica";
            this.novaUlaznicaToolStripMenuItem.Click += new System.EventHandler(this.NovaUlaznicaToolStripMenuItem_Click);
            // 
            // utakmiceToolStripMenuItem
            // 
            this.utakmiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretražiToolStripMenuItem5,
            this.novaUtakmicaToolStripMenuItem});
            this.utakmiceToolStripMenuItem.Name = "utakmiceToolStripMenuItem";
            this.utakmiceToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.utakmiceToolStripMenuItem.Text = "Utakmice";
            // 
            // pretražiToolStripMenuItem5
            // 
            this.pretražiToolStripMenuItem5.Name = "pretražiToolStripMenuItem5";
            this.pretražiToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.pretražiToolStripMenuItem5.Text = "Pretraži";
            this.pretražiToolStripMenuItem5.Click += new System.EventHandler(this.PretražiToolStripMenuItem5_Click);
            // 
            // novaUtakmicaToolStripMenuItem
            // 
            this.novaUtakmicaToolStripMenuItem.Name = "novaUtakmicaToolStripMenuItem";
            this.novaUtakmicaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novaUtakmicaToolStripMenuItem.Text = "Nova utakmica";
            this.novaUtakmicaToolStripMenuItem.Click += new System.EventHandler(this.NovaUtakmicaToolStripMenuItem_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmIndex";
            this.Text = "frmIndex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKorisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drzaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretraziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaDržavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretražiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviGradToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sjedalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretražiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novoSjedaloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stadioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretražiToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem noviStadionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretraćiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviTimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tribineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretražiToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem novaTribinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ulazniceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretražiToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem novaUlaznicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utakmiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretražiToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem novaUtakmicaToolStripMenuItem;
    }
}



