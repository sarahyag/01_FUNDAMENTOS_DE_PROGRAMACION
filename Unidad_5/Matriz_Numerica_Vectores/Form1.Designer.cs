namespace Matriz_Numerica_Vectores
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_matriz = new System.Windows.Forms.TextBox();
            this.txt_vector_renglones = new System.Windows.Forms.TextBox();
            this.txt_vector_columnas = new System.Windows.Forms.TextBox();
            this.btn_desplegar = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matriz numérica y vectores";
            // 
            // txt_matriz
            // 
            this.txt_matriz.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matriz.Location = new System.Drawing.Point(121, 41);
            this.txt_matriz.Multiline = true;
            this.txt_matriz.Name = "txt_matriz";
            this.txt_matriz.Size = new System.Drawing.Size(499, 337);
            this.txt_matriz.TabIndex = 1;
            // 
            // txt_vector_renglones
            // 
            this.txt_vector_renglones.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vector_renglones.Location = new System.Drawing.Point(626, 41);
            this.txt_vector_renglones.Multiline = true;
            this.txt_vector_renglones.Name = "txt_vector_renglones";
            this.txt_vector_renglones.Size = new System.Drawing.Size(76, 337);
            this.txt_vector_renglones.TabIndex = 2;
            // 
            // txt_vector_columnas
            // 
            this.txt_vector_columnas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vector_columnas.Location = new System.Drawing.Point(121, 384);
            this.txt_vector_columnas.Multiline = true;
            this.txt_vector_columnas.Name = "txt_vector_columnas";
            this.txt_vector_columnas.Size = new System.Drawing.Size(499, 48);
            this.txt_vector_columnas.TabIndex = 3;
            // 
            // btn_desplegar
            // 
            this.btn_desplegar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_desplegar.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desplegar.Location = new System.Drawing.Point(222, 438);
            this.btn_desplegar.Name = "btn_desplegar";
            this.btn_desplegar.Size = new System.Drawing.Size(116, 38);
            this.btn_desplegar.TabIndex = 4;
            this.btn_desplegar.Text = "Desplegar";
            this.btn_desplegar.UseVisualStyleBackColor = false;
            this.btn_desplegar.Click += new System.EventHandler(this.btn_desplegar_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_reset.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(344, 438);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(116, 38);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "Resetear";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_salir.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(466, 438);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(116, 38);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_desplegar);
            this.Controls.Add(this.txt_vector_columnas);
            this.Controls.Add(this.txt_vector_renglones);
            this.Controls.Add(this.txt_matriz);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_matriz;
        private System.Windows.Forms.TextBox txt_vector_renglones;
        private System.Windows.Forms.TextBox txt_vector_columnas;
        private System.Windows.Forms.Button btn_desplegar;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_salir;
    }
}

