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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void áreaDeUnCuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 arectangulo = new Form2();
            arectangulo.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void äreaDeUnCirculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 acirculo = new Form3();
            acirculo.Show();
        }

        private void triánguloRectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 triangulo = new Form4();
            triangulo.Show();
        }

        private void númeroCapícuoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 media = new Form6();
            media.Show();
        }

        private void deNúmeroATextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 suma = new Form5();
            suma.Show();
        }

        private void conversiónABinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 longitud = new Form7();
            longitud.Show();
        }

        private void unidadesYDecenasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 unidades = new Form8();
            unidades.Show();
        }

        private void descomponerEnFactoresPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 paralele = new Form9();
            paralele.Show();
        }

        private void vocalesEnUnaFraseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 par = new Form10();
            par.Show();
        }

        private void fechaActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 km = new Form11();
            km.Show();
        }

        private void sumaDeNúmerosComplejosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 IVA = new Form12();
            IVA.Show();
        }

        private void operacionesAritméticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 tabla = new Form13();
            tabla.Show();
        }

        private void tablaDeMultiplicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 promedio = new Form14();
            promedio.Show();
        }

        private void promedioDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 positivo = new Form15();
            positivo.Show();
        }

        private void sumaDeFactorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form16 conversion = new Form16();
            conversion.Show();
        }
    }
}
