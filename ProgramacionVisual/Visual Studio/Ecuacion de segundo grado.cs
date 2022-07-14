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
    public partial class Ecuacion_de_segundo_grado : Form
    {
        public Ecuacion_de_segundo_grado()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, x1 = 0, x2 = 0;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);

                double raizint = Math.Pow(b, 2) - 4 * (a * c);
                if(raizint < 0) { MessageBox.Show("Error, el resultado dentro de la raiz es negativo");
                    label7.Text = "Error";
                    label8.Text = "Error";
                }
                else
                {
                    x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * (a * c))) / (2 * a);
                    x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * (a * c))) / (2 * a);
                    if(x1==x2){ label7.Text = Convert.ToString(x1); }
                else
                    { label7.Text = Convert.ToString(x1);
                        label8.Text = Convert.ToString(x2);
                    }
                }

            }
            catch
            { MessageBox.Show("Introduzca los valores solicitados"); }
        }
    }
}
