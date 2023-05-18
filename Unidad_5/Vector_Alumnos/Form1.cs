using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector_Alumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_desplegar_Click(object sender, EventArgs e)
        {

            //declaracion de variables
            int p;
            int prom1;
            int prom2;
            int prom3;
            int prom4;
            int prom5;
            int prom6;
            int prom7;
            int prom8;
            int prom9;
            int prom10;
            int promedio_grupal;
            int prom_mayor;


            //declaracion del arreglo
            string[] nombres = new string[10] { "Sarahy", "Liliana", "Kevin", "Miguel", "Jose", "Agustin", "Roy", "Enrique", "Danna", "David" };
            string[] no_control = new string[10] { "111", "112", "113", "114", "115", "116", "117", "118", "119", "120" };
            string[] carrera = new string[10] { "ISC", "ISC", "ISC", "ISC", "ISC", "ISC", "ISC", "ISC", "ISC", "ISC" };
            int[] FP = new int[10] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            int[] Etica = new int[10] { 10, 9, 10, 10, 9, 10, 9, 8, 10, 9 };
            int[] MD = new int[10] { 10, 9, 0, 10, 0, 0, 0, 0, 0, 10 };
            int[] Admin = new int[10] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            int[] FI = new int[10] { 10, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] Calculo = new int[10] { 10, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            
            //despliegue del vector
            for (p=0; p<10; p++)
            {
                txt_vector_nombres.Text += nombres[p] + "\r\n";
                txt_vector_numero_control.Text += no_control[p] + "\r\n";
                txt_vector_carrera.Text += carrera[p] + "\r\n";
                txt_vector_fundamentos_programacion.Text += FP[p] + "\r\n";
                txt_vector_etica.Text += Etica[p] + "\r\n";
                txt_vector_matematicas_discretas.Text += MD[p] + "\r\n";
                txt_vector_administracion.Text += Admin[p] + "\r\n";
                txt_investigacion.Text += FI[p] + "\r\n";
                txt_vector_calculo.Text += Calculo[p] + "\r\n";
            }

            //calculo de promedios
            prom1 = (FP[0] + Etica[0] + MD[0] + Admin[0] + FI[0] + Calculo[0]) / 6;
            prom2 = (FP[1] + Etica[1] + MD[1] + Admin[1] + FI[1] + Calculo[1]) / 6;
            prom3 = (FP[2] + Etica[2] + MD[2] + Admin[2] + FI[2] + Calculo[2]) / 6;
            prom4 = (FP[3] + Etica[3] + MD[3] + Admin[3] + FI[3] + Calculo[3]) / 6;
            prom5 = (FP[4] + Etica[4] + MD[4] + Admin[4] + FI[4] + Calculo[4]) / 6;
            prom6 = (FP[5] + Etica[5] + MD[5] + Admin[5] + FI[5] + Calculo[5]) / 6;
            prom7 = (FP[6] + Etica[6] + MD[6] + Admin[6] + FI[6] + Calculo[6]) / 6;
            prom8 = (FP[7] + Etica[7] + MD[7] + Admin[7] + FI[7] + Calculo[7]) / 6;
            prom9 = (FP[8] + Etica[8] + MD[8] + Admin[8] + FI[8] + Calculo[8]) / 6;
            prom10 = (FP[9] + Etica[9] + MD[9] + Admin[9] + FI[9] + Calculo[9]) / 6;
            int[] Promedio = new int[10] {prom1, prom2, prom3, prom4, prom5, prom6, prom7, prom8, prom9, prom10};

            //despliegue del vector de promedios individuales
            for (p = 0; p < 10; p++)
            {
                txt_vector_promedio.Text += Promedio[p] + "\r\n";

            }

            //calculo del promedio grupal y su despliegue
            promedio_grupal = (prom1 + prom2 + prom3 + prom4 + prom5 + prom6 + prom7 + prom8 + prom9 + prom10) / 10;
            txt_promedio_grupal.Text = promedio_grupal.ToString();

            //despliegue del alumno con mayor calificacion
            prom_mayor = prom1;
            if (prom1<=prom2)
            {
                prom2=prom_mayor;
            }

            if (prom2 <= prom3)
            {
                prom3 = prom_mayor;
            }

            if (prom3 <= prom4)
            {
                prom4 = prom_mayor;
            }

            if (prom4 <= prom5)
            {
                prom5 = prom_mayor;
            }

            if (prom5 <= prom6)
            {
                prom6 = prom_mayor;
            }

            if (prom6 <= prom7)
            {
                prom7 = prom_mayor;
            }

            if (prom7 <= prom8)
            {
                prom8 = prom_mayor;
            }

            if (prom8 <= prom9)
            {
                prom9 = prom_mayor;
            }

            if (prom9 <= prom10)
            {
                prom10 = prom_mayor;
            }

            if (prom1==prom_mayor)
            {
                txt_alumno_mayor_promedio.Text = nombres[0] + " con el numero de control " + no_control[0] + " y de la carrera " + carrera[0] + " con las calificaciones " + FP[0] + "," + Etica[0] + "," + MD[0] + "," + Admin[0] + "," + FI[0] + "," + Calculo[0] + " y el promedio final de " + prom1;
            }
            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            foreach (var txt in Controls)
            {
                if (txt is TextBox)
                    ((TextBox)txt).Clear();
            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
