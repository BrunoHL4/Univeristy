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
    public partial class Conversion_de_temperatura : Form
    {
        public Conversion_de_temperatura()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double c, f;
            try
            {
                c = Convert.ToDouble(textBox1.Text);
                f = (c * 9) / 5 + 32;
                label6.Text = Convert.ToString(f);
            }
            catch
            { MessageBox.Show("Introduzca un valor"); }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            double c, k;
            try
            {
                c = Convert.ToDouble(textBox1.Text);
                k = c + 273.15;
                label6.Text = Convert.ToString(k);
            }
            catch
            { MessageBox.Show("Introduzca un valor"); }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            double f, c;
            try
            {
                f = Convert.ToDouble(textBox1.Text);
                c = ((f-32)*5)/9;
                label6.Text = Convert.ToString(c);
            }
            catch
            { MessageBox.Show("Introduzca un valor"); }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            double f, k;
            try
            {
                f = Convert.ToDouble(textBox1.Text);
                k = ((f-32)*5)/9+273.15;
                label6.Text = Convert.ToString(k);
            }
            catch
            { MessageBox.Show("Introduzca un valor"); }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            double k, c;
            try
            {
                k = Convert.ToDouble(textBox1.Text);
                c = k-273.15;
                label6.Text = Convert.ToString(c);
            }
            catch
            { MessageBox.Show("Introduzca un valor"); }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            double k, f;
            try
            {
                k = Convert.ToDouble(textBox1.Text);
                f = ((k-273.15)*9)/5+32;
                label6.Text = Convert.ToString(f);
            }
            catch
            { MessageBox.Show("Introduzca un valor"); }
        }
    }
}
