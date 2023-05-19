using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz_Numerica_Tarea
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
            int r, c, s = 0, numero_mayor = 0, numero_menor = 99999, posicion_menor_r, posicion_menor_c, posicion_mayor_r, posicion_mayor_c ;

            //declaracion de la matriz
            Random num = new Random();
            int[,] numeros = new int[5, 4];

            //ciclo for para el despliegue
            for (r=0; r<5; r++)
            {
                for (c=0; c<4; c++)
                {
                    numeros[r, c] = num.Next(0, 100);
                    txt_matriz.Text += numeros[r, c].ToString() + "\t";

                    //elemento del medio y su posicion (mayor)
                    {
                        if (numeros[2,c] > numero_mayor)
                        {
                            numero_mayor = numeros[2,c];
                            posicion_mayor_r = r;
                            posicion_mayor_c = c;
                            txt_elemento_mayor_renglon_medio.Text = numero_mayor.ToString();
                            txt_posicion_elemento_mayor_medio.Text = "[" + posicion_mayor_r + "," + posicion_mayor_c + "]".ToString();
                        }
                    }

                    //elemento menor de toda la matriz y su posicion
                    {
                        if (numeros[r,c] < numero_menor )
                        {
                            numero_menor = numeros[r, c];
                            posicion_menor_r = r;
                            posicion_menor_c = c;
                            txt_elemento_menor_matriz.Text = numero_menor.ToString();
                            txt_posicion_elemento_menor_matriz.Text = "[" + posicion_menor_r + "," + posicion_menor_c + "]".ToString();
                        }
                    }
                }
                txt_matriz.Text += "\r\n";
                
            }

            //suma de elementos del ultimo renglon
            {
                s = numeros[4, 0] + numeros[4, 1] + numeros[4, 2] + numeros[4, 3];
                txt_suma_elementos_ultimo_renglon.Text = s.ToString();
            }
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
