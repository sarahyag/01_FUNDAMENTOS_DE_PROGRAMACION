using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica___Boleta__promedio_y_acreditación
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
            //Declaracion de variables
            int C1, C2, C3, C4, C5, C6, Promedio;
            string NA, NC, Nombre_Carrera, Semestre, NM1, NM2, NM3, NM4, NM5, NM6;

            //Entrada de datos
            C1 = System.Int16.Parse(txtC1.Text);
            C2 = System.Int16.Parse(txtC2.Text);
            C3 = System.Int16.Parse(txtC3.Text);
            C4 = System.Int16.Parse(txtC4.Text);
            C5 = System.Int16.Parse(txtC5.Text);
            C6 = System.Int16.Parse(txtC6.Text);
            NA = txtNA.Text;
            NC = txtNC.Text;
            Nombre_Carrera = txtNombre_Carrera.Text;
            Semestre = txtNS.Text;
            NM1 = txtNM1.Text;
            NM2 = txtNM2.Text;
            NM3 = txtNM3.Text;
            NM4 = txtNM4.Text;
            NM5 = txtNM5.Text;
            NM6 = txtNM6.Text;

            //Proceso
            Promedio = ((C1 + C2 + C3 + C4 + C5 + C6) / 6);
            txtPromedio.Text = Promedio.ToString();

            //Decision
            {
                if (Promedio >= 70)
                    txtEstado_Semestre.Text = " Semestre aprobado ".ToString();
                else
                    txtEstado_Semestre.Text = " Semestre reprobado ".ToString();

                if (Promedio >= 70)
                    txtResultado.Text = " Alumn@ " + NA +  " con el número de control de " + NC + ", tiene un promedio de " + Promedio + " y un semestre aprobado ";
                else
                    txtResultado.Text = " Alumn@ " + NA + " con el número de control de " + NC + ", tiene un promedio de " + Promedio + " y un semestre reprobado ";

            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtC1.Clear();
            txtC2.Clear();
            txtC3.Clear();
            txtC4.Clear();
            txtC5.Clear();
            txtC6.Clear();
            txtResultado.Clear();
            txtEstado_Semestre.Clear();
            txtNombre_Carrera.Clear();
            txtNS.Clear();
            txtPromedio.Clear();
            txtResultado.Clear();
            txtNM1.Clear();
            txtNM2.Clear();
            txtNM3.Clear();
            txtNM4.Clear();
            txtNM5.Clear();
            txtNM6.Clear();
            txtNA.Clear();
            txtNC.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
