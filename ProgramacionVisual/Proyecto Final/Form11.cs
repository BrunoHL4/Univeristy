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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(textBox1.Text);
            
            b = a * 1000;

            label2.Text = Convert.ToString("La distancia ingresada en metros es: ");
            label3.Text = Convert.ToString(b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
