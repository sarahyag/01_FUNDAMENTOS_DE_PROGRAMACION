namespace PracticaPesosADolares
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
            this.labelPesos = new System.Windows.Forms.Label();
            this.labelTC = new System.Windows.Forms.Label();
            this.labelDolares = new System.Windows.Forms.Label();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtDolares = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(231, 18);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(283, 25);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Convertir pesos a dólares";
            // 
            // labelPesos
            // 
            this.labelPesos.AutoSize = true;
            this.labelPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesos.Location = new System.Drawing.Point(232, 75);
            this.labelPesos.Name = "labelPesos";
            this.labelPesos.Size = new System.Drawing.Size(57, 20);
            this.labelPesos.TabIndex = 1;
            this.labelPesos.Text = "Pesos:";
            // 
            // labelTC
            // 
            this.labelTC.AutoSize = true;
            this.labelTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTC.Location = new System.Drawing.Point(232, 107);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(120, 20);
            this.labelTC.TabIndex = 2;
            this.labelTC.Text = "Tipo de cambio:";
            // 
            // labelDolares
            // 
            this.labelDolares.AutoSize = true;
            this.labelDolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDolares.Location = new System.Drawing.Point(232, 139);
            this.labelDolares.Name = "labelDolares";
            this.labelDolares.Size = new System.Drawing.Size(68, 20);
            this.labelDolares.TabIndex = 3;
            this.labelDolares.Text = "Dólares:";
            // 
            // txtPesos
            // 
            this.txtPesos.Location = new System.Drawing.Point(358, 75);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(100, 20);
            this.txtPesos.TabIndex = 4;
            this.txtPesos.Text = "0";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(358, 107);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 5;
            this.txtTC.Text = "0";
            // 
            // txtDolares
            // 
            this.txtDolares.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDolares.Location = new System.Drawing.Point(358, 139);
            this.txtDolares.Name = "txtDolares";
            this.txtDolares.ReadOnly = true;
            this.txtDolares.Size = new System.Drawing.Size(100, 20);
            this.txtDolares.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(210, 195);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 26);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(315, 195);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(138, 26);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar valores";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(468, 195);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 26);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDolares);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtPesos);
            this.Controls.Add(this.labelDolares);
            this.Controls.Add(this.labelTC);
            this.Controls.Add(this.labelPesos);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelPesos;
        private System.Windows.Forms.Label labelTC;
        private System.Windows.Forms.Label labelDolares;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtDolares;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

