namespace PracticaNotaDeVenta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelRFC = new System.Windows.Forms.Label();
            this.labelDIRECCION = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelArticulos = new System.Windows.Forms.Label();
            this.labelIVA = new System.Windows.Forms.Label();
            this.labelPrecios = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.txtNA1 = new System.Windows.Forms.TextBox();
            this.txtNA2 = new System.Windows.Forms.TextBox();
            this.txtNA3 = new System.Windows.Forms.TextBox();
            this.txtNA5 = new System.Windows.Forms.TextBox();
            this.txtNA4 = new System.Windows.Forms.TextBox();
            this.txtPA1 = new System.Windows.Forms.TextBox();
            this.txtPA2 = new System.Windows.Forms.TextBox();
            this.txtPA3 = new System.Windows.Forms.TextBox();
            this.txtPA4 = new System.Windows.Forms.TextBox();
            this.txtPA5 = new System.Windows.Forms.TextBox();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(303, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(198, 25);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Nombre de tienda";
            // 
            // labelRFC
            // 
            this.labelRFC.AutoSize = true;
            this.labelRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRFC.Location = new System.Drawing.Point(274, 54);
            this.labelRFC.Name = "labelRFC";
            this.labelRFC.Size = new System.Drawing.Size(48, 24);
            this.labelRFC.TabIndex = 1;
            this.labelRFC.Text = "RFC";
            // 
            // labelDIRECCION
            // 
            this.labelDIRECCION.AutoSize = true;
            this.labelDIRECCION.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDIRECCION.Location = new System.Drawing.Point(274, 78);
            this.labelDIRECCION.Name = "labelDIRECCION";
            this.labelDIRECCION.Size = new System.Drawing.Size(90, 24);
            this.labelDIRECCION.TabIndex = 2;
            this.labelDIRECCION.Text = "Dirección";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(274, 102);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(64, 24);
            this.labelFecha.TabIndex = 3;
            this.labelFecha.Text = "Fecha";
            // 
            // labelArticulos
            // 
            this.labelArticulos.AutoSize = true;
            this.labelArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArticulos.Location = new System.Drawing.Point(193, 150);
            this.labelArticulos.Name = "labelArticulos";
            this.labelArticulos.Size = new System.Drawing.Size(171, 24);
            this.labelArticulos.TabIndex = 4;
            this.labelArticulos.Text = "Nombre de artículo";
            // 
            // labelIVA
            // 
            this.labelIVA.AutoSize = true;
            this.labelIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIVA.Location = new System.Drawing.Point(277, 359);
            this.labelIVA.Name = "labelIVA";
            this.labelIVA.Size = new System.Drawing.Size(45, 24);
            this.labelIVA.TabIndex = 5;
            this.labelIVA.Text = "IVA:";
            // 
            // labelPrecios
            // 
            this.labelPrecios.AutoSize = true;
            this.labelPrecios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecios.Location = new System.Drawing.Point(470, 150);
            this.labelPrecios.Name = "labelPrecios";
            this.labelPrecios.Size = new System.Drawing.Size(64, 24);
            this.labelPrecios.TabIndex = 6;
            this.labelPrecios.Text = "Precio";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(274, 383);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(56, 24);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "Total:";
            // 
            // txtNA1
            // 
            this.txtNA1.Location = new System.Drawing.Point(197, 189);
            this.txtNA1.Name = "txtNA1";
            this.txtNA1.Size = new System.Drawing.Size(167, 20);
            this.txtNA1.TabIndex = 8;
            this.txtNA1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNA2
            // 
            this.txtNA2.Location = new System.Drawing.Point(197, 215);
            this.txtNA2.Name = "txtNA2";
            this.txtNA2.Size = new System.Drawing.Size(167, 20);
            this.txtNA2.TabIndex = 9;
            // 
            // txtNA3
            // 
            this.txtNA3.Location = new System.Drawing.Point(197, 241);
            this.txtNA3.Name = "txtNA3";
            this.txtNA3.Size = new System.Drawing.Size(167, 20);
            this.txtNA3.TabIndex = 10;
            // 
            // txtNA5
            // 
            this.txtNA5.Location = new System.Drawing.Point(197, 293);
            this.txtNA5.Name = "txtNA5";
            this.txtNA5.Size = new System.Drawing.Size(167, 20);
            this.txtNA5.TabIndex = 11;
            // 
            // txtNA4
            // 
            this.txtNA4.Location = new System.Drawing.Point(197, 267);
            this.txtNA4.Name = "txtNA4";
            this.txtNA4.Size = new System.Drawing.Size(167, 20);
            this.txtNA4.TabIndex = 12;
            // 
            // txtPA1
            // 
            this.txtPA1.Location = new System.Drawing.Point(418, 189);
            this.txtPA1.Name = "txtPA1";
            this.txtPA1.Size = new System.Drawing.Size(167, 20);
            this.txtPA1.TabIndex = 13;
            this.txtPA1.Text = "0";
            this.txtPA1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPA2
            // 
            this.txtPA2.Location = new System.Drawing.Point(418, 215);
            this.txtPA2.Name = "txtPA2";
            this.txtPA2.Size = new System.Drawing.Size(167, 20);
            this.txtPA2.TabIndex = 14;
            this.txtPA2.Text = "0";
            this.txtPA2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPA3
            // 
            this.txtPA3.Location = new System.Drawing.Point(418, 241);
            this.txtPA3.Name = "txtPA3";
            this.txtPA3.Size = new System.Drawing.Size(167, 20);
            this.txtPA3.TabIndex = 15;
            this.txtPA3.Text = "0";
            this.txtPA3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPA4
            // 
            this.txtPA4.Location = new System.Drawing.Point(418, 267);
            this.txtPA4.Name = "txtPA4";
            this.txtPA4.Size = new System.Drawing.Size(167, 20);
            this.txtPA4.TabIndex = 16;
            this.txtPA4.Text = "0";
            this.txtPA4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPA5
            // 
            this.txtPA5.Location = new System.Drawing.Point(418, 293);
            this.txtPA5.Name = "txtPA5";
            this.txtPA5.Size = new System.Drawing.Size(167, 20);
            this.txtPA5.TabIndex = 17;
            this.txtPA5.Text = "0";
            this.txtPA5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotal.Location = new System.Drawing.Point(274, 335);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(82, 24);
            this.labelSubtotal.TabIndex = 18;
            this.labelSubtotal.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSubtotal.Location = new System.Drawing.Point(418, 335);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(167, 20);
            this.txtSubtotal.TabIndex = 19;
            this.txtSubtotal.Text = "0";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIVA
            // 
            this.txtIVA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtIVA.Location = new System.Drawing.Point(418, 364);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(167, 20);
            this.txtIVA.TabIndex = 20;
            this.txtIVA.Text = "0";
            this.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotal.Location = new System.Drawing.Point(418, 390);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(167, 20);
            this.txtTotal.TabIndex = 21;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(197, 446);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(96, 30);
            this.btnCalcular.TabIndex = 22;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(313, 446);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(162, 30);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar valores";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(489, 446);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 30);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.txtPA5);
            this.Controls.Add(this.txtPA4);
            this.Controls.Add(this.txtPA3);
            this.Controls.Add(this.txtPA2);
            this.Controls.Add(this.txtPA1);
            this.Controls.Add(this.txtNA4);
            this.Controls.Add(this.txtNA5);
            this.Controls.Add(this.txtNA3);
            this.Controls.Add(this.txtNA2);
            this.Controls.Add(this.txtNA1);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelPrecios);
            this.Controls.Add(this.labelIVA);
            this.Controls.Add(this.labelArticulos);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelDIRECCION);
            this.Controls.Add(this.labelRFC);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelRFC;
        private System.Windows.Forms.Label labelDIRECCION;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelArticulos;
        private System.Windows.Forms.Label labelIVA;
        private System.Windows.Forms.Label labelPrecios;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox txtNA1;
        private System.Windows.Forms.TextBox txtNA2;
        private System.Windows.Forms.TextBox txtNA3;
        private System.Windows.Forms.TextBox txtNA5;
        private System.Windows.Forms.TextBox txtNA4;
        private System.Windows.Forms.TextBox txtPA1;
        private System.Windows.Forms.TextBox txtPA2;
        private System.Windows.Forms.TextBox txtPA3;
        private System.Windows.Forms.TextBox txtPA4;
        private System.Windows.Forms.TextBox txtPA5;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

