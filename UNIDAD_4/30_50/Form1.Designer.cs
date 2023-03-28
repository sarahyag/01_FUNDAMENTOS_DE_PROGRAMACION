namespace _30_50
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
            this.label_ascendente = new System.Windows.Forms.Label();
            this.label_descendente = new System.Windows.Forms.Label();
            this.label_multiplos = new System.Windows.Forms.Label();
            this.txt_ascendente = new System.Windows.Forms.TextBox();
            this.txt_descendente = new System.Windows.Forms.TextBox();
            this.txt_multiplos = new System.Windows.Forms.TextBox();
            this.label_suma = new System.Windows.Forms.Label();
            this.txt_suma = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(287, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(251, 29);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Números del 30 al 50";
            // 
            // label_subtitulo
            // 
            this.label_subtitulo.AutoSize = true;
            this.label_subtitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subtitulo.Location = new System.Drawing.Point(245, 54);
            this.label_subtitulo.Name = "label_subtitulo";
            this.label_subtitulo.Size = new System.Drawing.Size(352, 24);
            this.label_subtitulo.TabIndex = 1;
            this.label_subtitulo.Text = "Despliegue de números de forma:";
            // 
            // label_ascendente
            // 
            this.label_ascendente.AutoSize = true;
            this.label_ascendente.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ascendente.Location = new System.Drawing.Point(207, 99);
            this.label_ascendente.Name = "label_ascendente";
            this.label_ascendente.Size = new System.Drawing.Size(131, 24);
            this.label_ascendente.TabIndex = 2;
            this.label_ascendente.Text = "Ascendente";
            // 
            // label_descendente
            // 
            this.label_descendente.AutoSize = true;
            this.label_descendente.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descendente.Location = new System.Drawing.Point(344, 99);
            this.label_descendente.Name = "label_descendente";
            this.label_descendente.Size = new System.Drawing.Size(143, 24);
            this.label_descendente.TabIndex = 3;
            this.label_descendente.Text = "Descendente";
            // 
            // label_multiplos
            // 
            this.label_multiplos.AutoSize = true;
            this.label_multiplos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_multiplos.Location = new System.Drawing.Point(493, 99);
            this.label_multiplos.Name = "label_multiplos";
            this.label_multiplos.Size = new System.Drawing.Size(154, 24);
            this.label_multiplos.TabIndex = 4;
            this.label_multiplos.Text = "Múltiplos del 3";
            // 
            // txt_ascendente
            // 
            this.txt_ascendente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ascendente.Location = new System.Drawing.Point(211, 141);
            this.txt_ascendente.Multiline = true;
            this.txt_ascendente.Name = "txt_ascendente";
            this.txt_ascendente.Size = new System.Drawing.Size(127, 351);
            this.txt_ascendente.TabIndex = 5;
            // 
            // txt_descendente
            // 
            this.txt_descendente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descendente.Location = new System.Drawing.Point(348, 141);
            this.txt_descendente.Multiline = true;
            this.txt_descendente.Name = "txt_descendente";
            this.txt_descendente.Size = new System.Drawing.Size(127, 351);
            this.txt_descendente.TabIndex = 6;
            // 
            // txt_multiplos
            // 
            this.txt_multiplos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_multiplos.Location = new System.Drawing.Point(497, 141);
            this.txt_multiplos.Multiline = true;
            this.txt_multiplos.Name = "txt_multiplos";
            this.txt_multiplos.Size = new System.Drawing.Size(127, 351);
            this.txt_multiplos.TabIndex = 7;
            // 
            // label_suma
            // 
            this.label_suma.AutoSize = true;
            this.label_suma.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_suma.Location = new System.Drawing.Point(209, 503);
            this.label_suma.Name = "label_suma";
            this.label_suma.Size = new System.Drawing.Size(282, 24);
            this.label_suma.TabIndex = 8;
            this.label_suma.Text = "Suma de los múltiplos de 3";
            // 
            // txt_suma
            // 
            this.txt_suma.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suma.Location = new System.Drawing.Point(497, 501);
            this.txt_suma.Multiline = true;
            this.txt_suma.Name = "txt_suma";
            this.txt_suma.Size = new System.Drawing.Size(127, 37);
            this.txt_suma.TabIndex = 9;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(270, 568);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(100, 39);
            this.btn_calcular.TabIndex = 10;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(376, 568);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(90, 39);
            this.btn_limpiar.TabIndex = 11;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(472, 568);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(90, 39);
            this.btn_salir.TabIndex = 12;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 702);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_suma);
            this.Controls.Add(this.label_suma);
            this.Controls.Add(this.txt_multiplos);
            this.Controls.Add(this.txt_descendente);
            this.Controls.Add(this.txt_ascendente);
            this.Controls.Add(this.label_multiplos);
            this.Controls.Add(this.label_descendente);
            this.Controls.Add(this.label_ascendente);
            this.Controls.Add(this.label_subtitulo);
            this.Controls.Add(this.label_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_subtitulo;
        private System.Windows.Forms.Label label_ascendente;
        private System.Windows.Forms.Label label_descendente;
        private System.Windows.Forms.Label label_multiplos;
        private System.Windows.Forms.TextBox txt_ascendente;
        private System.Windows.Forms.TextBox txt_descendente;
        private System.Windows.Forms.TextBox txt_multiplos;
        private System.Windows.Forms.Label label_suma;
        private System.Windows.Forms.TextBox txt_suma;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
    }
}

