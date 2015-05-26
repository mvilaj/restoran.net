using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_2_Testiranje
{
    public partial class FrmTrokut : Form
    {
        public FrmTrokut()
        {
            InitializeComponent();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            float stranicaA = float.Parse(txtStranicaA.Text);
            float visina = 0;
            float povrsina = 0;
            float opseg = 0;

            Trokut t = new Trokut(stranicaA);
            visina = t.IzracunajVisinu();
            povrsina = t.IzracunajPovrsinu();
            opseg = t.IzrcunajOpseg();

            txtVisina.Text = visina.ToString();
            txtPovrsina.Text = povrsina.ToString();
            txtOpseg.Text = opseg.ToString();
        }
    }
}
