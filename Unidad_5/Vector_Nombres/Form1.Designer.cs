namespace Vector_Nombres
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_desplegar = new System.Windows.Forms.Button();
            this.txt_elemento_medio = new System.Windows.Forms.TextBox();
            this.label_elemento_medio = new System.Windows.Forms.Label();
            this.txt_ultimo_elemento = new System.Windows.Forms.TextBox();
            this.label_ultimo_elemento = new System.Windows.Forms.Label();
            this.txt_vector = new System.Windows.Forms.TextBox();
            this.label_vector = new System.Windows.Forms.Label();
            this.label_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(473, 366);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(116, 36);
            this.btn_salir.TabIndex = 23;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(351, 366);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(116, 36);
            this.btn_reset.TabIndex = 22;
            this.btn_reset.Text = "Resetear";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_desplegar
            // 
            this.btn_desplegar.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desplegar.Location = new System.Drawing.Point(229, 366);
            this.btn_desplegar.Name = "btn_desplegar";
            this.btn_desplegar.Size = new System.Drawing.Size(116, 36);
            this.btn_desplegar.TabIndex = 21;
            this.btn_desplegar.Text = "Desplegar";
            this.btn_desplegar.UseVisualStyleBackColor = true;
            this.btn_desplegar.Click += new System.EventHandler(this.btn_desplegar_Click);
            // 
            // txt_elemento_medio
            // 
            this.txt_elemento_medio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_elemento_medio.Location = new System.Drawing.Point(340, 322);
            this.txt_elemento_medio.Name = "txt_elemento_medio";
            this.txt_elemento_medio.Size = new System.Drawing.Size(141, 29);
            this.txt_elemento_medio.TabIndex = 18;
            // 
            // label_elemento_medio
            // 
            this.label_elemento_medio.AutoSize = true;
            this.label_elemento_medio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_elemento_medio.Location = new System.Drawing.Point(154, 325);
            this.label_elemento_medio.Name = "label_elemento_medio";
            this.label_elemento_medio.Size = new System.Drawing.Size(180, 22);
            this.label_elemento_medio.TabIndex = 17;
            this.label_elemento_medio.Text = "Elemento del medio";
            // 
            // txt_ultimo_elemento
            // 
            this.txt_ultimo_elemento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ultimo_elemento.Location = new System.Drawing.Point(340, 287);
            this.txt_ultimo_elemento.Name = "txt_ultimo_elemento";
            this.txt_ultimo_elemento.Size = new System.Drawing.Size(141, 29);
            this.txt_ultimo_elemento.TabIndex = 16;
            // 
            // label_ultimo_elemento
            // 
            this.label_ultimo_elemento.AutoSize = true;
            this.label_ultimo_elemento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ultimo_elemento.Location = new System.Drawing.Point(187, 290);
            this.label_ultimo_elemento.Name = "label_ultimo_elemento";
            this.label_ultimo_elemento.Size = new System.Drawing.Size(147, 22);
            this.label_ultimo_elemento.TabIndex = 15;
            this.label_ultimo_elemento.Text = "Ultimo elemento";
            // 
            // txt_vector
            // 
            this.txt_vector.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vector.Location = new System.Drawing.Point(340, 75);
            this.txt_vector.Multiline = true;
            this.txt_vector.Name = "txt_vector";
            this.txt_vector.Size = new System.Drawing.Size(141, 206);
            this.txt_vector.TabIndex = 14;
            // 
            // label_vector
            // 
            this.label_vector.AutoSize = true;
            this.label_vector.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vector.Location = new System.Drawing.Point(378, 50);
            this.label_vector.Name = "label_vector";
            this.label_vector.Size = new System.Drawing.Size(65, 22);
            this.label_vector.TabIndex = 13;
            this.label_vector.Text = "Vector";
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(223, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(398, 29);
            this.label_titulo.TabIndex = 12;
            this.label_titulo.Text = "Práctica de vector de 5 elementos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_desplegar);
            this.Controls.Add(this.txt_elemento_medio);
            this.Controls.Add(this.label_elemento_medio);
            this.Controls.Add(this.txt_ultimo_elemento);
            this.Controls.Add(this.label_ultimo_elemento);
            this.Controls.Add(this.txt_vector);
            this.Controls.Add(this.label_vector);
            this.Controls.Add(this.label_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_desplegar;
        private System.Windows.Forms.TextBox txt_elemento_medio;
        private System.Windows.Forms.Label label_elemento_medio;
        private System.Windows.Forms.TextBox txt_ultimo_elemento;
        private System.Windows.Forms.Label label_ultimo_elemento;
        private System.Windows.Forms.TextBox txt_vector;
        private System.Windows.Forms.Label label_vector;
        private System.Windows.Forms.Label label_titulo;
    }
}

