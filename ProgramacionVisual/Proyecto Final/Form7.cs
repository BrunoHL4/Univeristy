﻿using System;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radio, sol;
            radio = Convert.ToDouble(textBox1.Text);
            sol = 2 * 3.1416 * radio;
            label2.Text = Convert.ToString(sol);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
