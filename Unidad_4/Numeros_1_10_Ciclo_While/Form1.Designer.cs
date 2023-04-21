namespace Numeros_1_10_Ciclo_While
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
            this.label_despliegue = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_desplegar = new System.Windows.Forms.Button();
            this.txt_sumatoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_despliegue = new System.Windows.Forms.TextBox();
            this.label_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_despliegue
            // 
            this.label_despliegue.AutoSize = true;
            this.label_despliegue.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_despliegue.Location = new System.Drawing.Point(246, 51);
            this.label_despliegue.Name = "label_despliegue";
            this.label_despliegue.Size = new System.Drawing.Size(345, 22);
            this.label_despliegue.TabIndex = 15;
            this.label_despliegue.Text = "Números desplegados en ese rango";
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(497, 365);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(127, 34);
            this.btn_salir.TabIndex = 14;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(364, 365);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(127, 34);
            this.btn_limpiar.TabIndex = 13;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_desplegar
            // 
            this.btn_desplegar.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desplegar.Location = new System.Drawing.Point(231, 365);
            this.btn_desplegar.Name = "btn_desplegar";
            this.btn_desplegar.Size = new System.Drawing.Size(127, 34);
            this.btn_desplegar.TabIndex = 12;
            this.btn_desplegar.Text = "Desplegar";
            this.btn_desplegar.UseVisualStyleBackColor = true;
            this.btn_desplegar.Click += new System.EventHandler(this.btn_desplegar_Click);
            // 
            // txt_sumatoria
            // 
            this.txt_sumatoria.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sumatoria.Location = new System.Drawing.Point(439, 316);
            this.txt_sumatoria.Name = "txt_sumatoria";
            this.txt_sumatoria.Size = new System.Drawing.Size(100, 29);
            this.txt_sumatoria.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sumatoria de los números desplegados";
            // 
            // txt_despliegue
            // 
            this.txt_despliegue.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_despliegue.Location = new System.Drawing.Point(305, 76);
            this.txt_despliegue.Multiline = true;
            this.txt_despliegue.Name = "txt_despliegue";
            this.txt_despliegue.Size = new System.Drawing.Size(233, 234);
            this.txt_despliegue.TabIndex = 9;
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(301, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(238, 29);
            this.label_titulo.TabIndex = 8;
            this.label_titulo.Text = "Números del 1 al 10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.label_despliegue);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_desplegar);
            this.Controls.Add(this.txt_sumatoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_despliegue);
            this.Controls.Add(this.label_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_despliegue;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_desplegar;
        private System.Windows.Forms.TextBox txt_sumatoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_despliegue;
        private System.Windows.Forms.Label label_titulo;
    }
}

