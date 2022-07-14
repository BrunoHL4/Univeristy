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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double x, y, z, media;
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            z = Convert.ToDouble(textBox3.Text);
            media = (x + y + z) / 3;
            label4.Text = Convert.ToString(media);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
