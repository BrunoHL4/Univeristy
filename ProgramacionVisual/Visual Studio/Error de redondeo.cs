using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Error_de_redondeo : Form
    {
        public Error_de_redondeo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s, sv, ev;
            int n, i;
            try
            {
                n = Convert.ToInt32(textBox1.Text);
                s = 0;
                for (i = 1; i <= n; i++)
                    s = s + 0.1;
                    label6.Text = Convert.ToString(s);
                sv = n * 0.1;
                label7.Text = Convert.ToString(sv);
                ev = Math.Abs((sv - s) / sv) * 100;
                label8.Text = Convert.ToString(ev);

            }
            catch { MessageBox.Show("Introduzca No. de veces a sumar"); }
        }
    }
}
