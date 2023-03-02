namespace PracticaPromedioEdades
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
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.LabelE1 = new System.Windows.Forms.Label();
            this.LabelE2 = new System.Windows.Forms.Label();
            this.LabelE3 = new System.Windows.Forms.Label();
            this.LabelPromedio = new System.Windows.Forms.Label();
            this.txtE1 = new System.Windows.Forms.TextBox();
            this.txtE3 = new System.Windows.Forms.TextBox();
            this.txtE2 = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.Location = new System.Drawing.Point(357, 25);
            this.LabelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(304, 31);
            this.LabelTitulo.TabIndex = 0;
            this.LabelTitulo.Text = "Promedio de 3 edades";
            // 
            // LabelE1
            // 
            this.LabelE1.AutoSize = true;
            this.LabelE1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelE1.Location = new System.Drawing.Point(296, 107);
            this.LabelE1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelE1.Name = "LabelE1";
            this.LabelE1.Size = new System.Drawing.Size(80, 25);
            this.LabelE1.TabIndex = 1;
            this.LabelE1.Text = "Edad 1:";
            // 
            // LabelE2
            // 
            this.LabelE2.AutoSize = true;
            this.LabelE2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelE2.Location = new System.Drawing.Point(296, 143);
            this.LabelE2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelE2.Name = "LabelE2";
            this.LabelE2.Size = new System.Drawing.Size(80, 25);
            this.LabelE2.TabIndex = 2;
            this.LabelE2.Text = "Edad 2:";
            // 
            // LabelE3
            // 
            this.LabelE3.AutoSize = true;
            this.LabelE3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelE3.Location = new System.Drawing.Point(296, 181);
            this.LabelE3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelE3.Name = "LabelE3";
            this.LabelE3.Size = new System.Drawing.Size(80, 25);
            this.LabelE3.TabIndex = 3;
            this.LabelE3.Text = "Edad 3:";
            // 
            // LabelPromedio
            // 
            this.LabelPromedio.AutoSize = true;
            this.LabelPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPromedio.Location = new System.Drawing.Point(296, 233);
            this.LabelPromedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPromedio.Name = "LabelPromedio";
            this.LabelPromedio.Size = new System.Drawing.Size(198, 25);
            this.LabelPromedio.TabIndex = 4;
            this.LabelPromedio.Text = "Promedio de edades:";
            // 
            // txtE1
            // 
            this.txtE1.Location = new System.Drawing.Point(409, 107);
            this.txtE1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtE1.Name = "txtE1";
            this.txtE1.Size = new System.Drawing.Size(117, 22);
            this.txtE1.TabIndex = 5;
            this.txtE1.Text = "0";
            // 
            // txtE3
            // 
            this.txtE3.Location = new System.Drawing.Point(409, 181);
            this.txtE3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtE3.Name = "txtE3";
            this.txtE3.Size = new System.Drawing.Size(117, 22);
            this.txtE3.TabIndex = 6;
            this.txtE3.Text = "0";
            // 
            // txtE2
            // 
            this.txtE2.Location = new System.Drawing.Point(409, 143);
            this.txtE2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtE2.Name = "txtE2";
            this.txtE2.Size = new System.Drawing.Size(117, 22);
            this.txtE2.TabIndex = 7;
            this.txtE2.Text = "0";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(516, 233);
            this.txtPromedio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.ReadOnly = true;
            this.txtPromedio.Size = new System.Drawing.Size(117, 22);
            this.txtPromedio.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(287, 299);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(115, 33);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(409, 299);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(192, 33);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar valores";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(609, 299);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 33);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtE2);
            this.Controls.Add(this.txtE3);
            this.Controls.Add(this.txtE1);
            this.Controls.Add(this.LabelPromedio);
            this.Controls.Add(this.LabelE3);
            this.Controls.Add(this.LabelE2);
            this.Controls.Add(this.LabelE1);
            this.Controls.Add(this.LabelTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.Label LabelE1;
        private System.Windows.Forms.Label LabelE2;
        private System.Windows.Forms.Label LabelE3;
        private System.Windows.Forms.Label LabelPromedio;
        private System.Windows.Forms.TextBox txtE1;
        private System.Windows.Forms.TextBox txtE3;
        private System.Windows.Forms.TextBox txtE2;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

