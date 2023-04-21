using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabla_Multiplicacion_Ciclo_Do_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_desplegar_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            double n, c, res;

            //entrada de valor n
            n = System.Double.Parse(txt_numero.Text);

            //ciclo do while
            c = 1;
            do
            {
                res = n * c;
                txt_tabla.Text += n.ToString() + " * " + c.ToString() + " = " + res.ToString() + "\r\n";
                c++;
            } while (c <= 10);

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            foreach (var txt in Controls)
            {
                if (txt is TextBox)
                    ((TextBox)txt).Clear();
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
