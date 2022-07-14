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
    public partial class Area_de_un_triangulo : Form
    {
        public Area_de_un_triangulo()
        {
            InitializeComponent();
        }

        private void Area_de_un_triangulo_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double b = 0, h= 0, area;
            try
            {
                b = Convert.ToDouble(textBox2.Text);
                h = Convert.ToDouble(textBox1.Text);
                area = (b * h) / 2;
                label5.Text = Convert.ToString(area);
            }
            catch
            { MessageBox.Show("Debe proporcionar las medidas"); }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
