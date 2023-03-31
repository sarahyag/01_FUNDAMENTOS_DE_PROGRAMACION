using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_20_50_Ciclo_Do_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            int n = 20, s1 = 0, s2 = 0;

            //ciclo do while
            do
            {
                if (n % 2 == 0)
                {
                    txt_pares.Text += n.ToString() + " \r\n";
                    txt_suma_pares.Text = s1.ToString();
                    s1 = s1 + n;
                }
                else if (n % 2 == 1)
                {
                    txt_impares.Text += n.ToString() + " \r\n";
                    txt_suma_impares.Text = s2.ToString();
                    s2 = s2 + n;
                }
                txt_despliegue.Text += n.ToString() + " \r\n";
                n = n + 1;
            } while (n <= 50);
            if (s1 > s2)
                txt_mayor.Text = s1.ToString() + " es la suma mayor ";
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            foreach (var txt in Controls)
                if (txt is TextBox)
                    ((TextBox)txt).Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
