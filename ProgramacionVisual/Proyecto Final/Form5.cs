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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double x, y, suma;
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            suma = x + y;
            label4.Text = Convert.ToString(suma);
            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
