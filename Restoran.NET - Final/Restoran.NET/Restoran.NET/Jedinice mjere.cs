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
    public partial class frmJedinice_mjere : Form
    {
        public frmJedinice_mjere()
        {
            InitializeComponent();
        }

        private void jedinica_mjereBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jedinica_mjereBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restoranDBDataSet);

        }

        private void frmJedinice_mjere_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restoranDBDataSet.Jedinica_mjere' table. You can move, or remove it, as needed.
            this.jedinica_mjereTableAdapter.Fill(this.restoranDBDataSet.Jedinica_mjere);

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDodavanjeJediniceMjere frmJedinicaMjere = new frmDodavanjeJediniceMjere();
            frmJedinicaMjere.ShowDialog();     //dialog ne dozvoljava fokus drugih kontroli
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.jedinica_mjereBindingSource.EndEdit();//prekida editiranje trenutne čelije
                this.jedinica_mjereTableAdapter.Update(restoranDBDataSet.Jedinica_mjere);//ažurira novo stanje u tablici
            }

            catch
            {
                MessageBox.Show("Došlo je do pogreške prilikom ažuriranja redova, pokušajte ponovo", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li obrisati jedinicu mjere?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                jedinica_mjereDataGridView.Rows.RemoveAt(jedinica_mjereDataGridView.CurrentRow.Index);
                //spremanje
                this.Validate();
                this.jedinica_mjereBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.restoranDBDataSet);

            }
        }
    }
}
