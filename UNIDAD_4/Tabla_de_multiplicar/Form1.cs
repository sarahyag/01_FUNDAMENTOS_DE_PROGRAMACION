using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabla_de_multiplicar
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
            double x, n, res;

            //entrada
            x=System.Double.Parse(txt_n.Text);

            //ciclo y desplegar
            for (n= 1; n<=10; n=n+1) 
            {
                res = x * n;
                txt_tabla.Text += x.ToString() + " * " + n.ToString() + " = " + res.ToString() + " \r\n ";
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            foreach (var txt in Controls)
                if (txt is TextBox) 
                    ((TextBox)txt).Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
