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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Lozinka.PasswordChar = '*';
            Korisnicko_ime.Focus();

            //Korisnicko_ime.Text = "zaposlenik";
            //Lozinka.Text = "zaposlenik";
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (Korisnicko_ime.Text == ("kuhar") && Lozinka.Text == ("kuhar"))
            {
                ((GlavnaForma)this.MdiParent).narudžbeToolStripMenuItem.Visible = true;               
                ((GlavnaForma)this.MdiParent).odjavaToolStripMenuItem.Visible = true;
                ((GlavnaForma)this.MdiParent).loginToolStripMenuItem.Visible = false;
                ((GlavnaForma)this.MdiParent).odjavaToolStripMenuItem.Text = "Odjava (kuhar)";
                this.Close();
            }

            else if (Korisnicko_ime.Text == ("zaposlenik") && Lozinka.Text == ("zaposlenik"))
            {
                ((GlavnaForma)this.MdiParent).artikliToolStripMenuItem.Visible = true;
                ((GlavnaForma)this.MdiParent).kreiranjeRacunaToolStripMenuItem.Visible = true;
                ((GlavnaForma)this.MdiParent).odjavaToolStripMenuItem.Visible = true;
                ((GlavnaForma)this.MdiParent).loginToolStripMenuItem.Visible = false;
                ((GlavnaForma)this.MdiParent).narudžbeToolStripMenuItem.Visible = true;
                ((GlavnaForma)this.MdiParent).zaposleniciToolStripMenuItem.Visible=true;
                ((GlavnaForma)this.MdiParent).odjavaToolStripMenuItem.Text = "Odjava (zaposlenik)"; 
                this.Close();
            }

            else
            {
                MessageBox.Show("Unijeli ste pogrešne podatke, pokušajte ponovo!");
                Korisnicko_ime.Focus();
                Korisnicko_ime.Text = "";
                Lozinka.Text = "";
            }

        }

        void UkljuciMenuStrip()//uključuje Artikli, Kreiranje računa an glavnoj formi
        {
            ((GlavnaForma)this.MdiParent).artikliToolStripMenuItem.Enabled = true;
            ((GlavnaForma)this.MdiParent).kreiranjeRacunaToolStripMenuItem.Enabled = true;
            ((GlavnaForma)this.MdiParent).odjavaToolStripMenuItem.Visible = true;
            ((GlavnaForma)this.MdiParent).loginToolStripMenuItem.Visible = false;
        }
    }
}
