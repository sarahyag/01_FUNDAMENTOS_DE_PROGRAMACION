using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_30_50
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

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            //Declaracion
            int n, s = 0;

            //Ciclo for y despliegue
            for (n=30; n<=50; n++)
            {
                txt_ascendente.Text += n.ToString() + "\r\n";
            }

            for (n=50; n>=30; n--)
            {
                txt_descendente.Text += n.ToString() + "\r\n";
            }

            for (n=30; n<=50; n+=3)
            {
                txt_multiplos.Text += n.ToString() + "\r\n";
                s = s + n;
                txt_suma.Text = s.ToString();
            }
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
