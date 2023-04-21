using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros__20_20_Ciclo_While
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
            int n, s = 0;

            //ciclo while del despliegue
            n = -20;
            while (n <= 20)
            {
                //ciclo del despliegue de numeros
                {
                    txt_despliegue.Text += n.ToString() + "\r\n";
                }

                //ciclo de la suma
                {
                    s = s + n;
                    txt_suma.Text = s.ToString();
                }

                //ciclo de los numeros positivos
                {
                    txt_positivos.Text = n.ToString();
                }

                //ciclo de los numeros negativos
                {
                    txt_negativos.Text = n.ToString();
                }

                //ciclo de los numeros par
                {
                    if (n % 2 == 0 && 0 == 0)
                    {
                        txt_pares.Text = n.ToString();
                    }
                }

                //ciclo de los digitos
                {
                    if (n <= 10)
                    {
                        txt_digitos.Text = n.ToString();
                    }
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
