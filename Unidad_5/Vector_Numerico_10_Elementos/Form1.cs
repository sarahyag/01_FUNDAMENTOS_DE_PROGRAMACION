using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector_Numerico_10_Elementos
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
            int p, s = 0, pm;

            //declaracion del arreglo
            int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //despliegue del vector
            for (p=0; p<10;  p++)
            {
                txt_vector.Text += numeros[p] + "\r\n";

                //suma de los elementos
                {
                    s += numeros[p];
                    txt_suma_elementos.Text = s.ToString();
                }

                //elemento del medio
                {
                    pm = 10 / 2;
                    txt_elemento_medio.Text = numeros[pm].ToString();
                }
            }
            txt_ultimo_elemento.Text = numeros[9].ToString();
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
