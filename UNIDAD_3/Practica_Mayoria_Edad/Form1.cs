using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica___Mayoría_de_edad
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
            int AA, AN, A;

            //Entrada de datos
            AA = System.Int16.Parse(txtAA.Text);
            AN = System.Int16.Parse(txtAN.Text);

            //Proceso
            A = (AA - AN);

            //Salida
            if (A >= 18)
                txtResultado.Text = " Eres mayor de edad, con la edad de " + A + " años ".ToString();
            else
                txtResultado.Text = " Eres menor de edad, con la edad de " + A + " años ".ToString();




        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAA.Clear();
            txtAN.Clear();
            txtResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
