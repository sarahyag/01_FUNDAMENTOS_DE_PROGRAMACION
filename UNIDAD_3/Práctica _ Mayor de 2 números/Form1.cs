using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica___Mayor_de_2_números
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
            int N1, N2;

            //Entrada de datos
            N1 = System.Int16.Parse(txtN1.Text);
            N2 = System.Int16.Parse(txtN2.Text);

            //Proceso
            if (N1 > N2)
                txtResultado.Text = N1 + " es mayor que " + N2.ToString();
            else
                txtResultado.Text = N2 + " es mayor que " + N1.ToString();
            if (N1 == N2)
                txtResultado.Text = N1 + " y " + N2 + " son números iguales ".ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
