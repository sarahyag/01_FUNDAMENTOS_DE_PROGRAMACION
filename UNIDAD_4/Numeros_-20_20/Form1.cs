using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros__20_20
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
            int n, s = 0;

            //ciclo for
            for (n = -20; n <= 20; n++)
            {
                txt_numeros.Text += n.ToString() + "\r\n";
            }

            for (n = -20; n <= 20; n++)
            {
                s = s + n;
                txt_suma.Text = s.ToString();
            }

            for (n = -20; n <= 20; n++)
            {
                txt_positivos.Text = n.ToString();
            }

            for (n = -20; n <= 20; n++)
            {
                txt_negativos.Text = n.ToString();

            }

            for (n = -20; n <= 20; n++)
            {
                if (n % 2 == 0 && 0 == 0)
                {
                    txt_pares.Text = n.ToString();
                }
            }

            for (n = -20; n <= 20; n++)
            {
                if (n <= 10)
                    txt_digitos.Text = n.ToString();
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_suma.Clear();
            txt_positivos.Clear();
            txt_negativos.Clear();
            txt_pares.Clear();
            txt_digitos.Clear();
            txt_numeros.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
    
