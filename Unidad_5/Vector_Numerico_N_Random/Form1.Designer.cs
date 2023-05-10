namespace Vector_Numerico_N_Random
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
            this.label_subtitulo = new System.Windows.Forms.Label();
            this.txt_numero_vectores = new System.Windows.Forms.TextBox();
            this.txt_vector = new System.Windows.Forms.TextBox();
            this.label_vector = new System.Windows.Forms.Label();
            this.label_suma = new System.Windows.Forms.Label();
            this.txt_suma_elementos = new System.Windows.Forms.TextBox();
            this.txt_elemento_mayor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_despliegue = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(246, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(247, 29);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Vector numérico \"N\"";
            // 
            // label_subtitulo
            // 
            this.label_subtitulo.AutoSize = true;
            this.label_subtitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subtitulo.Location = new System.Drawing.Point(197, 55);
            this.label_subtitulo.Name = "label_subtitulo";
            this.label_subtitulo.Size = new System.Drawing.Size(339, 22);
            this.label_subtitulo.TabIndex = 1;
            this.label_subtitulo.Text = "Número de elementos dentro el vector:";
            // 
            // txt_numero_vectores
            // 
            this.txt_numero_vectores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero_vectores.Location = new System.Drawing.Point(312, 80);
            this.txt_numero_vectores.Name = "txt_numero_vectores";
            this.txt_numero_vectores.Size = new System.Drawing.Size(100, 29);
            this.txt_numero_vectores.TabIndex = 2;
            // 
            // txt_vector
            // 
            this.txt_vector.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vector.Location = new System.Drawing.Point(67, 158);
            this.txt_vector.Multiline = true;
            this.txt_vector.Name = "txt_vector";
            this.txt_vector.Size = new System.Drawing.Size(100, 204);
            this.txt_vector.TabIndex = 4;
            this.txt_vector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_vector
            // 
            this.label_vector.AutoSize = true;
            this.label_vector.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vector.Location = new System.Drawing.Point(28, 133);
            this.label_vector.Name = "label_vector";
            this.label_vector.Size = new System.Drawing.Size(195, 22);
            this.label_vector.TabIndex = 3;
            this.label_vector.Text = "Despliegue del vector";
            // 
            // label_suma
            // 
            this.label_suma.AutoSize = true;
            this.label_suma.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_suma.Location = new System.Drawing.Point(289, 133);
            this.label_suma.Name = "label_suma";
            this.label_suma.Size = new System.Drawing.Size(210, 22);
            this.label_suma.TabIndex = 5;
            this.label_suma.Text = "Suma de los elementos";
            // 
            // txt_suma_elementos
            // 
            this.txt_suma_elementos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suma_elementos.Location = new System.Drawing.Point(505, 130);
            this.txt_suma_elementos.Name = "txt_suma_elementos";
            this.txt_suma_elementos.Size = new System.Drawing.Size(100, 29);
            this.txt_suma_elementos.TabIndex = 6;
            // 
            // txt_elemento_mayor
            // 
            this.txt_elemento_mayor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_elemento_mayor.Location = new System.Drawing.Point(505, 165);
            this.txt_elemento_mayor.Name = "txt_elemento_mayor";
            this.txt_elemento_mayor.Size = new System.Drawing.Size(100, 29);
            this.txt_elemento_mayor.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Elemento mayor del vector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Posición del elemento mayor";
            // 
            // btn_despliegue
            // 
            this.btn_despliegue.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_despliegue.Location = new System.Drawing.Point(302, 297);
            this.btn_despliegue.Name = "btn_despliegue";
            this.btn_despliegue.Size = new System.Drawing.Size(128, 32);
            this.btn_despliegue.TabIndex = 11;
            this.btn_despliegue.Text = "Despliegue";
            this.btn_despliegue.UseVisualStyleBackColor = true;
            this.btn_despliegue.Click += new System.EventHandler(this.btn_despliegue_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(302, 335);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(128, 32);
            this.btn_limpiar.TabIndex = 12;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(302, 373);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(128, 32);
            this.btn_salir.TabIndex = 13;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(505, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 448);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_despliegue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_elemento_mayor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_suma_elementos);
            this.Controls.Add(this.label_suma);
            this.Controls.Add(this.txt_vector);
            this.Controls.Add(this.label_vector);
            this.Controls.Add(this.txt_numero_vectores);
            this.Controls.Add(this.label_subtitulo);
            this.Controls.Add(this.label_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_subtitulo;
        private System.Windows.Forms.TextBox txt_numero_vectores;
        private System.Windows.Forms.TextBox txt_vector;
        private System.Windows.Forms.Label label_vector;
        private System.Windows.Forms.Label label_suma;
        private System.Windows.Forms.TextBox txt_suma_elementos;
        private System.Windows.Forms.TextBox txt_elemento_mayor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_despliegue;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox textBox1;
    }
}

