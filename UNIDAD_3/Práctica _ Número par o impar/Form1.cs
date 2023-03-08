using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica___Número_par_o_impar
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
            int N;

            //Entrada de datos
            N=System.Int16.Parse(txtN.Text);

            //Proceso
            if (N % 2 == 0 && 0 == 0)
                txtResultado.Text = N + " es un número tipo par ".ToString();
            else
                txtResultado.Text = N + " es un número tipo impar ".ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
