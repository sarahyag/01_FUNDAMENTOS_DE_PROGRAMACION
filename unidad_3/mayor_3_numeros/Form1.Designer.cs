namespace mayor_3_numeros
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
            this.label_titulo = new System.Windows.Forms.Label();
            this.label_n1 = new System.Windows.Forms.Label();
            this.labe_n2 = new System.Windows.Forms.Label();
            this.label_n3 = new System.Windows.Forms.Label();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtn3 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label_resultado = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(289, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(247, 29);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Mayor de 3 números";
            // 
            // label_n1
            // 
            this.label_n1.AutoSize = true;
            this.label_n1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_n1.Location = new System.Drawing.Point(220, 66);
            this.label_n1.Name = "label_n1";
            this.label_n1.Size = new System.Drawing.Size(233, 22);
            this.label_n1.TabIndex = 1;
            this.label_n1.Text = "Ingresar el primer número:";
            // 
            // labe_n2
            // 
            this.labe_n2.AutoSize = true;
            this.labe_n2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe_n2.Location = new System.Drawing.Point(220, 113);
            this.labe_n2.Name = "labe_n2";
            this.labe_n2.Size = new System.Drawing.Size(253, 22);
            this.labe_n2.TabIndex = 2;
            this.labe_n2.Text = "Ingresar el segundo número:";
            // 
            // label_n3
            // 
            this.label_n3.AutoSize = true;
            this.label_n3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_n3.Location = new System.Drawing.Point(220, 169);
            this.label_n3.Name = "label_n3";
            this.label_n3.Size = new System.Drawing.Size(228, 22);
            this.label_n3.TabIndex = 3;
            this.label_n3.Text = "Ingresar el tercer número:";
            // 
            // txtn1
            // 
            this.txtn1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtn1.Location = new System.Drawing.Point(501, 59);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(74, 29);
            this.txtn1.TabIndex = 4;
            // 
            // txtn2
            // 
            this.txtn2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtn2.Location = new System.Drawing.Point(501, 110);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(74, 29);
            this.txtn2.TabIndex = 5;
            // 
            // txtn3
            // 
            this.txtn3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtn3.Location = new System.Drawing.Point(501, 166);
            this.txtn3.Name = "txtn3";
            this.txtn3.Size = new System.Drawing.Size(74, 29);
            this.txtn3.TabIndex = 6;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(218, 269);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(96, 34);
            this.btncalcular.TabIndex = 7;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(320, 269);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(153, 34);
            this.btnlimpiar.TabIndex = 8;
            this.btnlimpiar.Text = "Eliminar valores";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(479, 269);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(96, 34);
            this.btnsalir.TabIndex = 9;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label_resultado
            // 
            this.label_resultado.AutoSize = true;
            this.label_resultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado.Location = new System.Drawing.Point(100, 225);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(101, 22);
            this.label_resultado.TabIndex = 10;
            this.label_resultado.Text = "Resultado:";
            // 
            // txtresultado
            // 
            this.txtresultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.Location = new System.Drawing.Point(207, 222);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(419, 29);
            this.txtresultado.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtn3);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.label_n3);
            this.Controls.Add(this.labe_n2);
            this.Controls.Add(this.label_n1);
            this.Controls.Add(this.label_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_n1;
        private System.Windows.Forms.Label labe_n2;
        private System.Windows.Forms.Label label_n3;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtn3;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.TextBox txtresultado;
    }
}

