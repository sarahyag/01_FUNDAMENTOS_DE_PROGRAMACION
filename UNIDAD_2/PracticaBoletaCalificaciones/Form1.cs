using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaBoletaCalificaciones
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
            Double C1, C2, C3, C4, C5, CPE, CTF, PC, PPE, PTF, PF;
            //Entrada
            C1 = System.Double.Parse(txtC1.Text);
            C2 = System.Double.Parse(txtC2.Text);
            C3 = System.Double.Parse(txtC3.Text);
            C4 = System.Double.Parse(txtC4.Text);
            C5 = System.Double.Parse(txtC5.Text);
            CPE = System.Double.Parse(txtCPE.Text);
            CTF = System.Double.Parse(txtCTF.Text);
            //Proceso
            PC = ((C1 + C2 + C3 + C4 + C5) / 5) * 6;
            PPE = (CPE) * 2;
            PTF = (CTF) * 2;
            PF = PC + PPE + PTF;
            //Salida
            txtPC.Text = PC.ToString();
            txtPPE.Text = PPE.ToString();
            txtPF.Text = PF.ToString();
            txtPTF.Text = PTF.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtC1.Clear();
            txtC2.Clear();
            txtC3.Clear();
            txtC4.Clear();
            txtC5.Clear();
            txtCPE.Clear();
            txtCTF.Clear();
            txtPC.Clear();
            txtPPE.Clear();
            txtPF.Clear();
            txtPTF.Clear();
            txtNA.Clear();
            txtNC.Clear();
            txtNombre_Carrera.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
