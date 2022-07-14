using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menú_Proyecto
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, at, al;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);

            al = 2 * ((c * a) + (b * c));
            at = al + 2 * (a * b);

            label5.Text = Convert.ToString(al);
            label7.Text = Convert.ToString(at);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
