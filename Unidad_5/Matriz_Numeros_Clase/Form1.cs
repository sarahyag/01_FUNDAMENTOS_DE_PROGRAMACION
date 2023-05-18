using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz_Numeros_Clase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            foreach (var txt in Controls)
            {
                if (txt is TextBox)
                    ((TextBox)txt).Clear();
            }
        }

        private void btn_desplegar_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            int r, c;

            //declaracion de la matriz
            int[,] numeros = new int[4, 3] { { 1, 2, 3 }, { 2, 4, 6 }, { 3, 6, 9 }, { 10, 30, 40 } };

            //ciclo for para el despliegue de la matriz
            for (r=0; r<4; r++)
            {
                for (c=0; c<3; c++)
                {
                    txt_matriz_numeros.Text += numeros[r, c].ToString() + "\t";
                }
                txt_matriz_numeros.Text += "\r\n";
            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
