namespace Restoran.NET
{
    partial class PregledRacuna
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDBDataSet = new Restoran.NET.RestoranDBDataSet();
            this.datumIVrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.artiklDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkaRacunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajGlavno = new System.Windows.Forms.Button();
            this.btnObrisiGlavniDio = new System.Windows.Forms.Button();
            this.btnDodajStavke = new System.Windows.Forms.Button();
            this.btnObrisiStavke = new System.Windows.Forms.Button();
            this.btnIzmijeniPodatke = new System.Windows.Forms.Button();
            this.racunTableAdapter = new Restoran.NET.RestoranDBDataSetTableAdapters.RacunTableAdapter();
            this.stavka_racunaTableAdapter = new Restoran.NET.RestoranDBDataSetTableAdapters.Stavka_racunaTableAdapter();
            this.zaposlenikTableAdapter = new Restoran.NET.RestoranDBDataSetTableAdapters.ZaposlenikTableAdapter();
            this.artiklTableAdapter = new Restoran.NET.RestoranDBDataSetTableAdapters.ArtiklTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaRacunaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.zaposlenikDataGridViewTextBoxColumn,
            this.datumIVrijemeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.racunBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(370, 324);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Sifra racuna";
            this.dataGridViewTextBoxColumn1.HeaderText = "Šifra racuna";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // zaposlenikDataGridViewTextBoxColumn
            // 
            this.zaposlenikDataGridViewTextBoxColumn.DataPropertyName = "Zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.DataSource = this.zaposlenikBindingSource;
            this.zaposlenikDataGridViewTextBoxColumn.DisplayMember = "Ime i prezime";
            this.zaposlenikDataGridViewTextBoxColumn.HeaderText = "Zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.Name = "zaposlenikDataGridViewTextBoxColumn";
            this.zaposlenikDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.zaposlenikDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.zaposlenikDataGridViewTextBoxColumn.ValueMember = "Sifra zaposlenika";
            this.zaposlenikDataGridViewTextBoxColumn.Width = 120;
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataMember = "Zaposlenik";
            this.zaposlenikBindingSource.DataSource = this.restoranDBDataSet;
            // 
            // restoranDBDataSet
            // 
            this.restoranDBDataSet.DataSetName = "RestoranDBDataSet";
            this.restoranDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datumIVrijemeDataGridViewTextBoxColumn
            // 
            this.datumIVrijemeDataGridViewTextBoxColumn.DataPropertyName = "Datum i vrijeme";
            this.datumIVrijemeDataGridViewTextBoxColumn.HeaderText = "Datum i vrijeme";
            this.datumIVrijemeDataGridViewTextBoxColumn.Name = "datumIVrijemeDataGridViewTextBoxColumn";
            this.datumIVrijemeDataGridViewTextBoxColumn.Width = 180;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "Racun";
            this.racunBindingSource.DataSource = this.restoranDBDataSet;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artiklDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.stavkaRacunaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(393, 43);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(373, 324);
            this.dataGridView2.TabIndex = 1;
            // 
            // artiklDataGridViewTextBoxColumn
            // 
            this.artiklDataGridViewTextBoxColumn.DataPropertyName = "Artikl";
            this.artiklDataGridViewTextBoxColumn.DataSource = this.artiklBindingSource;
            this.artiklDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.artiklDataGridViewTextBoxColumn.FillWeight = 200F;
            this.artiklDataGridViewTextBoxColumn.HeaderText = "Artikl";
            this.artiklDataGridViewTextBoxColumn.Name = "artiklDataGridViewTextBoxColumn";
            this.artiklDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.artiklDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.artiklDataGridViewTextBoxColumn.ValueMember = "Sifra artikla";
            this.artiklDataGridViewTextBoxColumn.Width = 180;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataMember = "Artikl";
            this.artiklBindingSource.DataSource = this.restoranDBDataSet;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.Width = 60;
            // 
            // stavkaRacunaBindingSource
            // 
            this.stavkaRacunaBindingSource.DataMember = "Stavka racuna";
            this.stavkaRacunaBindingSource.DataSource = this.restoranDBDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Glavni dio računa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stavke računa";
            // 
            // btnDodajGlavno
            // 
            this.btnDodajGlavno.Location = new System.Drawing.Point(73, 380);
            this.btnDodajGlavno.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajGlavno.Name = "btnDodajGlavno";
            this.btnDodajGlavno.Size = new System.Drawing.Size(92, 31);
            this.btnDodajGlavno.TabIndex = 4;
            this.btnDodajGlavno.Text = "Dodaj glavni dio";
            this.btnDodajGlavno.UseVisualStyleBackColor = true;
            this.btnDodajGlavno.Click += new System.EventHandler(this.btnDodajGlavno_Click);
            // 
            // btnObrisiGlavniDio
            // 
            this.btnObrisiGlavniDio.Location = new System.Drawing.Point(179, 380);
            this.btnObrisiGlavniDio.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisiGlavniDio.Name = "btnObrisiGlavniDio";
            this.btnObrisiGlavniDio.Size = new System.Drawing.Size(98, 31);
            this.btnObrisiGlavniDio.TabIndex = 5;
            this.btnObrisiGlavniDio.Text = "Obriši glavni dio";
            this.btnObrisiGlavniDio.UseVisualStyleBackColor = true;
            this.btnObrisiGlavniDio.Click += new System.EventHandler(this.btnObrisiGlavniDio_Click);
            // 
            // btnDodajStavke
            // 
            this.btnDodajStavke.Location = new System.Drawing.Point(494, 380);
            this.btnDodajStavke.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajStavke.Name = "btnDodajStavke";
            this.btnDodajStavke.Size = new System.Drawing.Size(78, 31);
            this.btnDodajStavke.TabIndex = 6;
            this.btnDodajStavke.Text = "Dodaj stavke";
            this.btnDodajStavke.UseVisualStyleBackColor = true;
            this.btnDodajStavke.Click += new System.EventHandler(this.btnDodajStavke_Click);
            // 
            // btnObrisiStavke
            // 
            this.btnObrisiStavke.Location = new System.Drawing.Point(591, 380);
            this.btnObrisiStavke.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisiStavke.Name = "btnObrisiStavke";
            this.btnObrisiStavke.Size = new System.Drawing.Size(87, 31);
            this.btnObrisiStavke.TabIndex = 7;
            this.btnObrisiStavke.Text = "Obriši stavke";
            this.btnObrisiStavke.UseVisualStyleBackColor = true;
            this.btnObrisiStavke.Click += new System.EventHandler(this.btnObrisiStavke_Click);
            // 
            // btnIzmijeniPodatke
            // 
            this.btnIzmijeniPodatke.Location = new System.Drawing.Point(335, 415);
            this.btnIzmijeniPodatke.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzmijeniPodatke.Name = "btnIzmijeniPodatke";
            this.btnIzmijeniPodatke.Size = new System.Drawing.Size(97, 30);
            this.btnIzmijeniPodatke.TabIndex = 8;
            this.btnIzmijeniPodatke.Text = "Izmijeni podatke";
            this.btnIzmijeniPodatke.UseVisualStyleBackColor = true;
            this.btnIzmijeniPodatke.Click += new System.EventHandler(this.btnIzmijeniPodatke_Click);
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
            // 
            // stavka_racunaTableAdapter
            // 
            this.stavka_racunaTableAdapter.ClearBeforeFill = true;
            // 
            // zaposlenikTableAdapter
            // 
            this.zaposlenikTableAdapter.ClearBeforeFill = true;
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(43, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // PregledRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 460);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIzmijeniPodatke);
            this.Controls.Add(this.btnObrisiStavke);
            this.Controls.Add(this.btnDodajStavke);
            this.Controls.Add(this.btnObrisiGlavniDio);
            this.Controls.Add(this.btnDodajGlavno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PregledRacuna";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pregled računa";
            this.Load += new System.EventHandler(this.PregledRacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaRacunaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RestoranDBDataSet restoranDBDataSet;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private RestoranDBDataSetTableAdapters.RacunTableAdapter racunTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource stavkaRacunaBindingSource;
        private RestoranDBDataSetTableAdapters.Stavka_racunaTableAdapter stavka_racunaTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajGlavno;
        private System.Windows.Forms.Button btnObrisiGlavniDio;
        private System.Windows.Forms.Button btnDodajStavke;
        private System.Windows.Forms.Button btnObrisiStavke;
        private System.Windows.Forms.Button btnIzmijeniPodatke;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private RestoranDBDataSetTableAdapters.ZaposlenikTableAdapter zaposlenikTableAdapter;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private RestoranDBDataSetTableAdapters.ArtiklTableAdapter artiklTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn zaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumIVrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn artiklDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
    }
}