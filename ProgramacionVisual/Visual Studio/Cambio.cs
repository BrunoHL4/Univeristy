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
    public partial class Cambio : Form
    {
        public Cambio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor, c, p, quinientos = 0, doscientos = 0, cien = 0, cincuenta = 0, veinte = 0, diez = 0, cinco = 0, uno = 0, cambio;
            try
            {
                c = Convert.ToInt32(textBox2.Text);
            p = Convert.ToInt32(textBox1.Text);
            
            valor = c - p;
            quinientos = valor / 500;
            valor %= 500;
            doscientos = valor / 200;
            valor %= 200;
            cien = valor / 100;
            valor %= 100;
            cincuenta = valor / 50;
            valor %= 50;
            veinte = valor / 20;
            valor %= 20;
            diez = valor / 10;
            valor %= 10;
            cinco = valor / 5;
            uno = valor % 5;
            cambio = c - p;

            label14.Text = Convert.ToString(cambio); 
            label15.Text = Convert.ToString(quinientos);
            label16.Text = Convert.ToString(doscientos);
            label17.Text = Convert.ToString(cien);
            label18.Text = Convert.ToString(cincuenta);
            label19.Text = Convert.ToString(veinte);
            label20.Text = Convert.ToString(diez);
            label21.Text = Convert.ToString(cinco);
            label22.Text = Convert.ToString(uno);
            }

            catch
            { MessageBox.Show("Introduzca los valores"); }
        }
    }
}
