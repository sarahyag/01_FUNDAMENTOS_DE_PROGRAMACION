using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_1_1_Ciclo_Do_While
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
            int c = 0, s=0;

            //ciclo do while
            do
            {
                c++;
                txt_numeros.Text += c.ToString() + "\r\n";
                s = s + c;
                txt_sumatoria.Text = s.ToString();
            }
            while (c < 10);
        }
    }
}
