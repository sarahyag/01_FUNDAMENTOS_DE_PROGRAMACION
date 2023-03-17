using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayor_menor_edad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            int aa, an, edad;
            string nombre = txtnombre.Text;

            //entrada de datos
            aa = System.Int16.Parse(txtaa.Text);
            an = System.Int16.Parse(txtan.Text);

            //proceso y salida
            edad = (aa - an);
            if (edad >= 18)
                txtresultado.Text = nombre + " es mayor de edad, con la edad de " + edad + " años ".ToString();
            else
                txtresultado.Text = nombre + " es menor de edad, con la edad de " + edad + " años ".ToString();



        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txtaa.Clear();
            txtan.Clear();
            txtresultado.Clear();
            txtnombre.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
