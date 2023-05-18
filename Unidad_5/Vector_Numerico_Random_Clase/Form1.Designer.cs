namespace Vector_Numerico_Random_Clase
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
            this.label_numero_elementos = new System.Windows.Forms.Label();
            this.txt_numero_elementos = new System.Windows.Forms.TextBox();
            this.txt_vector = new System.Windows.Forms.TextBox();
            this.label_vector = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_elemento_menor = new System.Windows.Forms.TextBox();
            this.txt_posicion_elemento_menor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cantidad_numeros_pares = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_suma_digitos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_desplegar = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(311, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(203, 29);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Vector Numérico";
            // 
            // label_numero_elementos
            // 
            this.label_numero_elementos.AutoSize = true;
            this.label_numero_elementos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero_elementos.Location = new System.Drawing.Point(257, 44);
            this.label_numero_elementos.Name = "label_numero_elementos";
            this.label_numero_elementos.Size = new System.Drawing.Size(203, 22);
            this.label_numero_elementos.TabIndex = 1;
            this.label_numero_elementos.Text = "Número de elementos:";
            // 
            // txt_numero_elementos
            // 
            this.txt_numero_elementos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero_elementos.Location = new System.Drawing.Point(461, 41);
            this.txt_numero_elementos.Name = "txt_numero_elementos";
            this.txt_numero_elementos.Size = new System.Drawing.Size(86, 29);
            this.txt_numero_elementos.TabIndex = 2;
            // 
            // txt_vector
            // 
            this.txt_vector.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vector.Location = new System.Drawing.Point(135, 111);
            this.txt_vector.Multiline = true;
            this.txt_vector.Name = "txt_vector";
            this.txt_vector.Size = new System.Drawing.Size(115, 248);
            this.txt_vector.TabIndex = 3;
            // 
            // label_vector
            // 
            this.label_vector.AutoSize = true;
            this.label_vector.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vector.Location = new System.Drawing.Point(107, 86);
            this.label_vector.Name = "label_vector";
            this.label_vector.Size = new System.Drawing.Size(176, 22);
            this.label_vector.TabIndex = 4;
            this.label_vector.Text = "Vector desplegado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Elemento menor del vector:";
            // 
            // txt_elemento_menor
            // 
            this.txt_elemento_menor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_elemento_menor.Location = new System.Drawing.Point(597, 83);
            this.txt_elemento_menor.Name = "txt_elemento_menor";
            this.txt_elemento_menor.Size = new System.Drawing.Size(86, 29);
            this.txt_elemento_menor.TabIndex = 6;
            // 
            // txt_posicion_elemento_menor
            // 
            this.txt_posicion_elemento_menor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_posicion_elemento_menor.Location = new System.Drawing.Point(597, 118);
            this.txt_posicion_elemento_menor.Name = "txt_posicion_elemento_menor";
            this.txt_posicion_elemento_menor.Size = new System.Drawing.Size(86, 29);
            this.txt_posicion_elemento_menor.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Posicion del elemento menor:";
            // 
            // txt_cantidad_numeros_pares
            // 
            this.txt_cantidad_numeros_pares.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_numeros_pares.Location = new System.Drawing.Point(597, 153);
            this.txt_cantidad_numeros_pares.Name = "txt_cantidad_numeros_pares";
            this.txt_cantidad_numeros_pares.Size = new System.Drawing.Size(86, 29);
            this.txt_cantidad_numeros_pares.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad de números pares:";
            // 
            // txt_suma_digitos
            // 
            this.txt_suma_digitos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suma_digitos.Location = new System.Drawing.Point(597, 188);
            this.txt_suma_digitos.Name = "txt_suma_digitos";
            this.txt_suma_digitos.Size = new System.Drawing.Size(86, 29);
            this.txt_suma_digitos.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(407, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Suma de los dígitos:";
            // 
            // btn_desplegar
            // 
            this.btn_desplegar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_desplegar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desplegar.Location = new System.Drawing.Point(321, 223);
            this.btn_desplegar.Name = "btn_desplegar";
            this.btn_desplegar.Size = new System.Drawing.Size(118, 37);
            this.btn_desplegar.TabIndex = 13;
            this.btn_desplegar.Text = "Desplegar";
            this.btn_desplegar.UseVisualStyleBackColor = false;
            this.btn_desplegar.Click += new System.EventHandler(this.btn_desplegar_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_reset.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(445, 223);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(118, 37);
            this.btn_reset.TabIndex = 14;
            this.btn_reset.Text = "Resetear";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_salir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(569, 223);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(118, 37);
            this.btn_salir.TabIndex = 15;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_desplegar);
            this.Controls.Add(this.txt_suma_digitos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cantidad_numeros_pares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_posicion_elemento_menor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_elemento_menor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_vector);
            this.Controls.Add(this.txt_vector);
            this.Controls.Add(this.txt_numero_elementos);
            this.Controls.Add(this.label_numero_elementos);
            this.Controls.Add(this.label_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_numero_elementos;
        private System.Windows.Forms.TextBox txt_numero_elementos;
        private System.Windows.Forms.TextBox txt_vector;
        private System.Windows.Forms.Label label_vector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_elemento_menor;
        private System.Windows.Forms.TextBox txt_posicion_elemento_menor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cantidad_numeros_pares;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_suma_digitos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_desplegar;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_salir;
    }
}

