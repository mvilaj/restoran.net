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
    public partial class frmZaposlenici : Form
    {
        public frmZaposlenici()
        {
            InitializeComponent();
        }

        private void zaposlenikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zaposlenikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restoranDBDataSet);

        }

        private void Zaposlenici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restoranDBDataSet.Zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.Fill(this.restoranDBDataSet.Zaposlenik);

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDodavanjeZaposlenika frmZaposlenik = new frmDodavanjeZaposlenika();
            frmZaposlenik.ShowDialog();     //dialog ne dozvoljava fokus drugih kontroli
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.zaposlenikBindingSource.EndEdit();//prekida editiranje trenutne čelije
                this.zaposlenikTableAdapter.Update(restoranDBDataSet.Zaposlenik);//ažurira novo stanje u tablici
            }

            catch
            {
                MessageBox.Show("Došlo je do pogreške prilikom ažuriranja redova, pokušajte ponovo.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li obrisati zaposlenika?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                zaposlenikDataGridView.Rows.RemoveAt(zaposlenikDataGridView.CurrentRow.Index);
                //spremanje
                this.Validate();
                this.zaposlenikBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.restoranDBDataSet);

            }
        }
    }
}
