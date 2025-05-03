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
        int brojac = 0;
        char operacija;

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (brojac == 0) prviBroj = 1;
            else drugiBroj = 1;
                brojac++;
            txt.Text +=" 1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (brojac == 0) prviBroj = 2;
            else drugiBroj = 2;
            brojac++;
            txt.Text += " 2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (brojac == 0) prviBroj = 3;
            else drugiBroj = 3;
            brojac++;
            txt.Text += " 3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (brojac == 0) prviBroj = 4;
            else drugiBroj = 4;
            brojac++;
            txt.Text += " 4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (brojac == 0) prviBroj = 5;
            else drugiBroj = 5;
            brojac++;
            txt.Text += " 5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (brojac == 0) prviBroj = 6;
            else drugiBroj = 6;
            brojac++;
            txt.Text += " 6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (brojac == 0) prviBroj = 7;
            else drugiBroj = 7;
            brojac++;
            txt.Text += " 7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (brojac == 0) prviBroj = 8;
            else drugiBroj = 8;
            brojac++;
            txt.Text += " 8";

        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (brojac == 0) prviBroj = 9;
            else drugiBroj = 9;
            brojac++;
            txt.Text += " 9";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operacija = '+';
            txt.Text += " +";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operacija = '-';
            txt.Text += " -";
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            operacija = '*';
            txt.Text += " *";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operacija = '/';
            txt.Text += " /";
        }

        private async void btnEqual_Click(object sender, EventArgs e)
        {
            if (operacija == '+') txt.Text = (prviBroj + drugiBroj).ToString();
            if (operacija == '-') txt.Text = (prviBroj - drugiBroj).ToString();
            if (operacija == '*') txt.Text = (prviBroj * drugiBroj).ToString();
            if (operacija == '/') txt.Text = (prviBroj / drugiBroj).ToString();
            await Task.Delay(3000); 
            txt.Text = string.Empty; 
        }
    }
}
