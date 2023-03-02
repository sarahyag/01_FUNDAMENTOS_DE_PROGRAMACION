using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaNotaDeVenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declarar variables
            Double PA1, PA2, PA3, PA4, PA5, Subtotal, IVA, Total;
            //Entrada
            PA1 = System.Double.Parse(txtPA1.Text);
            PA2 = System.Double.Parse(txtPA2.Text);
            PA3 = System.Double.Parse(txtPA3.Text);
            PA4 = System.Double.Parse(txtPA4.Text);
            PA5 = System.Double.Parse(txtPA5.Text);
            //Proceso
            Subtotal = PA1 + PA2 + PA3 + PA4 + PA5;
            IVA = Subtotal * 0.08;
            Total = Subtotal + IVA;
            //Salida
            txtSubtotal.Text = Subtotal.ToString();
            txtIVA.Text = IVA.ToString();
            txtTotal.Text = Total.ToString();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNA1.Clear();
            txtNA2.Clear();
            txtNA3.Clear();
            txtNA4.Clear();
            txtNA5.Clear();
            txtPA1.Clear();
            txtPA2.Clear();
            txtPA3.Clear();
            txtPA4.Clear();
            txtPA5.Clear();
            txtSubtotal.Clear();
            txtTotal.Clear();
            txtIVA.Clear();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
