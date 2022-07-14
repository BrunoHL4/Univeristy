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

    public partial class Compuertas_AND_y_OR : Form
    {
        public Compuertas_AND_y_OR()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true) label1.Text = "1";
            else label1.Text = "0";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true && checkBox5.Checked == true && checkBox6.Checked == true) label3.Text = "1";
            else label3.Text = "0";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true && checkBox5.Checked == true && checkBox6.Checked == true) label3.Text = "1";
            else label3.Text = "0";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true && checkBox5.Checked == true && checkBox6.Checked == true) label3.Text = "1";
            else label3.Text = "0";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true) label1.Text = "1";
            else label1.Text = "0";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true) label1.Text = "1";
            else label1.Text = "0";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void Compuertas_AND_y_OR_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }
    }
}
