using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_30_50_Ciclo_While
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

            //ciclo while del despliegue de numeros de forma aescendente
            n = 30;
            while (n <= 50)
            {
                txt_ascendente.Text += n.ToString() + "\r\n";
                n++;
            }

            //ciclo while del despliegue de numeros de forma descendente
            n = 50;
            while (n >= 30)
            {
                txt_descendente.Text += n.ToString() + "\r\n";
                n--;
            }

            //ciclo while del despliegue de multiplos de 3
            n = 30;
            while (n <= 50)
            {
                txt_multiplos_3.Text += n.ToString() + "\r\n";
                s = s + n;
                txt_suma.Text = s.ToString();
                n += 3;
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
