using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayor_3_numeros
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
            int n1, n2, n3;

            //entrada de datos
            n1 = System.Int16.Parse(txtn1.Text);
            n2 = System.Int16.Parse(txtn2.Text);
            n3 = System.Int16.Parse(txtn3.Text);

            //proceso, comparacion y salida
            if (n1 == n2 && n2 == n3)
                txtresultado.Text = " Todos los numeros ingresados son iguales ".ToString();
            else if (n1 > n2 && n2 > n3)
                txtresultado.Text = n1 + " es el numero mayor ".ToString();
            else if (n2 > n1 && n1 > n3)
                txtresultado.Text = n2 + " es el numero mayor ".ToString();
            else
                txtresultado.Text = n3 + " es el numero mayor ".ToString();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtn1.Clear();
            txtn2.Clear();
            txtn3.Clear();
            txtresultado.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
