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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num;
            num = Convert.ToDouble(textBox1.Text);

            if (num == 0)
            {
                label2.Text = Convert.ToString("El número es cero");
            }
            else if (num % 2 == 0)
            {
                label2.Text = Convert.ToString("El número es par");
            }
            else
            {
                label2.Text = Convert.ToString("El número es impar");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
