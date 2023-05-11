namespace Vector_Numerico_Random
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
            this.label_metodo_1 = new System.Windows.Forms.Label();
            this.label_metodo_2 = new System.Windows.Forms.Label();
            this.txt_vector_1 = new System.Windows.Forms.TextBox();
            this.txt_vector_2 = new System.Windows.Forms.TextBox();
            this.btn_desplegar_1 = new System.Windows.Forms.Button();
            this.btn_desplegar_2 = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(296, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(266, 29);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Vector: Clase Random";
            // 
            // label_metodo_1
            // 
            this.label_metodo_1.AutoSize = true;
            this.label_metodo_1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_metodo_1.Location = new System.Drawing.Point(224, 59);
            this.label_metodo_1.Name = "label_metodo_1";
            this.label_metodo_1.Size = new System.Drawing.Size(187, 22);
            this.label_metodo_1.TabIndex = 1;
            this.label_metodo_1.Text = "Vector con método 1";
            // 
            // label_metodo_2
            // 
            this.label_metodo_2.AutoSize = true;
            this.label_metodo_2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_metodo_2.Location = new System.Drawing.Point(445, 59);
            this.label_metodo_2.Name = "label_metodo_2";
            this.label_metodo_2.Size = new System.Drawing.Size(187, 22);
            this.label_metodo_2.TabIndex = 2;
            this.label_metodo_2.Text = "Vector con método 2";
            // 
            // txt_vector_1
            // 
            this.txt_vector_1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_vector_1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vector_1.Location = new System.Drawing.Point(260, 85);
            this.txt_vector_1.Multiline = true;
            this.txt_vector_1.Name = "txt_vector_1";
            this.txt_vector_1.ReadOnly = true;
            this.txt_vector_1.Size = new System.Drawing.Size(118, 234);
            this.txt_vector_1.TabIndex = 3;
            this.txt_vector_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_vector_2
            // 
            this.txt_vector_2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_vector_2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vector_2.Location = new System.Drawing.Point(488, 85);
            this.txt_vector_2.Multiline = true;
            this.txt_vector_2.Name = "txt_vector_2";
            this.txt_vector_2.ReadOnly = true;
            this.txt_vector_2.Size = new System.Drawing.Size(120, 234);
            this.txt_vector_2.TabIndex = 4;
            this.txt_vector_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_desplegar_1
            // 
            this.btn_desplegar_1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desplegar_1.Location = new System.Drawing.Point(260, 326);
            this.btn_desplegar_1.Name = "btn_desplegar_1";
            this.btn_desplegar_1.Size = new System.Drawing.Size(118, 35);
            this.btn_desplegar_1.TabIndex = 5;
            this.btn_desplegar_1.Text = "Desplegar";
            this.btn_desplegar_1.UseVisualStyleBackColor = true;
            this.btn_desplegar_1.Click += new System.EventHandler(this.btn_desplegar_1_Click);
            // 
            // btn_desplegar_2
            // 
            this.btn_desplegar_2.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desplegar_2.Location = new System.Drawing.Point(488, 325);
            this.btn_desplegar_2.Name = "btn_desplegar_2";
            this.btn_desplegar_2.Size = new System.Drawing.Size(120, 36);
            this.btn_desplegar_2.TabIndex = 6;
            this.btn_desplegar_2.Text = "Desplegar";
            this.btn_desplegar_2.UseVisualStyleBackColor = true;
            this.btn_desplegar_2.Click += new System.EventHandler(this.btn_desplegar_2_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(314, 385);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(118, 35);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Resetear";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(438, 385);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(118, 35);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_desplegar_2);
            this.Controls.Add(this.btn_desplegar_1);
            this.Controls.Add(this.txt_vector_2);
            this.Controls.Add(this.txt_vector_1);
            this.Controls.Add(this.label_metodo_2);
            this.Controls.Add(this.label_metodo_1);
            this.Controls.Add(this.label_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_metodo_1;
        private System.Windows.Forms.Label label_metodo_2;
        private System.Windows.Forms.TextBox txt_vector_1;
        private System.Windows.Forms.TextBox txt_vector_2;
        private System.Windows.Forms.Button btn_desplegar_1;
        private System.Windows.Forms.Button btn_desplegar_2;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_salir;
    }
}

