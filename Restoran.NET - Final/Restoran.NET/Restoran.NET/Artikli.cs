using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran.NET
{
    public partial class frmArtikli : Form
    {
        public frmArtikli()
        {
            InitializeComponent();
        }

        private void artiklBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.artiklBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restoranDBDataSet);

        }

        private void Artikli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restoranDBDataSet.Jedinica_mjere' table. You can move, or remove it, as needed.
            this.jedinica_mjereTableAdapter.Fill(this.restoranDBDataSet.Jedinica_mjere);
            // TODO: This line of code loads data into the 'restoranDBDataSet.Artikl' table. You can move, or remove it, as needed.
            this.artiklTableAdapter.Fill(this.restoranDBDataSet.Artikl);

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li obrisati artikl?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                artiklDataGridView.Rows.RemoveAt(artiklDataGridView.CurrentRow.Index);
                //spremanje
                this.Validate();
                this.artiklBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.restoranDBDataSet);
          
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDodavanjeArtikla frmArtikl = new frmDodavanjeArtikla();
            frmArtikl.ShowDialog();     //dialog ne dozvoljava fokus drugih kontroli
        }

        private void btnIzmijeni_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                this.Validate();
                this.artiklBindingSource.EndEdit();//prekida editiranje trenutne čelije
                this.artiklTableAdapter.Update(restoranDBDataSet.Artikl);//ažurira novo stanje u tablici
            }

            catch
            {
                MessageBox.Show("Došlo je do pogreške prilikom ažuriranja redova, pokušajte ponovo.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
