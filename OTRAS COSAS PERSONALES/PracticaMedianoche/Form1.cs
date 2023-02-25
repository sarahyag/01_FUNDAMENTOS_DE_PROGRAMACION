using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaMedianoche
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            float PA1, PA2, PA3, PA4, PA5, SUBTOTAL, IVA, TOTAL;
            //Entrada
            PA1 = System.Single.Parse(txtPA1.Text);
            PA2 = System.Single.Parse(txtPA2.Text);
            PA3 = System.Single.Parse(txtPA3.Text);
            PA4 = System.Single.Parse(txtPA4.Text);
            PA5 = System.Single.Parse(txtPA5.Text);
            //Proceso
            SUBTOTAL = PA1 + PA2 + PA3 + PA4 + PA5;
            IVA = (float)(SUBTOTAL * 0.08);
            TOTAL = SUBTOTAL + IVA;
            //Salida
            txtSUB.Text=SUBTOTAL.ToString();
            txtIVA.Text=IVA.ToString();
            txtTOTAL.Text=TOTAL.ToString();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
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
            txtSUB.Clear();
            txtIVA.Clear();
            txtTOTAL.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
