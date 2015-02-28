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
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Show();
        }

     
        

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void dodajArtiklToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodavanjeArtikla dodajArtikl = new frmDodavanjeArtikla();
            dodajArtikl.MdiParent = this;
            dodajArtikl.Show();
        }

        private void pregledArtikalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArtikli artikliFrom = new frmArtikli();
            artikliFrom.MdiParent = this;
            artikliFrom.Show();
        }


        private void dodajGlavniDioRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlavniDioRacuna glavniDio = new GlavniDioRacuna();
            glavniDio.MdiParent = this;
            glavniDio.Show();
        }

        private void dodajStavkeRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StavkeRacuna stavkeRacuna = new StavkeRacuna();
            stavkeRacuna.MdiParent = this;
            stavkeRacuna.Show();
        }

        private void pregledRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledRacuna pregledRacuna = new PregledRacuna();
            pregledRacuna.MdiParent = this;
            pregledRacuna.Show();
        }

        private void narudžbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Narudzbe narudzbe = new Narudzbe();
            narudzbe.MdiParent = this;
            narudzbe.Show();
        }

        private void dodajZaposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodavanjeZaposlenika dodajZaposlenika = new frmDodavanjeZaposlenika();
            dodajZaposlenika.MdiParent = this;
            dodajZaposlenika.Show();
        }

        private void pregledZaposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZaposlenici pregledZaposlenika = new frmZaposlenici();
            pregledZaposlenika.MdiParent = this;
            pregledZaposlenika.Show();
        }

        private void pregledJedinicaMjereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJedinice_mjere pregledJedinicaMjere = new frmJedinice_mjere();
            pregledJedinicaMjere.MdiParent = this;
            pregledJedinicaMjere.Show();
        }

        private void dodajJedinicuMjereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodavanjeJediniceMjere dodajJedinicuMjere = new frmDodavanjeJediniceMjere();
            dodajJedinicuMjere.MdiParent = this;
            dodajJedinicuMjere.Show();
        }

       
    }
}
