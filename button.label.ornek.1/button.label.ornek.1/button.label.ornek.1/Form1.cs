using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.label.ornek._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfenerbahce_Click(object sender, EventArgs e)
        {
            lblTakim.Text = "FENERBAHÇE";
            lblTakim.BackColor = Color.Yellow;
            lblTakim.ForeColor = Color.DarkBlue;
                
        }

        private void lblTakim_Click(object sender, EventArgs e)
        {

        }

        private void btnbesiktas_Click(object sender, EventArgs e)
        {
            lblTakim.Text = "BEŞİKTAŞ";
            lblTakim.BackColor = Color.Black;
            lblTakim.ForeColor = Color.White;
        }

        private void btngalatasaray_Click(object sender, EventArgs e)
        {
            lblTakim.Text = "GALATASARAY";
            lblTakim.BackColor = Color.Yellow;
            lblTakim.ForeColor = Color.Red;
        }

        private void btntrabzonspor_Click(object sender, EventArgs e)
        {
            lblTakim.Text = "TRABZONSPOR";
            lblTakim.BackColor = Color.DarkRed;
            lblTakim.ForeColor = Color.Blue;
        }
    }
}
