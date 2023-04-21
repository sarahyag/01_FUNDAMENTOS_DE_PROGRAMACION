using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_30_50_Ciclo_For
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

            //ciclo for del despliegue de numeros de forma ascendente
            for (n = 30; n <= 50; n++)
            {
                txt_ascendente.Text += n.ToString() + "\r\n";
            }

            //ciclo for del despliegue de numeros de forma descendente
            for (n = 50; n >= 30; n--)
            {
                txt_descendente.Text += n.ToString() + "\r\n";
            }

            //ciclo for del despliegue de multiplos de 3
            for (n = 30; n <= 50; n += 3)
            {
                txt_multiplos_3.Text += n.ToString() + "\r\n";
                s = s + n;
                txt_suma.Text = s.ToString();
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
