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
    public partial class frmDodavanjeJediniceMjere : Form
    {
        public frmDodavanjeJediniceMjere()
        {
            InitializeComponent();
        }

        private void jedinica_mjereBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jedinica_mjereBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restoranDBDataSet);

        }

        private void frmDodavanjeJediniceMjere_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restoranDBDataSet.Jedinica_mjere' table. You can move, or remove it, as needed.
            this.jedinica_mjereTableAdapter.Fill(this.restoranDBDataSet.Jedinica_mjere);
            jedinica_mjereBindingSource.AddNew();

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                dodajNovuJedinicuMjere();
            }

            catch
            {
                MessageBox.Show("Došlo je do pogreške prilikom unosa podataka, pokušajte ponovno", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmJedinice_mjere pregledJedinicaMjere = new frmJedinice_mjere();
            pregledJedinicaMjere.MdiParent = (GlavnaForma)this.ParentForm;
            pregledJedinicaMjere.Show();

        }

        private void dodajNovuJedinicuMjere()
        {
            this.Validate();
            this.jedinica_mjereBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restoranDBDataSet);
        }

        private void btnOdbaci_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
