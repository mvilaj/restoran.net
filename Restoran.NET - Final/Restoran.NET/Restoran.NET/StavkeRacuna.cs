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
    public partial class StavkeRacuna : Form
    {
        public StavkeRacuna()
        {
            InitializeComponent();
        }

        private void StavkeRacuna_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restoranDBDataSet.Artikl' table. You can move, or remove it, as needed.
            this.artiklTableAdapter.Fill(this.restoranDBDataSet.Artikl);
            // TODO: This line of code loads data into the 'restoranDBDataSet.Racun' table. You can move, or remove it, as needed.
            this.racunTableAdapter.Fill(this.restoranDBDataSet.Racun);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                queriesTableAdapter1.UnosStavkeRacuna(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(textBox1.Text), Convert.ToBoolean(comboBox3.SelectedValue));
            }

            catch {
                MessageBox.Show("Niste unijeli sva potreban polja!");
                return;
            }
            PregledRacuna pregled = new PregledRacuna();
            pregled.MdiParent = (GlavnaForma)this.ParentForm;
            pregled.Show();


            this.Close();
        }
    }
}
