namespace mayor_menor_edad
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
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_an = new System.Windows.Forms.Label();
            this.label_aa = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtan = new System.Windows.Forms.TextBox();
            this.txtaa = new System.Windows.Forms.TextBox();
            this.label_resultado = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(252, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(350, 29);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "¿Es mayor o menor de edad?";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.Location = new System.Drawing.Point(223, 63);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(155, 22);
            this.label_nombre.TabIndex = 1;
            this.label_nombre.Text = "Ingresar nombre:";
            // 
            // label_an
            // 
            this.label_an.AutoSize = true;
            this.label_an.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_an.Location = new System.Drawing.Point(223, 99);
            this.label_an.Name = "label_an";
            this.label_an.Size = new System.Drawing.Size(244, 22);
            this.label_an.TabIndex = 2;
            this.label_an.Text = "Ingresar año de nacimiento:";
            // 
            // label_aa
            // 
            this.label_aa.AutoSize = true;
            this.label_aa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_aa.Location = new System.Drawing.Point(223, 135);
            this.label_aa.Name = "label_aa";
            this.label_aa.Size = new System.Drawing.Size(175, 22);
            this.label_aa.TabIndex = 3;
            this.label_aa.Text = "Ingresar año actual:";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(502, 60);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 29);
            this.txtnombre.TabIndex = 4;
            // 
            // txtan
            // 
            this.txtan.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtan.Location = new System.Drawing.Point(502, 96);
            this.txtan.Name = "txtan";
            this.txtan.Size = new System.Drawing.Size(100, 29);
            this.txtan.TabIndex = 5;
            // 
            // txtaa
            // 
            this.txtaa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaa.Location = new System.Drawing.Point(502, 132);
            this.txtaa.Name = "txtaa";
            this.txtaa.Size = new System.Drawing.Size(100, 29);
            this.txtaa.TabIndex = 6;
            // 
            // label_resultado
            // 
            this.label_resultado.AutoSize = true;
            this.label_resultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado.Location = new System.Drawing.Point(101, 213);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(101, 22);
            this.label_resultado.TabIndex = 7;
            this.label_resultado.Text = "Resultado:";
            // 
            // txtresultado
            // 
            this.txtresultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.Location = new System.Drawing.Point(208, 210);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(414, 29);
            this.txtresultado.TabIndex = 8;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(216, 287);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(105, 32);
            this.btn_calcular.TabIndex = 9;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(327, 287);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(171, 32);
            this.btn_limpiar.TabIndex = 10;
            this.btn_limpiar.Text = "Eliminar valores";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(504, 287);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(105, 32);
            this.btn_salir.TabIndex = 11;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.txtaa);
            this.Controls.Add(this.txtan);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label_aa);
            this.Controls.Add(this.label_an);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.label_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_an;
        private System.Windows.Forms.Label label_aa;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtan;
        private System.Windows.Forms.TextBox txtaa;
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
    }
}

