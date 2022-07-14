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
    public partial class Etapas_de_un_ciclista : Form
    {
        public Etapas_de_un_ciclista()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d, h, f;
            try
            {
               a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);
                d = Convert.ToDouble(textBox4.Text);
                h = Convert.ToDouble(textBox5.Text);

                f = (a + b + c + d + h);
                label7.Text = Convert.ToString(f);
            }
            catch { MessageBox.Show("Introduce las etapas"); }
        }
    }
}
