namespace Matriz_Numeros_Clase
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
            this.txt_matriz_numeros = new System.Windows.Forms.TextBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_desplegar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(245, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(360, 29);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Práctica de matriz de números";
            // 
            // txt_matriz_numeros
            // 
            this.txt_matriz_numeros.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matriz_numeros.Location = new System.Drawing.Point(296, 41);
            this.txt_matriz_numeros.Multiline = true;
            this.txt_matriz_numeros.Name = "txt_matriz_numeros";
            this.txt_matriz_numeros.Size = new System.Drawing.Size(244, 150);
            this.txt_matriz_numeros.TabIndex = 1;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_salir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(477, 206);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(118, 37);
            this.btn_salir.TabIndex = 18;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_reset.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(353, 206);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(118, 37);
            this.btn_reset.TabIndex = 17;
            this.btn_reset.Text = "Resetear";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_desplegar
            // 
            this.btn_desplegar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_desplegar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desplegar.Location = new System.Drawing.Point(229, 206);
            this.btn_desplegar.Name = "btn_desplegar";
            this.btn_desplegar.Size = new System.Drawing.Size(118, 37);
            this.btn_desplegar.TabIndex = 16;
            this.btn_desplegar.Text = "Desplegar";
            this.btn_desplegar.UseVisualStyleBackColor = false;
            this.btn_desplegar.Click += new System.EventHandler(this.btn_desplegar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_desplegar);
            this.Controls.Add(this.txt_matriz_numeros);
            this.Controls.Add(this.label_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.TextBox txt_matriz_numeros;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_desplegar;
    }
}

