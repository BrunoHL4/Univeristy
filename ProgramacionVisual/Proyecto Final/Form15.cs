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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero;

            numero = Convert.ToDouble(textBox1.Text);
            
            if (numero == 0)
            {
               label2.Text=Convert.ToString ("El numero es cero");
            }
            else if (numero > 0)
            {
                label2.Text = Convert.ToString ("El numero es positivo");
            }
            else
            {
                label2.Text = Convert.ToString ("El numero es negativo");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
