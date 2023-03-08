using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica___Dígito_o_no_dígito
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
            N = System.Int16.Parse(txtN.Text);

            //Proceso
            if (N < 10 && N > 0)
                txtResultado.Text = N + " sí es un dígito ".ToString();
            else
                txtResultado.Text = N + " no es un dígito ".ToString();
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
