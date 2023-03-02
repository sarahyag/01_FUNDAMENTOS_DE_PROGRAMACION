using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaLibrasAKilos
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
            double libras, kilos;
            //Entrada
            libras=System.Double.Parse(txtLibras.Text);
            //Proceso
            kilos = libras * 0.45;
            //Salida
            txtKilos.Text = kilos.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtKilos.Clear();
            txtLibras.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
