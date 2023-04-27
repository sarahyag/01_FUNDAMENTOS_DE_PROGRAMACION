using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valor_Inicial_Final_Ciclo_Do_While
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
            int n1, n2, s1 = 0, s2 = 0;

            //entrada de numeros inicio y final
            n1 = System.Int16.Parse(txt_valor_inicial.Text);
            n2 = System.Int16.Parse(txt_valor_final.Text);

            //ciclo
            do
            {
                //despliegue de todos los numeros y su suma
                {
                    txt_despliegue_todos.Text += n1.ToString() + "\r\n";
                    s1 = s1 + n1;
                    txt_suma_todos.Text = s1.ToString();
                }

                //despliegue de los numeros pares y su suma
                {
                    if (n1 % 2 == 0)
                    {
                        txt_despliegue_pares.Text += n1.ToString() + "\r\n";
                        s2 = s2 + n1;
                        txt_suma_pares.Text = s2.ToString();
                    }
                }
                n1++;
            } while (n1 <= n2);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            foreach (var txt in Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
