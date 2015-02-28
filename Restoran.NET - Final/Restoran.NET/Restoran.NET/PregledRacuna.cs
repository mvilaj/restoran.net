using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran.NET
{
    public partial class PregledRacuna : Form
    {
        public PregledRacuna()
        {
            InitializeComponent();

        }

        private void PregledRacuna_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restoranDBDataSet.Artikl' table. You can move, or remove it, as needed.
            this.artiklTableAdapter.Fill(this.restoranDBDataSet.Artikl);
            // TODO: This line of code loads data into the 'restoranDBDataSet.Zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.Fill(this.restoranDBDataSet.Zaposlenik);
            // TODO: This line of code loads data into the 'restoranDBDataSet.Stavka_racuna' table. You can move, or remove it, as needed.
          //  this.stavka_racunaTableAdapter.Fill(this.restoranDBDataSet.Stavka_racuna);
            // TODO: This line of code loads data into the 'restoranDBDataSet.Racun' table. You can move, or remove it, as needed.
            this.racunTableAdapter.Fill(this.restoranDBDataSet.Racun);
            


        }

        private void btnDodajGlavno_Click(object sender, EventArgs e)
        {
            GlavniDioRacuna glavniDio = new GlavniDioRacuna();
            glavniDio.MdiParent = (GlavnaForma)this.ParentForm;
            glavniDio.Show();

            this.Close();
        }

        private void btnDodajStavke_Click(object sender, EventArgs e)
        {
            StavkeRacuna stavkeRacuna = new StavkeRacuna();
            stavkeRacuna.MdiParent = (GlavnaForma)this.ParentForm;
            stavkeRacuna.Show();

            this.Close();
        }

        private void btnObrisiGlavniDio_Click(object sender, EventArgs e)
        {
            try
            {
                this.racunBindingSource.RemoveCurrent();
                this.racunTableAdapter.Update(this.restoranDBDataSet.Racun);
            }

            catch
            {
                MessageBox.Show("Pogreška prilikom brisanja, pokušajte ponovno.", "Pogreška prilikom brisanja podataka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnObrisiStavke_Click(object sender, EventArgs e)
        {
           try {
                this.stavkaRacunaBindingSource.RemoveCurrent();
                this.stavka_racunaTableAdapter.Update(this.restoranDBDataSet.Stavka_racuna);
            }

            catch
            {
                MessageBox.Show("Pogreška prilikom brisanja, pokušajte ponovno.", "Pogreška prilikom brisanja podataka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnIzmijeniPodatke_Click(object sender, EventArgs e)
        {
            try {
                this.stavkaRacunaBindingSource.EndEdit();
                this.stavka_racunaTableAdapter.Update(restoranDBDataSet.Stavka_racuna);


                this.racunBindingSource.EndEdit();
                this.racunTableAdapter.Update(restoranDBDataSet.Racun);
            }

            catch
            {
                MessageBox.Show("Došlo je do pogreške prilikom ažuriranja podataka, pokušajte ponovno.", "Pogreška prilikom ažuriranja podataka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

               
                int sifraRacuna = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                this.stavka_racunaTableAdapter.FillBySifraRacuna(this.restoranDBDataSet.Stavka_racuna, sifraRacuna);
                Console.WriteLine("test: " + sifraRacuna);
                //this.racunTableAdapter.FillByVrijemeCekanja(this.restoranDBDataSet.Racun, sifraRacuna);
                //label3.Text = (this.racunTableAdapter.GetDataByVrijemeCekanja(sifraRacuna)).ToString();
              
                //Console.WriteLine("rezultat: "+this.racunTableAdapter.GetDataByVrijemeCekanja(sifraRacuna));



                SqlConnection sqlConnection1 = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename='D:\\SkyDrive\\Documents\\Programsko inženjerstvo\\Projekt\\Restoran.NET - Final\\Restoran.NET\\Baza\\RestoranDB.mdf';Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true");
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;

                string upit="SELECT        MAX(Artikl.[Vrijeme pripreme]) AS [Vrijeme cekanja] "+
                           " FROM Artikl INNER JOIN "+
                           "[Stavka racuna] ON Artikl.[Sifra artikla] = [Stavka racuna].Artikl INNER JOIN "+
                        " Racun ON [Stavka racuna].Racun = Racun.[Sifra racuna] "+
                       " WHERE    (Racun.[Sifra racuna] = "+sifraRacuna+") AND (Artikl.[Vrsta artikla jelo] = 1)";



                cmd.CommandText = upit;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        label3.Text ="Vrijeme pripreme: "+reader.GetInt32(0).ToString() + " minuta";
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();

                sqlConnection1.Close();

            }

            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Došlo je do pogreške, pokušajte ponovno.");
                return;
            }
            
       }

     
    }
}
