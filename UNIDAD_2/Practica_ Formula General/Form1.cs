using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            double a, b, c, x1, x2;

            //Entrada
            a = System.Double.Parse(txta.Text);
            b = System.Double.Parse(txtb.Text);
            c = System.Double.Parse(txtc.Text);

            //Proceso
            x1 = (-(b) + (Math.Sqrt((b * b) - (4 * a * c)))) / 2 * (a);
            x2 = (-(b) - (Math.Sqrt((b * b) - (4 * a * c)))) / 2 * (a);

            //Salida
            txtx1.Text = x1.ToString();
            txtx2.Text = x2.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtb.Clear();
            txtc.Clear();
            txtx1.Clear();
            txtx2.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
