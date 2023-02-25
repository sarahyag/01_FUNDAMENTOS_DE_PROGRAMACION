using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            // declarar
            double pa1 = 0;
            double pa2 = 0;
            double pa3 = 0;
            double pa4 = 0;
            double pa5 = 0;
            double subtotal = 0;
            double iva = 0;
            double total = 0;
            //entrada
            pa1=Double.Parse(textBox1.Text);
            pa2=Double.Parse(textBox2.Text);
            pa3=Double.Parse(textBox3.Text);
            pa4=Double.Parse(textBox4.Text);
            pa5=Double.Parse(textBox5.Text);
            //proceso
            subtotal=pa1+ pa2+ pa3+ pa4+ pa5;
            iva = subtotal * 0.08;
            total = subtotal + iva;
            //salida
            cosa.Text = subtotal.ToString();
            IVA.Text = iva.ToString();
            TOTAL.Text = total.ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BotonAparece_Click(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void OtraCosa_Click(object sender, EventArgs e)
        {

        }

        private void CalcularTotal()
        {
            // declarar
            double pa1 = 0;
            double pa2 = 0;
            double pa3 = 0;
            double pa4 = 0;
            double pa5 = 0;
            double subtotal = 0;
            double iva = 0;
            double total = 0;
            //entrada
            pa1 = Double.Parse(textBox1.Text);
            pa2 = Double.Parse(textBox2.Text);
            pa3 = Double.Parse(textBox3.Text);
            pa4 = Double.Parse(textBox4.Text);
            pa5 = Double.Parse(textBox5.Text);
            //proceso
            subtotal = pa1 + pa2 + pa3 + pa4 + pa5;
            iva = subtotal * 0.08;
            total = subtotal + iva;
            //salida
            cosa.Text = subtotal.ToString();
            IVA.Text = iva.ToString();
            TOTAL.Text = total.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }
    }
}
