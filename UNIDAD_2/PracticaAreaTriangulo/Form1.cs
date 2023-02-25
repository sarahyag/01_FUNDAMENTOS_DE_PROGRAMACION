using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaAreaTriangulo
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
            Double Base, Altura, Area;
            //Entrada
            Base=System.Double.Parse(txtBase.Text);
            Altura = System.Double.Parse(txtAltura.Text);
            //Proceso
            Area = (Base * Altura) / 2;
            //Salida
            txtArea.Text=Area.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtArea.Clear();
            txtAltura.Clear();
            txtBase.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
