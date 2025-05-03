using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();
        }

        int prviBroj, drugiBroj;

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt.Text +=" 1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt.Text += " 2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt.Text += " 3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txt.Text += " 4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt.Text += " 5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txt.Text += " 6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txt.Text += " 7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txt.Text += " 8";

        }

        private void btn10_Click(object sender, EventArgs e)
        {
            txt.Text += " 9";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txt.Text += " +";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txt.Text += " -";
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            txt.Text += " *";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txt.Text += " /";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            txt.Text += " =";
        }
    }
}
