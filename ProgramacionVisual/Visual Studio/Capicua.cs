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
    public partial class Capicua : Form
    {
        public Capicua()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num, aux, resto, numInv = 0;
            try
            {
                num = Convert.ToInt32(textBox1.Text);
                aux = num;
                while (aux > 0)
                {
                    resto = aux % 10;
                    aux = aux / 10;
                    numInv = numInv * 10 + resto;
                }
                if (numInv == num) { label4.Text = "El número es capicúa"; }
                else { label4.Text = "El número no es capicúa"; }
            }
            catch
            { MessageBox.Show("Introduzca un numero"); }
            
        }
    }
}
