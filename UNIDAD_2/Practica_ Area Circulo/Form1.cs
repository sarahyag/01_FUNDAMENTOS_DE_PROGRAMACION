using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaAreaCirculo
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declarar variables
            Double R, Area;
            //Entrada
            R = System.Double.Parse(txtRadio.Text);
            //Proceso
            Area = 3.1416 * (R * R);
            //Salida
            txtArea.Text = Area.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtArea.Clear();
            txtRadio.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
