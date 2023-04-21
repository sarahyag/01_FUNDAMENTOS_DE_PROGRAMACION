namespace Numeros_1_10_Ciclo_Do_While
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
            this.label_despliegue = new System.Windows.Forms.Label();
            this.txt_despliegue = new System.Windows.Forms.TextBox();
            this.label_suma = new System.Windows.Forms.Label();
            this.txt_suma = new System.Windows.Forms.TextBox();
            this.btn_desplegar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(297, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(238, 29);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Números del 1 al 10";
            // 
            // label_despliegue
            // 
            this.label_despliegue.AutoSize = true;
            this.label_despliegue.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_despliegue.Location = new System.Drawing.Point(250, 52);
            this.label_despliegue.Name = "label_despliegue";
            this.label_despliegue.Size = new System.Drawing.Size(345, 22);
            this.label_despliegue.TabIndex = 1;
            this.label_despliegue.Text = "Números desplegados en ese rango";
            // 
            // txt_despliegue
            // 
            this.txt_despliegue.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_despliegue.Location = new System.Drawing.Point(344, 77);
            this.txt_despliegue.Multiline = true;
            this.txt_despliegue.Name = "txt_despliegue";
            this.txt_despliegue.Size = new System.Drawing.Size(159, 275);
            this.txt_despliegue.TabIndex = 2;
            // 
            // label_suma
            // 
            this.label_suma.AutoSize = true;
            this.label_suma.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_suma.Location = new System.Drawing.Point(124, 365);
            this.label_suma.Name = "label_suma";
            this.label_suma.Size = new System.Drawing.Size(379, 22);
            this.label_suma.TabIndex = 3;
            this.label_suma.Text = "Sumatoria de los números desplegados";
            // 
            // txt_suma
            // 
            this.txt_suma.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suma.Location = new System.Drawing.Point(509, 362);
            this.txt_suma.Name = "txt_suma";
            this.txt_suma.Size = new System.Drawing.Size(86, 29);
            this.txt_suma.TabIndex = 4;
            // 
            // btn_desplegar
            // 
            this.btn_desplegar.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desplegar.Location = new System.Drawing.Point(221, 417);
            this.btn_desplegar.Name = "btn_desplegar";
            this.btn_desplegar.Size = new System.Drawing.Size(114, 32);
            this.btn_desplegar.TabIndex = 5;
            this.btn_desplegar.Text = "Desplegar";
            this.btn_desplegar.UseVisualStyleBackColor = true;
            this.btn_desplegar.Click += new System.EventHandler(this.btn_desplegar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(341, 417);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(162, 32);
            this.btn_limpiar.TabIndex = 6;
            this.btn_limpiar.Text = "Limpiar valores";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(509, 417);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(114, 32);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_desplegar);
            this.Controls.Add(this.txt_suma);
            this.Controls.Add(this.label_suma);
            this.Controls.Add(this.txt_despliegue);
            this.Controls.Add(this.label_despliegue);
            this.Controls.Add(this.label_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_despliegue;
        private System.Windows.Forms.TextBox txt_despliegue;
        private System.Windows.Forms.Label label_suma;
        private System.Windows.Forms.TextBox txt_suma;
        private System.Windows.Forms.Button btn_desplegar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
    }
}

