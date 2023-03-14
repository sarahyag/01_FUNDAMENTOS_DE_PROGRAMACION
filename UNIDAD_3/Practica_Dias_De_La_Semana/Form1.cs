using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Dias_De_La_Semana
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

            //entrada de datos
            dia = System.Int16.Parse(txtdia.Text);

            //proceso, condicion y salida
            if (dia == 1)
                labeldia.Text = " Lunes ";
            else if (dia == 2)
                labeldia.Text = " Martes ";
            else if (dia == 3)
                labeldia.Text = " Miércoles ";
            else if (dia == 4)
                labeldia.Text = " Jueves ";
            else if (dia == 5)
                labeldia.Text = " Viernes ";
            else if (dia == 6)
                labeldia.Text = " Sábado ";
            else if (dia == 7)
                labeldia.Text = " Domingo ";
            else
                labeldia.Text = " Día erróneo ";
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            txtdia.Clear();
            labeldia.Text = "";
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
