using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector_Nombres
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
            int p, pm;

            //declaracion del arreglo para el vector
            string[] nombres = new string[5] { "Leticia", "Kevin", "Jose", "Liliana", "Sarahy" };

            //despliegue del vector
            for (p = 0; p < 5; p++)
            {
                txt_vector.Text += nombres[p] + "\r\n";
            }

            //despliegue de ultimo elemento y elemento del medio
            txt_ultimo_elemento.Text = nombres[4];
            pm = 5 / 2;
            txt_elemento_medio.Text = nombres[pm];

        }

        private void btn_reset_Click(object sender, EventArgs e)
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
