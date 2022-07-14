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
    public partial class Cantidad_de_números_impares : Form
    {
        public Cantidad_de_números_impares()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Palindroma_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x, i;
            try
            {
                richTextBox1.Clear();
                x = Convert.ToInt32(textBox1.Text);
                for (i = 0; i < x; i ++)if((i%2)!=0) richTextBox1.AppendText(Convert.ToString(i) + "\n");


            }
            catch
            {
                MessageBox.Show("Introduce un número");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
