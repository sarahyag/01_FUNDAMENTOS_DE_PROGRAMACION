using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_20_50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            //Declaracion
            int N, S1= 0, S2= 0;

            //Ciclo desplegar
            for (N=20; N<=50; N=N+1)
            {
                txt_despliegue.Text = txt_despliegue.Text + N.ToString() + "\r\n";
                if (N % 2 == 0)
                {
                    txt_pares.Text = txt_pares.Text + N.ToString() + "\r\n";
                    S1 = S1+N;
                    txt_suma_pares.Text = S1.ToString();
                }
                else if (N % 2 == 1)
                {
                    txt_impares.Text = txt_impares.Text + N.ToString() + "\r\n";
                    S2= S2+ N;
                    txt_suma_impares.Text= S2.ToString();
                }
                if (S1 > S2)
                {
                    txt_mayor.Text = " La primera sumatoria es mayor ";

                }
                else
                    txt_mayor.Text = " La segunda sumatoria es mayor ";
            }

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_despliegue.Clear();
            txt_pares.Clear();
            txt_impares.Clear();
            txt_mayor.Clear();
            txt_suma_impares.Clear();
            txt_suma_pares.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
