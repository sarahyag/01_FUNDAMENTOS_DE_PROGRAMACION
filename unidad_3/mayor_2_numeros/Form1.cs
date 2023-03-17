using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayor_2_numeros
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
            int n1, n2;

            //entrada de datos
            n1 = System.Int16.Parse(txtn1.Text);
            n2 = System.Int16.Parse(txtn2.Text);

            //proceso, comparacion y salida
            if (n1 == n2)
                txtresultado.Text = n1 + " y " + n2 + " son números iguales ";
            else if (n1 > n2)
                txtresultado.Text = n1 + " es el número mayor ";
            else
                txtresultado.Text = n2 + " es el número mayor ";
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtn1.Clear();
            txtn2.Clear();
            txtresultado.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
