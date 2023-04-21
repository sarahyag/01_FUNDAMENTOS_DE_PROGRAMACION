using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros__20_20_Ciclo_For
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

            //ciclo for en el despliegue de numeros
            for (n = -20; n <= 20; n++)
            {
                txt_despliegue.Text += n.ToString() + "\r\n";
            }

            //ciclo for en el despliegue de la suma
            for (n = -20; n <= 20; n++)
            {
                s = s + n;
                txt_suma.Text = s.ToString();
            }

            //ciclo for en el despliegue de los numeros positivos
            for (n = -20; n <= 20; n++)
            {
                txt_positivos.Text = n.ToString();
            }

            //ciclo for en el despliegue de los numeros negativos
            for (n = -20; n <= 20; n++)
            {
                txt_negativos.Text = n.ToString();
            }

            //ciclo for en el despliegue de los numeros pares
            for (n = -20; n <= 20; n++)
            {
                if (n % 2 == 0 && 0 == 0)
                {
                    txt_pares.Text = n.ToString();
                }
            }

            //ciclo for en el despliegue de los digitos
            for (n = -20; n <= 20; n++)
            {
                if (n <= 10)
                {
                    txt_digitos.Text = n.ToString();
                }
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
