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
    public partial class Dolares_a_pesos : Form
    {
        public Dolares_a_pesos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valordolar, pesos, dlls;
            try
            {
                dlls = Convert.ToDouble(textBox1.Text);
                valordolar = Convert.ToDouble(textBox2.Text);
                pesos = dlls * valordolar;
                label4.Text = Convert.ToString(pesos);
            }
            catch
            { MessageBox.Show("Introduzca los datos solicitados"); }
        }
    }
}
