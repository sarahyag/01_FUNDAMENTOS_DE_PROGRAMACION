namespace Matriz_Numerica_Tarea
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
            this.label_matriz = new System.Windows.Forms.Label();
            this.txt_matriz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_suma_elementos_ultimo_renglon = new System.Windows.Forms.TextBox();
            this.txt_elemento_mayor_renglon_medio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_elemento_menor_matriz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_posicion_elemento_mayor_medio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_posicion_elemento_menor_matriz = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_desplegar = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(313, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(196, 29);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Matriz numérica";
            // 
            // label_matriz
            // 
            this.label_matriz.AutoSize = true;
            this.label_matriz.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_matriz.Location = new System.Drawing.Point(303, 52);
            this.label_matriz.Name = "label_matriz";
            this.label_matriz.Size = new System.Drawing.Size(213, 22);
            this.label_matriz.TabIndex = 1;
            this.label_matriz.Text = "Despliegue de la matriz:";
            // 
            // txt_matriz
            // 
            this.txt_matriz.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matriz.Location = new System.Drawing.Point(202, 77);
            this.txt_matriz.Multiline = true;
            this.txt_matriz.Name = "txt_matriz";
            this.txt_matriz.Size = new System.Drawing.Size(415, 234);
            this.txt_matriz.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Suma de los elementos del último renglón:";
            // 
            // txt_suma_elementos_ultimo_renglon
            // 
            this.txt_suma_elementos_ultimo_renglon.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suma_elementos_ultimo_renglon.Location = new System.Drawing.Point(387, 330);
            this.txt_suma_elementos_ultimo_renglon.Name = "txt_suma_elementos_ultimo_renglon";
            this.txt_suma_elementos_ultimo_renglon.Size = new System.Drawing.Size(100, 29);
            this.txt_suma_elementos_ultimo_renglon.TabIndex = 4;
            // 
            // txt_elemento_mayor_renglon_medio
            // 
            this.txt_elemento_mayor_renglon_medio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_elemento_mayor_renglon_medio.Location = new System.Drawing.Point(387, 365);
            this.txt_elemento_mayor_renglon_medio.Name = "txt_elemento_mayor_renglon_medio";
            this.txt_elemento_mayor_renglon_medio.Size = new System.Drawing.Size(100, 29);
            this.txt_elemento_mayor_renglon_medio.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "El elemento mayor del renglón del medio:";
            // 
            // txt_elemento_menor_matriz
            // 
            this.txt_elemento_menor_matriz.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_elemento_menor_matriz.Location = new System.Drawing.Point(387, 435);
            this.txt_elemento_menor_matriz.Name = "txt_elemento_menor_matriz";
            this.txt_elemento_menor_matriz.Size = new System.Drawing.Size(100, 29);
            this.txt_elemento_menor_matriz.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Elemento menor de la matriz:";
            // 
            // txt_posicion_elemento_mayor_medio
            // 
            this.txt_posicion_elemento_mayor_medio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_posicion_elemento_mayor_medio.Location = new System.Drawing.Point(654, 400);
            this.txt_posicion_elemento_mayor_medio.Name = "txt_posicion_elemento_mayor_medio";
            this.txt_posicion_elemento_mayor_medio.Size = new System.Drawing.Size(100, 29);
            this.txt_posicion_elemento_mayor_medio.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(636, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Posición en que se encuentra el elemento mayor del renglón de en medio:";
            // 
            // txt_posicion_elemento_menor_matriz
            // 
            this.txt_posicion_elemento_menor_matriz.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_posicion_elemento_menor_matriz.Location = new System.Drawing.Point(547, 470);
            this.txt_posicion_elemento_menor_matriz.Name = "txt_posicion_elemento_menor_matriz";
            this.txt_posicion_elemento_menor_matriz.Size = new System.Drawing.Size(100, 29);
            this.txt_posicion_elemento_menor_matriz.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(529, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Posición en que se encuentra el elemento menor de la matriz:";
            // 
            // btn_desplegar
            // 
            this.btn_desplegar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_desplegar.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desplegar.Location = new System.Drawing.Point(233, 515);
            this.btn_desplegar.Name = "btn_desplegar";
            this.btn_desplegar.Size = new System.Drawing.Size(124, 36);
            this.btn_desplegar.TabIndex = 13;
            this.btn_desplegar.Text = "Desplegar";
            this.btn_desplegar.UseVisualStyleBackColor = false;
            this.btn_desplegar.Click += new System.EventHandler(this.btn_desplegar_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_reset.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(363, 515);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(124, 36);
            this.btn_reset.TabIndex = 14;
            this.btn_reset.Text = "Resetear";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_salir.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(493, 515);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(124, 36);
            this.btn_salir.TabIndex = 15;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 629);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_desplegar);
            this.Controls.Add(this.txt_posicion_elemento_menor_matriz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_elemento_menor_matriz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_posicion_elemento_mayor_medio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_elemento_mayor_renglon_medio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_suma_elementos_ultimo_renglon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_matriz);
            this.Controls.Add(this.label_matriz);
            this.Controls.Add(this.label_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_matriz;
        private System.Windows.Forms.TextBox txt_matriz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_suma_elementos_ultimo_renglon;
        private System.Windows.Forms.TextBox txt_elemento_mayor_renglon_medio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_elemento_menor_matriz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_posicion_elemento_mayor_medio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_posicion_elemento_menor_matriz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_desplegar;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_salir;
    }
}

