namespace Matriz_Numerica_Diagonales
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
            this.txt_matriz = new System.Windows.Forms.TextBox();
            this.label_suma_elementos_diagonal_principal = new System.Windows.Forms.Label();
            this.txt_suma_diagonal_principal = new System.Windows.Forms.TextBox();
            this.txt_suma_diagonal_inversa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_desplegar = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(290, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(251, 29);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Matriz de diagonales";
            // 
            // txt_matriz
            // 
            this.txt_matriz.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matriz.Location = new System.Drawing.Point(161, 41);
            this.txt_matriz.Multiline = true;
            this.txt_matriz.Name = "txt_matriz";
            this.txt_matriz.Size = new System.Drawing.Size(498, 350);
            this.txt_matriz.TabIndex = 1;
            // 
            // label_suma_elementos_diagonal_principal
            // 
            this.label_suma_elementos_diagonal_principal.AutoSize = true;
            this.label_suma_elementos_diagonal_principal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_suma_elementos_diagonal_principal.Location = new System.Drawing.Point(157, 397);
            this.label_suma_elementos_diagonal_principal.Name = "label_suma_elementos_diagonal_principal";
            this.label_suma_elementos_diagonal_principal.Size = new System.Drawing.Size(411, 22);
            this.label_suma_elementos_diagonal_principal.TabIndex = 2;
            this.label_suma_elementos_diagonal_principal.Text = "Suma de los elementos en la diagonal principal:";
            // 
            // txt_suma_diagonal_principal
            // 
            this.txt_suma_diagonal_principal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suma_diagonal_principal.Location = new System.Drawing.Point(574, 394);
            this.txt_suma_diagonal_principal.Name = "txt_suma_diagonal_principal";
            this.txt_suma_diagonal_principal.Size = new System.Drawing.Size(85, 29);
            this.txt_suma_diagonal_principal.TabIndex = 3;
            // 
            // txt_suma_diagonal_inversa
            // 
            this.txt_suma_diagonal_inversa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suma_diagonal_inversa.Location = new System.Drawing.Point(574, 429);
            this.txt_suma_diagonal_inversa.Name = "txt_suma_diagonal_inversa";
            this.txt_suma_diagonal_inversa.Size = new System.Drawing.Size(85, 29);
            this.txt_suma_diagonal_inversa.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Suma de los elementos en la diagonal inversa:";
            // 
            // btn_desplegar
            // 
            this.btn_desplegar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_desplegar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desplegar.Location = new System.Drawing.Point(220, 475);
            this.btn_desplegar.Name = "btn_desplegar";
            this.btn_desplegar.Size = new System.Drawing.Size(123, 38);
            this.btn_desplegar.TabIndex = 6;
            this.btn_desplegar.Text = "Desplegar";
            this.btn_desplegar.UseVisualStyleBackColor = false;
            this.btn_desplegar.Click += new System.EventHandler(this.btn_desplegar_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_reset.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(349, 475);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(123, 38);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Resetear";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_salir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(478, 475);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(123, 38);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_desplegar);
            this.Controls.Add(this.txt_suma_diagonal_inversa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_suma_diagonal_principal);
            this.Controls.Add(this.label_suma_elementos_diagonal_principal);
            this.Controls.Add(this.txt_matriz);
            this.Controls.Add(this.label_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.TextBox txt_matriz;
        private System.Windows.Forms.Label label_suma_elementos_diagonal_principal;
        private System.Windows.Forms.TextBox txt_suma_diagonal_principal;
        private System.Windows.Forms.TextBox txt_suma_diagonal_inversa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_desplegar;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_salir;
    }
}

