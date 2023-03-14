using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 1 = Suma de 2 números, " + "2 = Mayor de 2 números, " + " 3 = Salir ");
        }

        private void btndesplegar_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            int n, n1, n2, suma;
            string mensaje = "";

            //entrada de datos
            n = System.Int16.Parse(txtnumero.Text);
            n1 = System.Int16.Parse(txtN1.Text);
            n2 = System.Int16.Parse(txtN2.Text);

            //proceso
            switch (n)
            {
                case 1:
                    suma = n1 + n2;
                    mensaje = " El resultado es " + suma;
                    break;
                case 2:
                    if (n1 > n2)
                        mensaje = n1 + " es el número mayor ";
                    else if (n1 == n2)
                        mensaje = n1 + " y " + n2 + " son números iguales ";
                    else
                        mensaje = n2 + " es el número mayor ";
                    break;
                case 3:
                    Close();
                    break;
                default:
                    mensaje = " Operación inválida, revise de nuevo el menú ";
                    break;
            }
            labelresultado.Text = mensaje;

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtnumero.Clear();
            labelresultado.Text = "";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
