using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica___Nota_de_venta_e_impuesto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            double PA1, PA2, PA3, PA4, PA5, Subtotal, IVA, Total;
            string NT, Direccion, Fecha, NA1, NA2, NA3, NA4, NA5;

            //Entrada de datos
            PA1 = System.Double.Parse(txtPA1.Text);
            PA2 = System.Double.Parse(txtPA2.Text);
            PA3 = System.Double.Parse(txtPA3.Text);
            PA4 = System.Double.Parse(txtPA4.Text);
            PA5 = System.Double.Parse(txtPA5.Text);
            NT = txtNombre_Tienda.Text;
            Direccion = txtDireccion.Text;
            Fecha = txtFecha_Venta.Text;
            NA1 = txtNA1.Text;
            NA2 = txtNA2.Text;
            NA3 = txtNA3.Text;
            NA4 = txtNA4.Text;
            NA5 = txtNA5.Text;

            //Proceso
            Subtotal = (PA1+PA2+PA3+PA4+PA5);
            if (Subtotal >= 520)
            {
                IVA = Subtotal * 0.05;
                Total = Subtotal + IVA;
                txtIVA.Text = IVA.ToString();
                txtSubtotal.Text = Subtotal.ToString();
                txtTotal.Text = " El total de la venta es " + Total.ToString();
            }
            else
            {
                IVA = Subtotal * 0.08;
                Total = Subtotal + IVA;
                txtIVA.Text = IVA.ToString();
                txtSubtotal.Text = Subtotal.ToString();
                txtTotal.Text = " El total de la venta es " + Total.ToString();
            }
            
            //Salida
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre_Tienda.Clear();
            txtDireccion.Clear();
            txtFecha_Venta.Clear();
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
            txtIVA.Clear();
            txtSubtotal.Clear();
            txtTotal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
