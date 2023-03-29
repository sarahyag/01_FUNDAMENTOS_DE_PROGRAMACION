namespace Numeros__20_20
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
            this.label_numeros = new System.Windows.Forms.Label();
            this.txt_numeros = new System.Windows.Forms.TextBox();
            this.label_suma = new System.Windows.Forms.Label();
            this.txt_suma = new System.Windows.Forms.TextBox();
            this.txt_positivos = new System.Windows.Forms.TextBox();
            this.label_positivos = new System.Windows.Forms.Label();
            this.txt_negativos = new System.Windows.Forms.TextBox();
            this.label_negativos = new System.Windows.Forms.Label();
            this.txt_pares = new System.Windows.Forms.TextBox();
            this.label_pares = new System.Windows.Forms.Label();
            this.txt_digitos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(284, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(259, 29);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Números del -20 al 20";
            // 
            // label_numeros
            // 
            this.label_numeros.AutoSize = true;
            this.label_numeros.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numeros.Location = new System.Drawing.Point(316, 47);
            this.label_numeros.Name = "label_numeros";
            this.label_numeros.Size = new System.Drawing.Size(194, 22);
            this.label_numeros.TabIndex = 1;
            this.label_numeros.Text = "Números a trabajar:";
            // 
            // txt_numeros
            // 
            this.txt_numeros.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numeros.Location = new System.Drawing.Point(320, 85);
            this.txt_numeros.Multiline = true;
            this.txt_numeros.Name = "txt_numeros";
            this.txt_numeros.Size = new System.Drawing.Size(190, 336);
            this.txt_numeros.TabIndex = 2;
            // 
            // label_suma
            // 
            this.label_suma.AutoSize = true;
            this.label_suma.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_suma.Location = new System.Drawing.Point(127, 440);
            this.label_suma.Name = "label_suma";
            this.label_suma.Size = new System.Drawing.Size(277, 22);
            this.label_suma.TabIndex = 3;
            this.label_suma.Text = "Suma de todos los números:";
            // 
            // txt_suma
            // 
            this.txt_suma.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suma.Location = new System.Drawing.Point(410, 437);
            this.txt_suma.Name = "txt_suma";
            this.txt_suma.Size = new System.Drawing.Size(100, 29);
            this.txt_suma.TabIndex = 4;
            // 
            // txt_positivos
            // 
            this.txt_positivos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_positivos.Location = new System.Drawing.Point(410, 472);
            this.txt_positivos.Name = "txt_positivos";
            this.txt_positivos.Size = new System.Drawing.Size(100, 29);
            this.txt_positivos.TabIndex = 6;
            // 
            // label_positivos
            // 
            this.label_positivos.AutoSize = true;
            this.label_positivos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_positivos.Location = new System.Drawing.Point(186, 475);
            this.label_positivos.Name = "label_positivos";
            this.label_positivos.Size = new System.Drawing.Size(218, 22);
            this.label_positivos.TabIndex = 5;
            this.label_positivos.Text = "Cantidad de positivos:";
            // 
            // txt_negativos
            // 
            this.txt_negativos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_negativos.Location = new System.Drawing.Point(410, 507);
            this.txt_negativos.Name = "txt_negativos";
            this.txt_negativos.Size = new System.Drawing.Size(100, 29);
            this.txt_negativos.TabIndex = 8;
            // 
            // label_negativos
            // 
            this.label_negativos.AutoSize = true;
            this.label_negativos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_negativos.Location = new System.Drawing.Point(180, 510);
            this.label_negativos.Name = "label_negativos";
            this.label_negativos.Size = new System.Drawing.Size(224, 22);
            this.label_negativos.TabIndex = 7;
            this.label_negativos.Text = "Cantidad de negativos:";
            // 
            // txt_pares
            // 
            this.txt_pares.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pares.Location = new System.Drawing.Point(410, 542);
            this.txt_pares.Name = "txt_pares";
            this.txt_pares.Size = new System.Drawing.Size(100, 29);
            this.txt_pares.TabIndex = 10;
            // 
            // label_pares
            // 
            this.label_pares.AutoSize = true;
            this.label_pares.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pares.Location = new System.Drawing.Point(218, 545);
            this.label_pares.Name = "label_pares";
            this.label_pares.Size = new System.Drawing.Size(186, 22);
            this.label_pares.TabIndex = 9;
            this.label_pares.Text = "Cantidad de pares:";
            // 
            // txt_digitos
            // 
            this.txt_digitos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_digitos.Location = new System.Drawing.Point(410, 577);
            this.txt_digitos.Name = "txt_digitos";
            this.txt_digitos.Size = new System.Drawing.Size(100, 29);
            this.txt_digitos.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cantidad de dígitos:";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(251, 644);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(108, 37);
            this.btn_calcular.TabIndex = 13;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(365, 644);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(108, 37);
            this.btn_limpiar.TabIndex = 14;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(479, 644);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(108, 37);
            this.btn_salir.TabIndex = 15;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 710);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_digitos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pares);
            this.Controls.Add(this.label_pares);
            this.Controls.Add(this.txt_negativos);
            this.Controls.Add(this.label_negativos);
            this.Controls.Add(this.txt_positivos);
            this.Controls.Add(this.label_positivos);
            this.Controls.Add(this.txt_suma);
            this.Controls.Add(this.label_suma);
            this.Controls.Add(this.txt_numeros);
            this.Controls.Add(this.label_numeros);
            this.Controls.Add(this.label_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_numeros;
        private System.Windows.Forms.TextBox txt_numeros;
        private System.Windows.Forms.Label label_suma;
        private System.Windows.Forms.TextBox txt_suma;
        private System.Windows.Forms.TextBox txt_positivos;
        private System.Windows.Forms.Label label_positivos;
        private System.Windows.Forms.TextBox txt_negativos;
        private System.Windows.Forms.Label label_negativos;
        private System.Windows.Forms.TextBox txt_pares;
        private System.Windows.Forms.Label label_pares;
        private System.Windows.Forms.TextBox txt_digitos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
    }
}

