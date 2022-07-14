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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, hipotenusa, perimetro, area;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            hipotenusa = Math.Sqrt((a * a) + (b * b));
            perimetro = hipotenusa + a + b;
            area = b * a / 2;
            label3.Text = Convert.ToString(hipotenusa);
            label4.Text = Convert.ToString(perimetro);
            label5.Text = Convert.ToString(area);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
