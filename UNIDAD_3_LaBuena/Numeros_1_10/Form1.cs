﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_1_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            //Declaracion
            int N, S = 0;

            //Ciclo desplegar
            for (N=1; N<=10; N=N+1) 
            {
                txt_despliegue.Text = txt_despliegue.Text + N.ToString() + "\r\n";
                S = S + N;
                txt_suma.Text = S.ToString();
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_despliegue.Clear();
            txt_suma.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
