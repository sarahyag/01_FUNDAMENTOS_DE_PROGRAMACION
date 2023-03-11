using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica___Mayor_de_3_números
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
            int N1, N2, N3;

            //Entrada de datos
            N1 = System.Int16.Parse(txtN1.Text);
            N2 = System.Int16.Parse(txtN2.Text);
            N3 = System.Int16.Parse(txtN3.Text);

            //Proceso
            if (N1 > N2 && N1 > N3)
                txtResultado.Text = N1 + " es el número mayor, mayor que " + N2 + " y " + N3.ToString();
            else if (N2 > N3 && N3 > N1)
                txtResultado.Text = N2 + " es el número mayor, mayor que " + N1 + " y " + N3.ToString();
            else if (N3 > N2 && N3 > N1)
                txtResultado.Text = N3 + " es el número mayor, mayor que " + N1 + " y " + N2.ToString();
            else if (N1==N2 && N2==N3)
                txtResultado.Text = " Todos los números son iguales ".ToString();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
