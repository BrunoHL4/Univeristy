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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double notapractica, notateorica, notaparticipacion, notaFinal;

            notapractica = Convert.ToDouble(textBox1.Text);
            notateorica = Convert.ToDouble(textBox2.Text);
            notaparticipacion = Convert.ToDouble(textBox3.Text);

            notapractica = notapractica * 0.30;
            notateorica *= 0.60;
            notaparticipacion *= 0.10;

            notaFinal = notaparticipacion + notateorica + notapractica;

            label4.Text = Convert.ToString(notaFinal);



        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }
    }
}
