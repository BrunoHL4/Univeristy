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
    public partial class Area_de_un_circulo : Form
    {
        public Area_de_un_circulo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Radio = 0, area;
            try
            { Radio = Convert.ToDouble(textBox1.Text);
               area = Math.PI * Math.Pow(Radio, 2);
                label1.Text = Convert.ToString(area);
            }
            catch
            { MessageBox.Show("Debe proporcionar el radio"); }
           
        }

        private void Area_de_un_circulo_Load(object sender, EventArgs e)
        {

        }
    }
}
