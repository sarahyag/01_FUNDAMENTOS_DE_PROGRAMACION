using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz_Numerica_Diagonales
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
            int r, c, s1 = 0, s2 = 0;

            //declaracion de la matriz
            Random num = new Random();
            int[,] numeros = new int[5, 5];

            //ciclo for para el despliegue
            for (r=0; r < 5; r++)
            {
                for (c = 0; c < 5; c++)
                {
                    numeros[r, c] = num.Next(0, 100);
                    txt_matriz.Text += numeros[r, c].ToString() + "\t";
                }
                txt_matriz.Text += "\r\n";
            }

            //suma de las diagonales
            for (r=0; r < 5; r++)
            {
                for (c=0; c < 5; c++)
                {
                    //suma de la diagonal principal
                    {
                        if (r == c)
                        {
                            s1 += numeros[r, c];
                        }
                        txt_suma_diagonal_principal.Text = s1.ToString();
                    }

                    //suma de la diagonal inversa
                    {
                        if (r + c == 4)
                        {
                            s2 += numeros[r, c];
                        }
                        txt_suma_diagonal_inversa.Text = s2.ToString();
                    }
                }
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
