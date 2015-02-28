namespace Restoran.NET
{
    partial class frmDodavanjeArtikla
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
            System.Windows.Forms.Label cijenaLabel;
            System.Windows.Forms.Label jedinica_mjereLabel;
            System.Windows.Forms.Label vrsta_artikla_jeloLabel;
            System.Windows.Forms.Label vrijeme_pripremeLabel;
            System.Windows.Forms.Label nazivLabel1;
            this.restoranDBDataSet = new Restoran.NET.RestoranDBDataSet();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artiklTableAdapter = new Restoran.NET.RestoranDBDataSetTableAdapters.ArtiklTableAdapter();
            this.tableAdapterManager = new Restoran.NET.RestoranDBDataSetTableAdapters.TableAdapterManager();
            this.cijenaTextBox = new System.Windows.Forms.TextBox();
            this.jedinica_mjereComboBox = new System.Windows.Forms.ComboBox();
            this.jedinicaMjereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vrsta_artikla_jeloCheckBox = new System.Windows.Forms.CheckBox();
            this.vrijeme_pripremeTextBox = new System.Windows.Forms.TextBox();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.jedinica_mjereTableAdapter = new Restoran.NET.RestoranDBDataSetTableAdapters.Jedinica_mjereTableAdapter();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdbaci = new System.Windows.Forms.Button();
            cijenaLabel = new System.Windows.Forms.Label();
            jedinica_mjereLabel = new System.Windows.Forms.Label();
            vrsta_artikla_jeloLabel = new System.Windows.Forms.Label();
            vrijeme_pripremeLabel = new System.Windows.Forms.Label();
            nazivLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedinicaMjereBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cijenaLabel
            // 
            cijenaLabel.AutoSize = true;
            cijenaLabel.Location = new System.Drawing.Point(19, 80);
            cijenaLabel.Name = "cijenaLabel";
            cijenaLabel.Size = new System.Drawing.Size(39, 13);
            cijenaLabel.TabIndex = 5;
            cijenaLabel.Text = "Cijena:";
            // 
            // jedinica_mjereLabel
            // 
            jedinica_mjereLabel.AutoSize = true;
            jedinica_mjereLabel.Location = new System.Drawing.Point(19, 52);
            jedinica_mjereLabel.Name = "jedinica_mjereLabel";
            jedinica_mjereLabel.Size = new System.Drawing.Size(77, 13);
            jedinica_mjereLabel.TabIndex = 7;
            jedinica_mjereLabel.Text = "Jedinica mjere:";
            // 
            // vrsta_artikla_jeloLabel
            // 
            vrsta_artikla_jeloLabel.AutoSize = true;
            vrsta_artikla_jeloLabel.Location = new System.Drawing.Point(19, 111);
            vrsta_artikla_jeloLabel.Name = "vrsta_artikla_jeloLabel";
            vrsta_artikla_jeloLabel.Size = new System.Drawing.Size(84, 13);
            vrsta_artikla_jeloLabel.TabIndex = 9;
            vrsta_artikla_jeloLabel.Text = "Vrsta artikla jelo:";
            // 
            // vrijeme_pripremeLabel
            // 
            vrijeme_pripremeLabel.AutoSize = true;
            vrijeme_pripremeLabel.Location = new System.Drawing.Point(19, 143);
            vrijeme_pripremeLabel.Name = "vrijeme_pripremeLabel";
            vrijeme_pripremeLabel.Size = new System.Drawing.Size(87, 13);
            vrijeme_pripremeLabel.TabIndex = 11;
            vrijeme_pripremeLabel.Text = "Vrijeme pripreme:";
            // 
            // nazivLabel1
            // 
            nazivLabel1.AutoSize = true;
            nazivLabel1.Location = new System.Drawing.Point(19, 20);
            nazivLabel1.Name = "nazivLabel1";
            nazivLabel1.Size = new System.Drawing.Size(37, 13);
            nazivLabel1.TabIndex = 13;
            nazivLabel1.Text = "Naziv:";
            // 
            // restoranDBDataSet
            // 
            this.restoranDBDataSet.DataSetName = "RestoranDBDataSet";
            this.restoranDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataMember = "Artikl";
            this.artiklBindingSource.DataSource = this.restoranDBDataSet;
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtiklTableAdapter = this.artiklTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Jedinica_mjereTableAdapter = null;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.Stavka_racunaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Restoran.NET.RestoranDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZaposlenikTableAdapter = null;
            // 
            // cijenaTextBox
            // 
            this.cijenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "Cijena", true));
            this.cijenaTextBox.Location = new System.Drawing.Point(112, 78);
            this.cijenaTextBox.Name = "cijenaTextBox";
            this.cijenaTextBox.Size = new System.Drawing.Size(91, 20);
            this.cijenaTextBox.TabIndex = 3;
            // 
            // jedinica_mjereComboBox
            // 
            this.jedinica_mjereComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.artiklBindingSource, "Jedinica mjere", true));
            this.jedinica_mjereComboBox.DataSource = this.jedinicaMjereBindingSource;
            this.jedinica_mjereComboBox.DisplayMember = "Naziv jedinice mjere";
            this.jedinica_mjereComboBox.FormattingEnabled = true;
            this.jedinica_mjereComboBox.Location = new System.Drawing.Point(112, 49);
            this.jedinica_mjereComboBox.Name = "jedinica_mjereComboBox";
            this.jedinica_mjereComboBox.Size = new System.Drawing.Size(91, 21);
            this.jedinica_mjereComboBox.TabIndex = 2;
            this.jedinica_mjereComboBox.ValueMember = "Sifra jedinice mjere";
            // 
            // jedinicaMjereBindingSource
            // 
            this.jedinicaMjereBindingSource.DataMember = "Jedinica mjere";
            this.jedinicaMjereBindingSource.DataSource = this.restoranDBDataSet;
            // 
            // vrsta_artikla_jeloCheckBox
            // 
            this.vrsta_artikla_jeloCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.artiklBindingSource, "Vrsta artikla jelo", true));
            this.vrsta_artikla_jeloCheckBox.Location = new System.Drawing.Point(144, 106);
            this.vrsta_artikla_jeloCheckBox.Name = "vrsta_artikla_jeloCheckBox";
            this.vrsta_artikla_jeloCheckBox.Size = new System.Drawing.Size(59, 24);
            this.vrsta_artikla_jeloCheckBox.TabIndex = 4;
            this.vrsta_artikla_jeloCheckBox.Text = "Da";
            this.vrsta_artikla_jeloCheckBox.UseVisualStyleBackColor = true;
            // 
            // vrijeme_pripremeTextBox
            // 
            this.vrijeme_pripremeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "Vrijeme pripreme", true));
            this.vrijeme_pripremeTextBox.Location = new System.Drawing.Point(112, 140);
            this.vrijeme_pripremeTextBox.Name = "vrijeme_pripremeTextBox";
            this.vrijeme_pripremeTextBox.Size = new System.Drawing.Size(91, 20);
            this.vrijeme_pripremeTextBox.TabIndex = 5;
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "Naziv", true));
            this.nazivTextBox.Location = new System.Drawing.Point(112, 18);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(170, 20);
            this.nazivTextBox.TabIndex = 1;
            // 
            // jedinica_mjereTableAdapter
            // 
            this.jedinica_mjereTableAdapter.ClearBeforeFill = true;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(41, 183);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(84, 35);
            this.btnSpremi.TabIndex = 6;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdbaci
            // 
            this.btnOdbaci.Location = new System.Drawing.Point(162, 183);
            this.btnOdbaci.Name = "btnOdbaci";
            this.btnOdbaci.Size = new System.Drawing.Size(84, 35);
            this.btnOdbaci.TabIndex = 7;
            this.btnOdbaci.Text = "Odbaci";
            this.btnOdbaci.UseVisualStyleBackColor = true;
            this.btnOdbaci.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnOdbaci_MouseUp);
            // 
            // frmDodavanjeArtikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 245);
            this.Controls.Add(this.btnOdbaci);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(nazivLabel1);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(vrijeme_pripremeLabel);
            this.Controls.Add(this.vrijeme_pripremeTextBox);
            this.Controls.Add(vrsta_artikla_jeloLabel);
            this.Controls.Add(this.vrsta_artikla_jeloCheckBox);
            this.Controls.Add(jedinica_mjereLabel);
            this.Controls.Add(this.jedinica_mjereComboBox);
            this.Controls.Add(cijenaLabel);
            this.Controls.Add(this.cijenaTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDodavanjeArtikla";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje artikla";
            this.Load += new System.EventHandler(this.frmDodavanjeArtikla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restoranDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedinicaMjereBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestoranDBDataSet restoranDBDataSet;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private RestoranDBDataSetTableAdapters.ArtiklTableAdapter artiklTableAdapter;
        private RestoranDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cijenaTextBox;
        private System.Windows.Forms.ComboBox jedinica_mjereComboBox;
        private System.Windows.Forms.CheckBox vrsta_artikla_jeloCheckBox;
        private System.Windows.Forms.TextBox vrijeme_pripremeTextBox;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.BindingSource jedinicaMjereBindingSource;
        private RestoranDBDataSetTableAdapters.Jedinica_mjereTableAdapter jedinica_mjereTableAdapter;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdbaci;
    }
}