using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_20_50_Ciclo_While
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
            int n, s1=0, s2=0;

            //ciclo while en el despliegue
            n = 20;
            while (n <= 50)
            {
                //ciclo del despliegue de numeros
                {
                    txt_despliegue.Text += n.ToString() + "\r\n";
                }

                //ciclo de los numeros pares e impares
                {
                    if (n % 2 == 0)
                    {
                        txt_pares.Text += n.ToString() + "\r\n";
                        s1 = s1 + n;
                        txt_suma_pares.Text = s1.ToString();
                    }
                    else if (n % 2 == 1)
                    {
                        txt_impares.Text += n.ToString() + "\r\n";
                        s2 = s2 + n;
                        txt_suma_impares.Text = s2.ToString();
                    }
                    if (s1 > s2)
                    {
                        txt_mayor.Text = " La suma de pares es la mayor con " + s1.ToString();
                    }
                    else
                        txt_mayor.Text = " La suma de impares es la mayor con " + s2.ToString();
                }
                n++;
            }
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
