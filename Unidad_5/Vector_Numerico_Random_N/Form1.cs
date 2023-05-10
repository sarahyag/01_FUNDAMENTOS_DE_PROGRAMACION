using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector_Numerico_Random_N
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_despliegue_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            int r;
            int[] n;
            int s = 0;
            int numero= System.Int16.Parse(txt_cantidad_elementos.Text);
            int nm=0;
            int pm=0;

            //generador de numeros aleatorios
            Random num = new Random();
            n = new int[numero];
            for (r= 0; r < numero; r++)
            {
                //despliegue del vector
                {
                    n[r] = num.Next(numero);
                    txt_vector.Text += n[r].ToString() + "\r\n";
                }

                //suma de los elementos
                {
                    s += n[r];
                    txt_suma.Text=s.ToString();
                }

                //elemento mayor y su posicion
                {
                    if (n[r] > nm)
                    {
                        nm = n.Max();
                        pm = r + 1;
                        txt_elemento_mayor.Text = nm.ToString();
                        txt_posicion_elemento_mayor.Text = pm.ToString();
                    }
                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_cantidad_elementos.Clear();
            txt_elemento_mayor.Clear();
            txt_posicion_elemento_mayor.Clear();
            txt_suma.Clear();
            txt_vector.Clear();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
