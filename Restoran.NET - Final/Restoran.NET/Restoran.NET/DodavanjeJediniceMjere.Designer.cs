namespace Restoran.NET
{
    partial class frmDodavanjeJediniceMjere
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
            System.Windows.Forms.Label naziv_jedinice_mjereLabel;
            this.restoranDBDataSet = new Restoran.NET.RestoranDBDataSet();
            this.jedinica_mjereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jedinica_mjereTableAdapter = new Restoran.NET.RestoranDBDataSetTableAdapters.Jedinica_mjereTableAdapter();
            this.tableAdapterManager = new Restoran.NET.RestoranDBDataSetTableAdapters.TableAdapterManager();
            this.naziv_jedinice_mjereTextBox = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdbaci = new System.Windows.Forms.Button();
            naziv_jedinice_mjereLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedinica_mjereBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // naziv_jedinice_mjereLabel
            // 
            naziv_jedinice_mjereLabel.AutoSize = true;
            naziv_jedinice_mjereLabel.Location = new System.Drawing.Point(30, 39);
            naziv_jedinice_mjereLabel.Name = "naziv_jedinice_mjereLabel";
            naziv_jedinice_mjereLabel.Size = new System.Drawing.Size(104, 13);
            naziv_jedinice_mjereLabel.TabIndex = 1;
            naziv_jedinice_mjereLabel.Text = "Naziv jedinice mjere:";
            // 
            // restoranDBDataSet
            // 
            this.restoranDBDataSet.DataSetName = "RestoranDBDataSet";
            this.restoranDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jedinica_mjereBindingSource
            // 
            this.jedinica_mjereBindingSource.DataMember = "Jedinica mjere";
            this.jedinica_mjereBindingSource.DataSource = this.restoranDBDataSet;
            // 
            // jedinica_mjereTableAdapter
            // 
            this.jedinica_mjereTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtiklTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Jedinica_mjereTableAdapter = this.jedinica_mjereTableAdapter;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.Stavka_racunaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Restoran.NET.RestoranDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZaposlenikTableAdapter = null;
            // 
            // naziv_jedinice_mjereTextBox
            // 
            this.naziv_jedinice_mjereTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jedinica_mjereBindingSource, "Naziv jedinice mjere", true));
            this.naziv_jedinice_mjereTextBox.Location = new System.Drawing.Point(140, 36);
            this.naziv_jedinice_mjereTextBox.Name = "naziv_jedinice_mjereTextBox";
            this.naziv_jedinice_mjereTextBox.Size = new System.Drawing.Size(100, 20);
            this.naziv_jedinice_mjereTextBox.TabIndex = 2;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(42, 90);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(81, 37);
            this.btnSpremi.TabIndex = 3;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdbaci
            // 
            this.btnOdbaci.Location = new System.Drawing.Point(150, 90);
            this.btnOdbaci.Name = "btnOdbaci";
            this.btnOdbaci.Size = new System.Drawing.Size(81, 37);
            this.btnOdbaci.TabIndex = 4;
            this.btnOdbaci.Text = "Odbaci";
            this.btnOdbaci.UseVisualStyleBackColor = true;
            this.btnOdbaci.Click += new System.EventHandler(this.btnOdbaci_Click);
            // 
            // frmDodavanjeJediniceMjere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 156);
            this.Controls.Add(this.btnOdbaci);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(naziv_jedinice_mjereLabel);
            this.Controls.Add(this.naziv_jedinice_mjereTextBox);
            this.Name = "frmDodavanjeJediniceMjere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje jedinice mjere";
            this.Load += new System.EventHandler(this.frmDodavanjeJediniceMjere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restoranDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedinica_mjereBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestoranDBDataSet restoranDBDataSet;
        private System.Windows.Forms.BindingSource jedinica_mjereBindingSource;
        private RestoranDBDataSetTableAdapters.Jedinica_mjereTableAdapter jedinica_mjereTableAdapter;
        private RestoranDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox naziv_jedinice_mjereTextBox;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdbaci;
    }
}