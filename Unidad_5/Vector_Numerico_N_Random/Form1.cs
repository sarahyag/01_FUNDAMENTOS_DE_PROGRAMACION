using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector_Numerico_N_Random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_despliegue_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            int r;
            int[] n;
            int numero;
            int s = 0;
            int posicion;

            //entrada del numero de elementos del vector
            numero = System.Int16.Parse(txt_numero_vectores.Text);

            //generador de aleatorios enteros
            Random num = new Random();
            n=new int[numero];
            for (r=0; r<numero; r++)
            {
                //despliegue del vector
                {
                    n[r] = num.Next(numero);
                    txt_vector.Text += n[r].ToString() + "\r\n";
                }

                //suma de los elementos del vector
                {
                    s = s + n[r];
                    txt_suma_elementos.Text=s.ToString();
                }

                //elemento mayor del vector
                {
                    int nm = n.Max();
                    txt_elemento_mayor.Text=nm.ToString();
                    if (n[r]>nm)
                    {
                        nm= n[r];
                        posicion = nm;
                        textBox1.Text += posicion.ToString();
                    }
                }     
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_elemento_mayor.Clear();
            txt_numero_vectores.Clear();
            txt_posicion_elemento_mayor.Clear();
            txt_suma_elementos.Clear();
            txt_vector.Clear();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
