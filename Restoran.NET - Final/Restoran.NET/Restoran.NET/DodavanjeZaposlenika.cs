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
    public partial class frmDodavanjeZaposlenika : Form
    {
        public frmDodavanjeZaposlenika()
        {
            InitializeComponent();
        }

        private void zaposlenikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zaposlenikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restoranDBDataSet);

        }

        private void frmDodavanjeZaposlenika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restoranDBDataSet.Zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.Fill(this.restoranDBDataSet.Zaposlenik);
            zaposlenikBindingSource.AddNew();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                dodajNovogZaposlenika();
            }

            catch
            {
                MessageBox.Show("Došlo je do pogreške prilikom unosa podataka, pokušajte ponovno", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmZaposlenici pregledZaposlenika = new frmZaposlenici();
            pregledZaposlenika.MdiParent = (GlavnaForma)this.ParentForm;
            pregledZaposlenika.Show();
        }
        private void dodajNovogZaposlenika()
        {
            this.Validate();
            this.zaposlenikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restoranDBDataSet);
        }

        private void btnOdbaci_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
