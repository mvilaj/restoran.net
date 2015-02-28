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
    public partial class GlavniDioRacuna : Form
    {
        public GlavniDioRacuna()
        {
            InitializeComponent();
        }

        private void GlavniDioRacuna_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restoranDBDataSet.Zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.Fill(this.restoranDBDataSet.Zaposlenik);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            queriesTableAdapter1.UnosRacunaGlavno(dateTimePicker1.Value,Convert.ToInt32(comboBox1.SelectedValue));
           

            PregledRacuna pregledRacuna = new PregledRacuna();
            pregledRacuna.MdiParent = (GlavnaForma)this.ParentForm;
            pregledRacuna.Show();

            this.Close();
        }
    }
}
