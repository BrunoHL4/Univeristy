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
    public partial class Coincidencia_de_un_numero : Form
    {
        public Coincidencia_de_un_numero()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, n4;
            try
            {
             n1 = Convert.ToInt32(textBox1.Text);
             n2= Convert.ToInt32(textBox2.Text);
             n3= Convert.ToInt32(textBox3.Text);
             n4= Convert.ToInt32(textBox4.Text);
            if((n1==n4)||(n2==n4)||(n3==n4))
                { label6.Text = "El 4to número coincide con uno de los números anteriores"; }
            else { label6.Text = "El 4to número no coincide con ningun número anterior"; }
             }
            catch
            { MessageBox.Show("Introduzca los datos"); }
        
        }
    }
}
