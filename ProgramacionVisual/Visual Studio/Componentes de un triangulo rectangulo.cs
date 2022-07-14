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
    public partial class Componentes_de_un_triangulo_rectangulo : Form
    {
        public Componentes_de_un_triangulo_rectangulo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            double h, ca, cb;
            try
            {
                h = Convert.ToDouble(textBox1.Text);
                ca = Convert.ToDouble(textBox2.Text);
                cb= Math.Sqrt(Math.Pow(h, 2) - Math.Pow(ca, 2));
                label5.Text = "Cateto opuesto: " ;
                label5.Text = Convert.ToString(cb);
            }
            catch
            { MessageBox.Show("Ingrese los valores"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double h, ca, co, area, perimetro, a, b;
            try
            {
                h = Convert.ToDouble(textBox1.Text);
                ca = Convert.ToDouble(textBox2.Text);
                co = Math.Sqrt(Math.Pow(h, 2) - Math.Pow(ca, 2));
                label5.Text = Convert.ToString(co);
                area = (co * ca) / 2;
                label11.Text = Convert.ToString(area);
                perimetro = co + ca + h;
                label12.Text = Convert.ToString(perimetro);
                a = (Math.Asin(co / h)) * (180 / Math.PI);
                label13.Text = Convert.ToString(a);
                b = (Math.Asin(ca / h)) * (180 / Math.PI);
                label14.Text = Convert.ToString(b);

            }
            catch
            { MessageBox.Show("Introduzca los valores"); }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
