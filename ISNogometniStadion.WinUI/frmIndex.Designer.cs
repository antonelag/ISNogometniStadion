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
            this.stadioniToolStripMenuItem});
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
            this.pretražiToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.pretražiToolStripMenuItem2.Text = "Pretraži";
            this.pretražiToolStripMenuItem2.Click += new System.EventHandler(this.PretražiToolStripMenuItem2_Click);
            // 
            // noviStadionToolStripMenuItem
            // 
            this.noviStadionToolStripMenuItem.Name = "noviStadionToolStripMenuItem";
            this.noviStadionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noviStadionToolStripMenuItem.Text = "Novi stadion";
            this.noviStadionToolStripMenuItem.Click += new System.EventHandler(this.NoviStadionToolStripMenuItem_Click);
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
    }
}



