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

namespace Matriz_Numerica_Vectores
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
            int r, c, s1 = 0, s2 = 0, s3 = 0, s4 = 0, s5 = 0, s6 = 0, s7 = 0, s8 = 0, s9 = 0, s10 = 0, s11 = 0, p1, p2;

            //declaracion de la matriz
            Random num = new Random();
            int[,] numeros = new int[6, 5];

            //ciclo for para el despliegue de la matriz
            for (r = 0; r < 6; r++)
            {
                for (c = 0; c < 5; c++)
                {
                    numeros[r, c] = num.Next(0, 100);
                    txt_matriz.Text += numeros[r, c].ToString() + "\t";
                }
                txt_matriz.Text += "\r\n";
            }

            //ciclo for para la suma de los renglones
            for (r = 0; r < 5; r++)
            {
                s1 += numeros[0, r];
                s2 += numeros[1, r];
                s3 += numeros[2, r];
                s4 += numeros[3, r];
                s5 += numeros[4, r];
                s6 += numeros[5, r];
            }

            //ciclo for para la suma de las columnas
            for (c = 0; c < 6; c++)
            {
                s7 += numeros[c, 0];
                s8 += numeros[c, 1];
                s9 += numeros[c, 2];
                s10 += numeros[c, 3];
                s11 += numeros[c, 4];
            }

            //declaracion y despliegue del vector de la suma de renglones
            int[] suma_renglones = new int[6] { s1, s2, s3, s4, s5, s6 };
            for (p1 = 0; p1 < 6; p1++)
            {
                txt_vector_renglones.Text += suma_renglones[p1] + "\t";
            }

            //declaracion y despliegue del vector de la suma de columnas
            int[] suma_columnas = new int[5] { s7, s8, s9, s10, s11 };
            for (p2 = 0; p2 < 5; p2++)
            {
                txt_vector_columnas.Text += suma_columnas[p2] + "\t";
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