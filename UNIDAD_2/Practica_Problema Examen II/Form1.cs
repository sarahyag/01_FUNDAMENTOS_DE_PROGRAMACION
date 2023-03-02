using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Problema_Examen_II
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
            int a, b, x;
            int c = 3;

            //Entrada
            a= System.Int16.Parse(txta.Text);
            b= System.Int16.Parse(txtb.Text);

            //Proceso
            x = (12 * (a * (b * b)) - c);

            //Salida
            txtx.Text=x.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtb.Clear();
            txtx.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
