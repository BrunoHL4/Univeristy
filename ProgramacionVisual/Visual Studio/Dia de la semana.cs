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
    public partial class Dia_de_la_semana : Form
    {
        public Dia_de_la_semana()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero;
            try
            {
                numero = Convert.ToInt32(textBox1.Text);
                switch(numero)
                {
                    case 1: label3.Text = "DOMINGO"; break;
                    case 2: label3.Text = "LUNES"; break;
                    case 3: label3.Text = "MARTES"; break;
                    case 4: label3.Text = "MIÉRCOLES"; break;
                    case 5: label3.Text = "JUEVES"; break;
                    case 6: label3.Text = "VIERNES"; break;
                    case 7: label3.Text = "SABADO"; break;
                    default: label3.Text = "Solo hay 7 días en la semana"; break;
                }
            }
            catch
            { MessageBox.Show("Introduzca un número"); }

        }
    }
}
