﻿using System;
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
    public partial class Año_bisiesto : Form
    {
        public Año_bisiesto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            try { a = Convert.ToInt32(textBox1.Text);
                if (a % 4 == 0 && (a % 100 != 0 || a % 400 == 0)) label2.Text = "El año es bisiesto";
                else label2.Text = "El año no es bisiesto";
            }
            catch
            { MessageBox.Show("Introduzca un año"); }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
