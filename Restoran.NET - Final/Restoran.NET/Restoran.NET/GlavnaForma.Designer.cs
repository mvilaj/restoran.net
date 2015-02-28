namespace Restoran.NET
{
    partial class GlavnaForma
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artikliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajArtiklToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledArtikalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajJedinicuMjereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledJedinicaMjereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeRacunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajGlavniDioRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajStavkeRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajZaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledZaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narudžbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.artikliToolStripMenuItem,
            this.kreiranjeRacunaToolStripMenuItem,
            this.zaposleniciToolStripMenuItem,
            this.narudžbeToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // artikliToolStripMenuItem
            // 
            this.artikliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajArtiklToolStripMenuItem,
            this.pregledArtikalaToolStripMenuItem,
            this.dodajJedinicuMjereToolStripMenuItem,
            this.pregledJedinicaMjereToolStripMenuItem});
            this.artikliToolStripMenuItem.Name = "artikliToolStripMenuItem";
            this.artikliToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.artikliToolStripMenuItem.Text = "Artikli";
            this.artikliToolStripMenuItem.Visible = false;
            // 
            // dodajArtiklToolStripMenuItem
            // 
            this.dodajArtiklToolStripMenuItem.Name = "dodajArtiklToolStripMenuItem";
            this.dodajArtiklToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.dodajArtiklToolStripMenuItem.Text = "Dodaj artikl";
            this.dodajArtiklToolStripMenuItem.Click += new System.EventHandler(this.dodajArtiklToolStripMenuItem_Click);
            // 
            // pregledArtikalaToolStripMenuItem
            // 
            this.pregledArtikalaToolStripMenuItem.Name = "pregledArtikalaToolStripMenuItem";
            this.pregledArtikalaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.pregledArtikalaToolStripMenuItem.Text = "Pregled artikala";
            this.pregledArtikalaToolStripMenuItem.Click += new System.EventHandler(this.pregledArtikalaToolStripMenuItem_Click);
            // 
            // dodajJedinicuMjereToolStripMenuItem
            // 
            this.dodajJedinicuMjereToolStripMenuItem.Name = "dodajJedinicuMjereToolStripMenuItem";
            this.dodajJedinicuMjereToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.dodajJedinicuMjereToolStripMenuItem.Text = "Dodaj jedinicu mjere";
            this.dodajJedinicuMjereToolStripMenuItem.Click += new System.EventHandler(this.dodajJedinicuMjereToolStripMenuItem_Click);
            // 
            // pregledJedinicaMjereToolStripMenuItem
            // 
            this.pregledJedinicaMjereToolStripMenuItem.Name = "pregledJedinicaMjereToolStripMenuItem";
            this.pregledJedinicaMjereToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.pregledJedinicaMjereToolStripMenuItem.Text = "Pregled jedinica mjere";
            this.pregledJedinicaMjereToolStripMenuItem.Click += new System.EventHandler(this.pregledJedinicaMjereToolStripMenuItem_Click);
            // 
            // kreiranjeRacunaToolStripMenuItem
            // 
            this.kreiranjeRacunaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreiranjeRačunaToolStripMenuItem,
            this.pregledRačunaToolStripMenuItem});
            this.kreiranjeRacunaToolStripMenuItem.Name = "kreiranjeRacunaToolStripMenuItem";
            this.kreiranjeRacunaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.kreiranjeRacunaToolStripMenuItem.Text = "Računi";
            this.kreiranjeRacunaToolStripMenuItem.Visible = false;
            // 
            // kreiranjeRačunaToolStripMenuItem
            // 
            this.kreiranjeRačunaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajGlavniDioRačunaToolStripMenuItem,
            this.dodajStavkeRačunaToolStripMenuItem});
            this.kreiranjeRačunaToolStripMenuItem.Name = "kreiranjeRačunaToolStripMenuItem";
            this.kreiranjeRačunaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.kreiranjeRačunaToolStripMenuItem.Text = "Kreiranje računa";
            // 
            // dodajGlavniDioRačunaToolStripMenuItem
            // 
            this.dodajGlavniDioRačunaToolStripMenuItem.Name = "dodajGlavniDioRačunaToolStripMenuItem";
            this.dodajGlavniDioRačunaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.dodajGlavniDioRačunaToolStripMenuItem.Text = "Dodaj glavni dio računa";
            this.dodajGlavniDioRačunaToolStripMenuItem.Click += new System.EventHandler(this.dodajGlavniDioRačunaToolStripMenuItem_Click);
            // 
            // dodajStavkeRačunaToolStripMenuItem
            // 
            this.dodajStavkeRačunaToolStripMenuItem.Name = "dodajStavkeRačunaToolStripMenuItem";
            this.dodajStavkeRačunaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.dodajStavkeRačunaToolStripMenuItem.Text = "Dodaj stavke računa";
            this.dodajStavkeRačunaToolStripMenuItem.Click += new System.EventHandler(this.dodajStavkeRačunaToolStripMenuItem_Click);
            // 
            // pregledRačunaToolStripMenuItem
            // 
            this.pregledRačunaToolStripMenuItem.Name = "pregledRačunaToolStripMenuItem";
            this.pregledRačunaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.pregledRačunaToolStripMenuItem.Text = "Pregled računa";
            this.pregledRačunaToolStripMenuItem.Click += new System.EventHandler(this.pregledRačunaToolStripMenuItem_Click);
            // 
            // zaposleniciToolStripMenuItem
            // 
            this.zaposleniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajZaposlenikaToolStripMenuItem,
            this.pregledZaposlenikaToolStripMenuItem});
            this.zaposleniciToolStripMenuItem.Name = "zaposleniciToolStripMenuItem";
            this.zaposleniciToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.zaposleniciToolStripMenuItem.Text = "Zaposlenici";
            this.zaposleniciToolStripMenuItem.Visible = false;
            // 
            // dodajZaposlenikaToolStripMenuItem
            // 
            this.dodajZaposlenikaToolStripMenuItem.Name = "dodajZaposlenikaToolStripMenuItem";
            this.dodajZaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.dodajZaposlenikaToolStripMenuItem.Text = "Dodaj zaposlenika";
            this.dodajZaposlenikaToolStripMenuItem.Click += new System.EventHandler(this.dodajZaposlenikaToolStripMenuItem_Click);
            // 
            // pregledZaposlenikaToolStripMenuItem
            // 
            this.pregledZaposlenikaToolStripMenuItem.Name = "pregledZaposlenikaToolStripMenuItem";
            this.pregledZaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.pregledZaposlenikaToolStripMenuItem.Text = "Pregled zaposlenika";
            this.pregledZaposlenikaToolStripMenuItem.Click += new System.EventHandler(this.pregledZaposlenikaToolStripMenuItem_Click);
            // 
            // narudžbeToolStripMenuItem
            // 
            this.narudžbeToolStripMenuItem.Name = "narudžbeToolStripMenuItem";
            this.narudžbeToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.narudžbeToolStripMenuItem.Text = "Narudžbe";
            this.narudžbeToolStripMenuItem.Visible = false;
            this.narudžbeToolStripMenuItem.Click += new System.EventHandler(this.narudžbeToolStripMenuItem_Click);
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Visible = false;
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restoran.NET.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(640, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 72);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // GlavnaForma
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 389);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GlavnaForma";
            this.ShowIcon = false;
            this.Text = "Restoran.NET";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajArtiklToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledArtikalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeRačunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajGlavniDioRačunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajStavkeRačunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledRačunaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem artikliToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kreiranjeRacunaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem narudžbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajZaposlenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledZaposlenikaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem zaposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajJedinicuMjereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledJedinicaMjereToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

