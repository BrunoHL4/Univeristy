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
    public partial class Area_de_un_rectangulo : Form
    {
        public Area_de_un_rectangulo()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double b= 0, a=0,  area;
            try
            {
                b = Convert.ToDouble(textBox2.Text); 
                a = Convert.ToDouble(textBox1.Text);
                area = b * a;
                label5.Text = Convert.ToString(area);
            }
            catch
            { MessageBox.Show("Debe proporcionar las medidas"); }
            
        }
    }
}
