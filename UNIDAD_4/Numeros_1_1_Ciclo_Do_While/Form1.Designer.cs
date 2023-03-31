namespace Numeros_1_1_Ciclo_Do_While
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
            this.txt_numeros = new System.Windows.Forms.TextBox();
            this.label_subtitulo = new System.Windows.Forms.Label();
            this.label_sumatoria = new System.Windows.Forms.Label();
            this.txt_sumatoria = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(190, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(484, 29);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Números del 1 al 10 con ciclo \"Do-While\"";
            // 
            // txt_numeros
            // 
            this.txt_numeros.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numeros.Location = new System.Drawing.Point(325, 92);
            this.txt_numeros.Multiline = true;
            this.txt_numeros.Name = "txt_numeros";
            this.txt_numeros.Size = new System.Drawing.Size(205, 257);
            this.txt_numeros.TabIndex = 1;
            // 
            // label_subtitulo
            // 
            this.label_subtitulo.AutoSize = true;
            this.label_subtitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subtitulo.Location = new System.Drawing.Point(321, 53);
            this.label_subtitulo.Name = "label_subtitulo";
            this.label_subtitulo.Size = new System.Drawing.Size(209, 24);
            this.label_subtitulo.TabIndex = 2;
            this.label_subtitulo.Text = "Números a trabajar:";
            // 
            // label_sumatoria
            // 
            this.label_sumatoria.AutoSize = true;
            this.label_sumatoria.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sumatoria.Location = new System.Drawing.Point(191, 377);
            this.label_sumatoria.Name = "label_sumatoria";
            this.label_sumatoria.Size = new System.Drawing.Size(347, 24);
            this.label_sumatoria.TabIndex = 3;
            this.label_sumatoria.Text = "Sumatoria de todos los números:";
            // 
            // txt_sumatoria
            // 
            this.txt_sumatoria.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sumatoria.Location = new System.Drawing.Point(544, 375);
            this.txt_sumatoria.Name = "txt_sumatoria";
            this.txt_sumatoria.Size = new System.Drawing.Size(130, 29);
            this.txt_sumatoria.TabIndex = 4;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(195, 424);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(116, 42);
            this.btn_calcular.TabIndex = 5;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(349, 424);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(167, 42);
            this.btn_limpiar.TabIndex = 6;
            this.btn_limpiar.Text = "Limpiar valores";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(544, 424);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(116, 42);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_sumatoria);
            this.Controls.Add(this.label_sumatoria);
            this.Controls.Add(this.label_subtitulo);
            this.Controls.Add(this.txt_numeros);
            this.Controls.Add(this.label_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.TextBox txt_numeros;
        private System.Windows.Forms.Label label_subtitulo;
        private System.Windows.Forms.Label label_sumatoria;
        private System.Windows.Forms.TextBox txt_sumatoria;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
    }
}

