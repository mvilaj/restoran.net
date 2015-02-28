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
    public partial class Narudzbe : Form
    {
        public Narudzbe()
        {
            InitializeComponent();
        }

        private void Narudzbe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restoranDBDataSet.Artikl' table. You can move, or remove it, as needed.
            this.artiklTableAdapter.Fill(this.restoranDBDataSet.Artikl);
            // TODO: This line of code loads data into the 'restoranDBDataSet.Stavka_racuna' table. You can move, or remove it, as needed.
            this.stavka_racunaTableAdapter.FillBySamoJela(this.restoranDBDataSet.Stavka_racuna);

        }

       
        private void btnPocniKuhanje_Click(object sender, EventArgs e)
        {
               
           txtPocetak.Text = DateTime.Now.ToString("H:mm:ss");          
           btnPocniKuhanje.Enabled = false;
           txtZavrsetak.Text = "";
           timer1.Interval = 1000;
           timer1.Start();
           btnzavrsiKuhanje.Enabled = true;

        }
        
        int trajanjeKuhanja,minute,sifraArtikla,sifraStavke;
        string ImeArtikla = "";
        private void btnzavrsiKuhanje_Click(object sender, EventArgs e)
        {
            txtZavrsetak.Text = DateTime.Now.ToString("H:mm:ss");
            
            btnPocniKuhanje.Enabled = true;
            timer1.Stop();
            txtUkupno.Text = minute + " minute i " + trajanjeKuhanja + " sekunde/a";
            
            sifraArtikla = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());//dobavlja int vrijednost artikla
            ImeArtikla= (this.artiklTableAdapter.VratiIMeArtikla(sifraArtikla)).ToString();//dobavlja ime artikla uz pomoć int vrijednosti iz reda prije
            sifraStavke = int.Parse(dataGridView3.CurrentRow.Cells["sifraStavkeDataGridViewTextBoxColumn"].Value.ToString());
            
           
            queriesTableAdapter1.ZavrsenoKuhanje(sifraStavke, ImeArtikla, minute);
            queriesTableAdapter1.ZamjenaVrsteJela(sifraStavke);
            this.btnzavrsiKuhanje.Enabled = false;

           
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            trajanjeKuhanja++;
            if (trajanjeKuhanja == 60)
            {
                minute++;
                trajanjeKuhanja = 0;
            }

            txtUkupno.Text = minute + " : " + trajanjeKuhanja;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
