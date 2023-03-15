using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Salon_Metodo_Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdDesplegar_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            int dia;
            string mensaje = "";

            //entrada de datos
            dia = System.Int16.Parse(txtdia.Text);
            mensaje = lblMensaje.Text;

            //metodo switch
            switch (dia)
            {
                case 1:
                    mensaje = " Lunes ";
                    break;
                case 2:
                    mensaje = " Martes ";
                    break;
                case 3:
                    mensaje = " Miércoles ";
                    break;
                case 4:
                    mensaje = " Jueves ";
                    break;
                case 5:
                    mensaje = " Viernes ";
                    break;
                case 6:
                    mensaje = " Sábado ";
                    break;
                case 7:
                    mensaje = " Domingo ";
                    break;
                default:
                    mensaje = " Día erróneo ";
                    break;
            }
            lblMensaje.Text = mensaje;
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            txtdia.Clear();
            lblMensaje.Text = "";
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
