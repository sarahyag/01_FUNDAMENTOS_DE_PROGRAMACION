using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaPromedioEdades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declarar variables
            int E1, E2, E3, Prom;
            //Entrada
            E1=System.Int16.Parse(txtE1.Text);
            E2=System.Int16.Parse(txtE2.Text);
            E3=System.Int16.Parse(txtE3.Text);
            //Proceso
            Prom = (E1 + E2 + E3) / 3;
            //Salida
            txtPromedio.Text=Prom.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtE1.Clear();
            txtE2.Clear();
            txtE3.Clear();
            txtPromedio.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
