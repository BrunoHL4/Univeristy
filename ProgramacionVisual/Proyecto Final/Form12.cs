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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double precio, precioFinal, IVA;

            precio = Convert.ToDouble(textBox1.Text);

            IVA = precio * 0.21;
            precioFinal = precio + IVA;

            label2.Text = Convert.ToString(precioFinal);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
