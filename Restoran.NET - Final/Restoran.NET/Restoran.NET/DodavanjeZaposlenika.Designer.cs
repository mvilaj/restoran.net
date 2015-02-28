namespace Restoran.NET
{
    partial class frmDodavanjeZaposlenika
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
            System.Windows.Forms.Label ime_i_prezimeLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label broj_telefonaLabel;
            this.restoranDBDataSet = new Restoran.NET.RestoranDBDataSet();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikTableAdapter = new Restoran.NET.RestoranDBDataSetTableAdapters.ZaposlenikTableAdapter();
            this.tableAdapterManager = new Restoran.NET.RestoranDBDataSetTableAdapters.TableAdapterManager();
            this.ime_i_prezimeTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.broj_telefonaTextBox = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdbaci = new System.Windows.Forms.Button();
            ime_i_prezimeLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            broj_telefonaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ime_i_prezimeLabel
            // 
            ime_i_prezimeLabel.AutoSize = true;
            ime_i_prezimeLabel.Location = new System.Drawing.Point(27, 38);
            ime_i_prezimeLabel.Name = "ime_i_prezimeLabel";
            ime_i_prezimeLabel.Size = new System.Drawing.Size(71, 13);
            ime_i_prezimeLabel.TabIndex = 1;
            ime_i_prezimeLabel.Text = "Ime i prezime:";
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Location = new System.Drawing.Point(27, 72);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(43, 13);
            adresaLabel.TabIndex = 3;
            adresaLabel.Text = "Adresa:";
            // 
            // broj_telefonaLabel
            // 
            broj_telefonaLabel.AutoSize = true;
            broj_telefonaLabel.Location = new System.Drawing.Point(27, 127);
            broj_telefonaLabel.Name = "broj_telefonaLabel";
            broj_telefonaLabel.Size = new System.Drawing.Size(69, 13);
            broj_telefonaLabel.TabIndex = 5;
            broj_telefonaLabel.Text = "Broj telefona:";
            // 
            // restoranDBDataSet
            // 
            this.restoranDBDataSet.DataSetName = "RestoranDBDataSet";
            this.restoranDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataMember = "Zaposlenik";
            this.zaposlenikBindingSource.DataSource = this.restoranDBDataSet;
            // 
            // zaposlenikTableAdapter
            // 
            this.zaposlenikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtiklTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Jedinica_mjereTableAdapter = null;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.Stavka_racunaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Restoran.NET.RestoranDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZaposlenikTableAdapter = this.zaposlenikTableAdapter;
            // 
            // ime_i_prezimeTextBox
            // 
            this.ime_i_prezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Ime i prezime", true));
            this.ime_i_prezimeTextBox.Location = new System.Drawing.Point(104, 35);
            this.ime_i_prezimeTextBox.Name = "ime_i_prezimeTextBox";
            this.ime_i_prezimeTextBox.Size = new System.Drawing.Size(148, 20);
            this.ime_i_prezimeTextBox.TabIndex = 2;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Adresa", true));
            this.adresaTextBox.Location = new System.Drawing.Point(104, 69);
            this.adresaTextBox.Multiline = true;
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(148, 40);
            this.adresaTextBox.TabIndex = 4;
            // 
            // broj_telefonaTextBox
            // 
            this.broj_telefonaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Broj telefona", true));
            this.broj_telefonaTextBox.Location = new System.Drawing.Point(104, 124);
            this.broj_telefonaTextBox.Name = "broj_telefonaTextBox";
            this.broj_telefonaTextBox.Size = new System.Drawing.Size(148, 20);
            this.broj_telefonaTextBox.TabIndex = 6;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(40, 165);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(85, 44);
            this.btnSpremi.TabIndex = 7;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdbaci
            // 
            this.btnOdbaci.Location = new System.Drawing.Point(157, 165);
            this.btnOdbaci.Name = "btnOdbaci";
            this.btnOdbaci.Size = new System.Drawing.Size(85, 44);
            this.btnOdbaci.TabIndex = 8;
            this.btnOdbaci.Text = "Odbaci";
            this.btnOdbaci.UseVisualStyleBackColor = true;
            this.btnOdbaci.Click += new System.EventHandler(this.btnOdbaci_Click);
            // 
            // frmDodavanjeZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 236);
            this.Controls.Add(this.btnOdbaci);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(broj_telefonaLabel);
            this.Controls.Add(this.broj_telefonaTextBox);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(ime_i_prezimeLabel);
            this.Controls.Add(this.ime_i_prezimeTextBox);
            this.Name = "frmDodavanjeZaposlenika";
            this.Text = "Dodavanje zaposlenika";
            this.Load += new System.EventHandler(this.frmDodavanjeZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restoranDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestoranDBDataSet restoranDBDataSet;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private RestoranDBDataSetTableAdapters.ZaposlenikTableAdapter zaposlenikTableAdapter;
        private RestoranDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox ime_i_prezimeTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox broj_telefonaTextBox;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdbaci;
    }
}