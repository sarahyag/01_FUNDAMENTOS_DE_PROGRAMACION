using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaPesosADolares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declarar variables
            Double Pesos, TC, Dolares;
            //Entrada
            Pesos = System.Double.Parse(txtPesos.Text);
            TC = System.Double.Parse(txtTC.Text);
            //Proceso
            Dolares = Pesos / TC;
            //Salida
            txtDolares.Text = Dolares.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDolares.Clear();
            txtPesos.Clear();
            txtTC.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
