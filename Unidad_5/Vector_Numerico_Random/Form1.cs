using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector_Numerico_Random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_desplegar_1_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            int r;
            int[] n;

            //generador de numeros aleatorios enteros
            Random num = new Random();
            n = new int[10];
            for (r = 0; r < 10; r++)
            {
                n[r] = num.Next(100);
                txt_vector_1.Text += n[r].ToString() + " \r\n";
            }
        }

        private void btn_desplegar_2_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            int r;

            //generador de numeros aleatorios enteros
            Random num = new Random();
            int[] n = new int[10];
            for (r = 0; r < 10; r++)
            {
                n[r] = num.Next(-50, 30);
                txt_vector_2.Text += n[r].ToString() + "\r\n";
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
