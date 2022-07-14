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
    public partial class Decenas_y_unidades : Form
    {
        public Decenas_y_unidades()
        {
            InitializeComponent();
        }

        private void Decenas_y_unidades_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num, d, u;
            try
            {
                num = Convert.ToInt32(textBox1.Text);
                d = num / 10;
                u = num % 10;
                if(d > u) { label3.Text = "El dígito de las decenas es mayor que el de las unidades"; }
                if(u > d) { label3.Text = "El dígito de las unidades es mayor que el dígito de las decenas"; }
                if (u == d) { label3.Text = "El dígito de las unidades y decenas son iguales"; }
            }
            catch
            { MessageBox.Show("Introduzca un número de 2 dígitos"); }
        }
    }
}
