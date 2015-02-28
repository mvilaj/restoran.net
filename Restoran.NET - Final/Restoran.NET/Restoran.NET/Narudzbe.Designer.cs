namespace Restoran.NET
{
    partial class Narudzbe
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
            this.artiklDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDBDataSet = new Restoran.NET.RestoranDBDataSet();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkaRacunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPocniKuhanje = new System.Windows.Forms.Button();
            this.btnzavrsiKuhanje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPocetak = new System.Windows.Forms.TextBox();
            this.txtZavrsetak = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.stavka_racunaTableAdapter = new Restoran.NET.RestoranDBDataSetTableAdapters.Stavka_racunaTableAdapter();
            this.artiklTableAdapter = new Restoran.NET.RestoranDBDataSetTableAdapters.ArtiklTableAdapter();
            this.queriesTableAdapter1 = new Restoran.NET.RestoranDBDataSetTableAdapters.QueriesTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemePripremeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.sifraStavkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pripremljenDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaRacunaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artiklDataGridViewTextBoxColumn,
            this.Column2,
            this.kolicinaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stavkaRacunaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(384, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // artiklDataGridViewTextBoxColumn
            // 
            this.artiklDataGridViewTextBoxColumn.DataPropertyName = "Artikl";
            this.artiklDataGridViewTextBoxColumn.DataSource = this.artiklBindingSource;
            this.artiklDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.artiklDataGridViewTextBoxColumn.HeaderText = "Artikl";
            this.artiklDataGridViewTextBoxColumn.Name = "artiklDataGridViewTextBoxColumn";
            this.artiklDataGridViewTextBoxColumn.ReadOnly = true;
            this.artiklDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.artiklDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.artiklDataGridViewTextBoxColumn.ValueMember = "Sifra artikla";
            this.artiklDataGridViewTextBoxColumn.Width = 181;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataMember = "Artikl";
            this.artiklBindingSource.DataSource = this.restoranDBDataSet;
            // 
            // restoranDBDataSet
            // 
            this.restoranDBDataSet.DataSetName = "RestoranDBDataSet";
            this.restoranDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Artikl";
            this.Column2.DataSource = this.artiklBindingSource;
            this.Column2.DisplayMember = "Vrijeme pripreme";
            this.Column2.HeaderText = "Vrijeme pripreme";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.ValueMember = "Sifra artikla";
            this.Column2.Width = 110;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn.Width = 50;
            // 
            // stavkaRacunaBindingSource
            // 
            this.stavkaRacunaBindingSource.DataMember = "Stavka racuna";
            this.stavkaRacunaBindingSource.DataSource = this.restoranDBDataSet;
            // 
            // btnPocniKuhanje
            // 
            this.btnPocniKuhanje.Location = new System.Drawing.Point(26, 20);
            this.btnPocniKuhanje.Margin = new System.Windows.Forms.Padding(2);
            this.btnPocniKuhanje.Name = "btnPocniKuhanje";
            this.btnPocniKuhanje.Size = new System.Drawing.Size(94, 67);
            this.btnPocniKuhanje.TabIndex = 1;
            this.btnPocniKuhanje.Text = "Započni kuhanje";
            this.btnPocniKuhanje.UseVisualStyleBackColor = true;
            this.btnPocniKuhanje.Click += new System.EventHandler(this.btnPocniKuhanje_Click);
            // 
            // btnzavrsiKuhanje
            // 
            this.btnzavrsiKuhanje.Enabled = false;
            this.btnzavrsiKuhanje.Location = new System.Drawing.Point(158, 20);
            this.btnzavrsiKuhanje.Margin = new System.Windows.Forms.Padding(2);
            this.btnzavrsiKuhanje.Name = "btnzavrsiKuhanje";
            this.btnzavrsiKuhanje.Size = new System.Drawing.Size(97, 67);
            this.btnzavrsiKuhanje.TabIndex = 2;
            this.btnzavrsiKuhanje.Text = "Završi kuhanje";
            this.btnzavrsiKuhanje.UseVisualStyleBackColor = true;
            this.btnzavrsiKuhanje.Click += new System.EventHandler(this.btnzavrsiKuhanje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vrijeme početka kuhanja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vrijeme završetka kuhanja";
            // 
            // txtPocetak
            // 
            this.txtPocetak.Enabled = false;
            this.txtPocetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPocetak.Location = new System.Drawing.Point(17, 136);
            this.txtPocetak.Margin = new System.Windows.Forms.Padding(2);
            this.txtPocetak.Multiline = true;
            this.txtPocetak.Name = "txtPocetak";
            this.txtPocetak.Size = new System.Drawing.Size(121, 32);
            this.txtPocetak.TabIndex = 5;
            this.txtPocetak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtZavrsetak
            // 
            this.txtZavrsetak.Enabled = false;
            this.txtZavrsetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZavrsetak.Location = new System.Drawing.Point(158, 136);
            this.txtZavrsetak.Margin = new System.Windows.Forms.Padding(2);
            this.txtZavrsetak.Multiline = true;
            this.txtZavrsetak.Name = "txtZavrsetak";
            this.txtZavrsetak.Size = new System.Drawing.Size(121, 32);
            this.txtZavrsetak.TabIndex = 6;
            this.txtZavrsetak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ukupno vrijeme kuhanja";
            // 
            // txtUkupno
            // 
            this.txtUkupno.Enabled = false;
            this.txtUkupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUkupno.Location = new System.Drawing.Point(44, 207);
            this.txtUkupno.Margin = new System.Windows.Forms.Padding(2);
            this.txtUkupno.Multiline = true;
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.Size = new System.Drawing.Size(212, 37);
            this.txtUkupno.TabIndex = 8;
            this.txtUkupno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stavka_racunaTableAdapter
            // 
            this.stavka_racunaTableAdapter.ClearBeforeFill = true;
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Prijašnja vremena kuhanja jela";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnzavrsiKuhanje);
            this.groupBox1.Controls.Add(this.btnPocniKuhanje);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtZavrsetak);
            this.groupBox1.Controls.Add(this.txtUkupno);
            this.groupBox1.Controls.Add(this.txtPocetak);
            this.groupBox1.Location = new System.Drawing.Point(431, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(302, 257);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Za kuhanje";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivDataGridViewTextBoxColumn,
            this.vrijemePripremeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.artiklBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(9, 327);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(373, 225);
            this.dataGridView2.TabIndex = 11;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn.Width = 200;
            // 
            // vrijemePripremeDataGridViewTextBoxColumn
            // 
            this.vrijemePripremeDataGridViewTextBoxColumn.DataPropertyName = "Vrijeme pripreme";
            this.vrijemePripremeDataGridViewTextBoxColumn.HeaderText = "Vrijeme pripreme (u minutama)";
            this.vrijemePripremeDataGridViewTextBoxColumn.Name = "vrijemePripremeDataGridViewTextBoxColumn";
            this.vrijemePripremeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrijemePripremeDataGridViewTextBoxColumn.Width = 130;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraStavkeDataGridViewTextBoxColumn,
            this.racunDataGridViewTextBoxColumn,
            this.artiklDataGridViewTextBoxColumn1,
            this.kolicinaDataGridViewTextBoxColumn1,
            this.pripremljenDataGridViewCheckBoxColumn});
            this.dataGridView3.DataSource = this.stavkaRacunaBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(412, 327);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(338, 225);
            this.dataGridView3.TabIndex = 12;
            this.dataGridView3.Visible = false;
            // 
            // sifraStavkeDataGridViewTextBoxColumn
            // 
            this.sifraStavkeDataGridViewTextBoxColumn.DataPropertyName = "Sifra stavke";
            this.sifraStavkeDataGridViewTextBoxColumn.HeaderText = "Sifra stavke";
            this.sifraStavkeDataGridViewTextBoxColumn.Name = "sifraStavkeDataGridViewTextBoxColumn";
            this.sifraStavkeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // racunDataGridViewTextBoxColumn
            // 
            this.racunDataGridViewTextBoxColumn.DataPropertyName = "Racun";
            this.racunDataGridViewTextBoxColumn.HeaderText = "Racun";
            this.racunDataGridViewTextBoxColumn.Name = "racunDataGridViewTextBoxColumn";
            // 
            // artiklDataGridViewTextBoxColumn1
            // 
            this.artiklDataGridViewTextBoxColumn1.DataPropertyName = "Artikl";
            this.artiklDataGridViewTextBoxColumn1.HeaderText = "Artikl";
            this.artiklDataGridViewTextBoxColumn1.Name = "artiklDataGridViewTextBoxColumn1";
            // 
            // kolicinaDataGridViewTextBoxColumn1
            // 
            this.kolicinaDataGridViewTextBoxColumn1.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn1.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn1.Name = "kolicinaDataGridViewTextBoxColumn1";
            // 
            // pripremljenDataGridViewCheckBoxColumn
            // 
            this.pripremljenDataGridViewCheckBoxColumn.DataPropertyName = "Pripremljen";
            this.pripremljenDataGridViewCheckBoxColumn.HeaderText = "Pripremljen";
            this.pripremljenDataGridViewCheckBoxColumn.Name = "pripremljenDataGridViewCheckBoxColumn";
            // 
            // Narudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 570);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Narudzbe";
            this.Text = "Narudzbe";
            this.Load += new System.EventHandler(this.Narudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaRacunaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RestoranDBDataSet restoranDBDataSet;
        private System.Windows.Forms.BindingSource stavkaRacunaBindingSource;
        private RestoranDBDataSetTableAdapters.Stavka_racunaTableAdapter stavka_racunaTableAdapter;
        private System.Windows.Forms.Button btnPocniKuhanje;
        private System.Windows.Forms.Button btnzavrsiKuhanje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPocetak;
        private System.Windows.Forms.TextBox txtZavrsetak;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUkupno;
        private RestoranDBDataSetTableAdapters.ArtiklTableAdapter artiklTableAdapter;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private RestoranDBDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemePripremeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraStavkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artiklDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pripremljenDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn artiklDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
    }
}