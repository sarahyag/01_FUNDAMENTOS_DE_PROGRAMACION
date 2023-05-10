namespace Vector_Numerico_Random_N
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cantidad_elementos = new System.Windows.Forms.TextBox();
            this.txt_vector = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_suma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_elemento_mayor = new System.Windows.Forms.TextBox();
            this.txt_posicion_elemento_mayor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_despliegue = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Práctica del salón";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de elementos dentro del vector";
            // 
            // txt_cantidad_elementos
            // 
            this.txt_cantidad_elementos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_elementos.Location = new System.Drawing.Point(528, 49);
            this.txt_cantidad_elementos.Name = "txt_cantidad_elementos";
            this.txt_cantidad_elementos.Size = new System.Drawing.Size(87, 29);
            this.txt_cantidad_elementos.TabIndex = 2;
            // 
            // txt_vector
            // 
            this.txt_vector.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vector.Location = new System.Drawing.Point(196, 125);
            this.txt_vector.Multiline = true;
            this.txt_vector.Name = "txt_vector";
            this.txt_vector.Size = new System.Drawing.Size(132, 184);
            this.txt_vector.TabIndex = 4;
            this.txt_vector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Despliegue del vector";
            // 
            // txt_suma
            // 
            this.txt_suma.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suma.Location = new System.Drawing.Point(658, 96);
            this.txt_suma.Name = "txt_suma";
            this.txt_suma.Size = new System.Drawing.Size(87, 29);
            this.txt_suma.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Suma de los elementos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(504, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Elemento mayor";
            // 
            // txt_elemento_mayor
            // 
            this.txt_elemento_mayor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_elemento_mayor.Location = new System.Drawing.Point(658, 131);
            this.txt_elemento_mayor.Name = "txt_elemento_mayor";
            this.txt_elemento_mayor.Size = new System.Drawing.Size(87, 29);
            this.txt_elemento_mayor.TabIndex = 8;
            // 
            // txt_posicion_elemento_mayor
            // 
            this.txt_posicion_elemento_mayor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_posicion_elemento_mayor.Location = new System.Drawing.Point(658, 166);
            this.txt_posicion_elemento_mayor.Name = "txt_posicion_elemento_mayor";
            this.txt_posicion_elemento_mayor.Size = new System.Drawing.Size(87, 29);
            this.txt_posicion_elemento_mayor.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Posición del elemento mayor";
            // 
            // btn_despliegue
            // 
            this.btn_despliegue.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_despliegue.Location = new System.Drawing.Point(369, 210);
            this.btn_despliegue.Name = "btn_despliegue";
            this.btn_despliegue.Size = new System.Drawing.Size(133, 36);
            this.btn_despliegue.TabIndex = 11;
            this.btn_despliegue.Text = "Despliegue";
            this.btn_despliegue.UseVisualStyleBackColor = true;
            this.btn_despliegue.Click += new System.EventHandler(this.btn_despliegue_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(508, 210);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(133, 36);
            this.btn_limpiar.TabIndex = 12;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(647, 210);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(133, 36);
            this.btn_salir.TabIndex = 13;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_despliegue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_posicion_elemento_mayor);
            this.Controls.Add(this.txt_elemento_mayor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_suma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_vector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cantidad_elementos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cantidad_elementos;
        private System.Windows.Forms.TextBox txt_vector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_suma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_elemento_mayor;
        private System.Windows.Forms.TextBox txt_posicion_elemento_mayor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_despliegue;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
    }
}

