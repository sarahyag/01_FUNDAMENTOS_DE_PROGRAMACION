using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace positivo_negativo_neutro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            int n;

            //entrada de datos
            n = System.Int16.Parse(txtn.Text);

            //proceso, comparacion y salida
            if (n == 0)
                txtresultado.Text = n + " es un número neutro ";
            else if (n > 0)
                txtresultado.Text = n + " es un número positivo ";
            else
                txtresultado.Text = n + " es un número negativo "; 
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtn.Clear();
            txtresultado.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
