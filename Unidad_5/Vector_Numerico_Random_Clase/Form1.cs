using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector_Numerico_Random_Clase
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
            int p;
            int[] n;
            int s = 0;
            int numero = System.Int16.Parse(txt_numero_elementos.Text);
            int nm = 0;
            int pm=0;
            int np = 0;

            //generador de numeros aleatorios
            Random num = new Random();
            n = new int[numero];
            for (p = 0; p < numero; p++)
            {
                //despliegue del vector
                {
                    n[p] = num.Next(numero);
                    txt_vector.Text += n[p].ToString() + "\r\n";
                }

                //elemento menor y su posicion
                {
                    if (n[p] > nm)
                    {
                        nm = n.Min();
                        pm = p + 1;
                        txt_elemento_menor.Text = nm.ToString();
                        txt_posicion_elemento_menor.Text = pm.ToString();
                    }
                }

                //cantidad de numeros pares
                {
                    if (n[p] % 2 == 0)
                    {
                        txt_cantidad_numeros_pares.Text = np.ToString();
                    }
                }

                //suma de los digitos
                {
                    if (n[p] < 10)
                    {
                        s += n[p];
                        txt_suma_digitos.Text = s.ToString();
                    }
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_cantidad_numeros_pares.Clear();
            txt_elemento_menor.Clear();
            txt_numero_elementos.Clear();
            txt_posicion_elemento_menor.Clear();
            txt_suma_digitos.Clear();
            txt_vector.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
