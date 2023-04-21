using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_1_10_Ciclo_While
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
            int n, s = 0;

            //ciclo while en el despliegue
            n = 1;
            while (n <= 10)
            {
                txt_despliegue.Text += n.ToString() + "\r\n";
                s = s + n;
                txt_sumatoria.Text = s.ToString();
                n++;
            }

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
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
