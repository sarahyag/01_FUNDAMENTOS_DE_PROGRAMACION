namespace Practica_Dias_De_La_Semana
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
            this.label_numero = new System.Windows.Forms.Label();
            this.txtdia = new System.Windows.Forms.TextBox();
            this.labeldia = new System.Windows.Forms.Label();
            this.cmdDesplegar = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(311, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(220, 29);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Días de la semana";
            // 
            // label_numero
            // 
            this.label_numero.AutoSize = true;
            this.label_numero.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero.Location = new System.Drawing.Point(321, 57);
            this.label_numero.Name = "label_numero";
            this.label_numero.Size = new System.Drawing.Size(88, 24);
            this.label_numero.TabIndex = 1;
            this.label_numero.Text = "Número:";
            // 
            // txtdia
            // 
            this.txtdia.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdia.Location = new System.Drawing.Point(415, 54);
            this.txtdia.Name = "txtdia";
            this.txtdia.Size = new System.Drawing.Size(100, 32);
            this.txtdia.TabIndex = 2;
            this.txtdia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labeldia
            // 
            this.labeldia.AutoSize = true;
            this.labeldia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labeldia.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldia.Location = new System.Drawing.Point(385, 106);
            this.labeldia.Name = "labeldia";
            this.labeldia.Size = new System.Drawing.Size(0, 24);
            this.labeldia.TabIndex = 3;
            this.labeldia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdDesplegar
            // 
            this.cmdDesplegar.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDesplegar.Location = new System.Drawing.Point(237, 143);
            this.cmdDesplegar.Name = "cmdDesplegar";
            this.cmdDesplegar.Size = new System.Drawing.Size(125, 37);
            this.cmdDesplegar.TabIndex = 4;
            this.cmdDesplegar.Text = "Desplegar";
            this.cmdDesplegar.UseVisualStyleBackColor = true;
            this.cmdDesplegar.Click += new System.EventHandler(this.cmdDesplegar_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.Location = new System.Drawing.Point(368, 143);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(125, 37);
            this.cmdLimpiar.TabIndex = 5;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(499, 143);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(125, 37);
            this.cmdSalir.TabIndex = 6;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdDesplegar);
            this.Controls.Add(this.labeldia);
            this.Controls.Add(this.txtdia);
            this.Controls.Add(this.label_numero);
            this.Controls.Add(this.label_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_numero;
        private System.Windows.Forms.TextBox txtdia;
        private System.Windows.Forms.Label labeldia;
        private System.Windows.Forms.Button cmdDesplegar;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdSalir;
    }
}

