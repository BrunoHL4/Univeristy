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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num, d, u;
            num = Convert.ToDouble(textBox1.Text);

            d = num / 10;
            u = num % 10;

            if (d > u)
                label2.Text = Convert.ToString("La decena es mayor que las unidades");
            if (d < u)
                label2.Text = Convert.ToString("La decena es menor que las unidades");
            if (d == u)
                label2.Text = Convert.ToString("Ambos digitos son iguales");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
