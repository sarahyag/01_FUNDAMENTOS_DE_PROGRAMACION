using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaBoletaPromedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            Int16 C1, C2, C3, C4, C5, C6, Promedio;
            string NA, NC, Nombre_carrera, NM1, NM2, NM3, NM4, NM5, NM6, Numero_Semestre;

            //Entrada
            C1 = System.Int16.Parse(txtC1.Text);
            C2 = System.Int16.Parse(txtC2.Text);
            C3 = System.Int16.Parse(txtC3.Text);
            C4 = System.Int16.Parse(txtC4.Text);
            C1 = System.Int16.Parse(txtC1.Text);
            C5 = System.Int16.Parse(txtC5.Text);
            C6 = System.Int16.Parse(txtC6.Text);
            NA = txtNA.Text;
            NC = txtNC.Text;
            Nombre_carrera = txtCarrera.Text;
            NM1 = txtNM1.Text;
            NM2 = txtNM2.Text;
            NM3 = txtNM3.Text;
            NM4 = txtNM4.Text;
            NM5 = txtNM5.Text;
            NM6 = txtNM6.Text;
            Numero_Semestre = txtSemestre.Text;

            //Proceso
            Promedio = (short)((C1 + C2 + C3 + C4 + C5 + C6) / 6);

            //Comparacion 
            if (Promedio >= 7)
                txtestado.Text = " El estado del semestre es aprobatorio, con el promedio de " + Promedio.ToString();
            else
                txtestado.Text = " El estado del semestre es reprobado, con el promedio de " + Promedio.ToString();

            //Salida
            txtPromedio.Text = Promedio.ToString();


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNC.Clear();
            txtNA.Clear();
            txtCarrera.Clear();
            txtC1.Clear();
            txtC2.Clear();
            txtC3.Clear(); 
            txtC4.Clear();
            txtC5.Clear();
            txtC6.Clear();
            txtNM1.Clear();
            txtNM2.Clear();
            txtNM3.Clear();
            txtNM4.Clear();
            txtNM5.Clear();
            txtNM6.Clear();
            txtPromedio.Clear();
            txtSemestre.Clear();
          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
