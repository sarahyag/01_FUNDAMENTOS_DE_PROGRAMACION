namespace Valor_Inicial_Final_Ciclo_For
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
            this.label_valor_inicial = new System.Windows.Forms.Label();
            this.txt_valor_inicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_valor_final = new System.Windows.Forms.TextBox();
            this.label_despliegue = new System.Windows.Forms.Label();
            this.label_despliegue_todos = new System.Windows.Forms.Label();
            this.label_despliegue_pares = new System.Windows.Forms.Label();
            this.txt_despliegue_todos = new System.Windows.Forms.TextBox();
            this.txt_despliegue_pares = new System.Windows.Forms.TextBox();
            this.txt_suma_todos = new System.Windows.Forms.TextBox();
            this.label_suma_todos = new System.Windows.Forms.Label();
            this.txt_suma_pares = new System.Windows.Forms.TextBox();
            this.label_suma_pares = new System.Windows.Forms.Label();
            this.btn_desplegar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(303, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(225, 29);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Valor inicial y final";
            // 
            // label_valor_inicial
            // 
            this.label_valor_inicial.AutoSize = true;
            this.label_valor_inicial.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_valor_inicial.Location = new System.Drawing.Point(304, 61);
            this.label_valor_inicial.Name = "label_valor_inicial";
            this.label_valor_inicial.Size = new System.Drawing.Size(109, 22);
            this.label_valor_inicial.TabIndex = 1;
            this.label_valor_inicial.Text = "Valor inicial:";
            // 
            // txt_valor_inicial
            // 
            this.txt_valor_inicial.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor_inicial.Location = new System.Drawing.Point(419, 58);
            this.txt_valor_inicial.Name = "txt_valor_inicial";
            this.txt_valor_inicial.Size = new System.Drawing.Size(100, 29);
            this.txt_valor_inicial.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor final:";
            // 
            // txt_valor_final
            // 
            this.txt_valor_final.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor_final.Location = new System.Drawing.Point(419, 106);
            this.txt_valor_final.Name = "txt_valor_final";
            this.txt_valor_final.Size = new System.Drawing.Size(100, 29);
            this.txt_valor_final.TabIndex = 4;
            // 
            // label_despliegue
            // 
            this.label_despliegue.AutoSize = true;
            this.label_despliegue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_despliegue.Location = new System.Drawing.Point(353, 161);
            this.label_despliegue.Name = "label_despliegue";
            this.label_despliegue.Size = new System.Drawing.Size(122, 24);
            this.label_despliegue.TabIndex = 5;
            this.label_despliegue.Text = "Despliegue";
            // 
            // label_despliegue_todos
            // 
            this.label_despliegue_todos.AutoSize = true;
            this.label_despliegue_todos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_despliegue_todos.Location = new System.Drawing.Point(124, 197);
            this.label_despliegue_todos.Name = "label_despliegue_todos";
            this.label_despliegue_todos.Size = new System.Drawing.Size(296, 22);
            this.label_despliegue_todos.TabIndex = 6;
            this.label_despliegue_todos.Text = "Despliegue de todos los números";
            // 
            // label_despliegue_pares
            // 
            this.label_despliegue_pares.AutoSize = true;
            this.label_despliegue_pares.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_despliegue_pares.Location = new System.Drawing.Point(446, 197);
            this.label_despliegue_pares.Name = "label_despliegue_pares";
            this.label_despliegue_pares.Size = new System.Drawing.Size(217, 22);
            this.label_despliegue_pares.TabIndex = 7;
            this.label_despliegue_pares.Text = "Despliegue de los pares";
            // 
            // txt_despliegue_todos
            // 
            this.txt_despliegue_todos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_despliegue_todos.Location = new System.Drawing.Point(167, 222);
            this.txt_despliegue_todos.Multiline = true;
            this.txt_despliegue_todos.Name = "txt_despliegue_todos";
            this.txt_despliegue_todos.Size = new System.Drawing.Size(211, 309);
            this.txt_despliegue_todos.TabIndex = 8;
            // 
            // txt_despliegue_pares
            // 
            this.txt_despliegue_pares.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_despliegue_pares.Location = new System.Drawing.Point(450, 222);
            this.txt_despliegue_pares.Multiline = true;
            this.txt_despliegue_pares.Name = "txt_despliegue_pares";
            this.txt_despliegue_pares.Size = new System.Drawing.Size(211, 309);
            this.txt_despliegue_pares.TabIndex = 9;
            // 
            // txt_suma_todos
            // 
            this.txt_suma_todos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suma_todos.Location = new System.Drawing.Point(233, 537);
            this.txt_suma_todos.Name = "txt_suma_todos";
            this.txt_suma_todos.Size = new System.Drawing.Size(145, 29);
            this.txt_suma_todos.TabIndex = 11;
            // 
            // label_suma_todos
            // 
            this.label_suma_todos.AutoSize = true;
            this.label_suma_todos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_suma_todos.Location = new System.Drawing.Point(163, 540);
            this.label_suma_todos.Name = "label_suma_todos";
            this.label_suma_todos.Size = new System.Drawing.Size(64, 22);
            this.label_suma_todos.TabIndex = 10;
            this.label_suma_todos.Text = "Suma:";
            // 
            // txt_suma_pares
            // 
            this.txt_suma_pares.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suma_pares.Location = new System.Drawing.Point(514, 537);
            this.txt_suma_pares.Name = "txt_suma_pares";
            this.txt_suma_pares.Size = new System.Drawing.Size(147, 29);
            this.txt_suma_pares.TabIndex = 13;
            // 
            // label_suma_pares
            // 
            this.label_suma_pares.AutoSize = true;
            this.label_suma_pares.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_suma_pares.Location = new System.Drawing.Point(446, 540);
            this.label_suma_pares.Name = "label_suma_pares";
            this.label_suma_pares.Size = new System.Drawing.Size(64, 22);
            this.label_suma_pares.TabIndex = 12;
            this.label_suma_pares.Text = "Suma:";
            // 
            // btn_desplegar
            // 
            this.btn_desplegar.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desplegar.Location = new System.Drawing.Point(167, 591);
            this.btn_desplegar.Name = "btn_desplegar";
            this.btn_desplegar.Size = new System.Drawing.Size(147, 41);
            this.btn_desplegar.TabIndex = 14;
            this.btn_desplegar.Text = "Desplegar";
            this.btn_desplegar.UseVisualStyleBackColor = true;
            this.btn_desplegar.Click += new System.EventHandler(this.btn_desplegar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(332, 591);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(167, 41);
            this.btn_limpiar.TabIndex = 15;
            this.btn_limpiar.Text = "Limpiar valores";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(514, 591);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(147, 41);
            this.btn_salir.TabIndex = 16;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 704);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_desplegar);
            this.Controls.Add(this.txt_suma_pares);
            this.Controls.Add(this.label_suma_pares);
            this.Controls.Add(this.txt_suma_todos);
            this.Controls.Add(this.label_suma_todos);
            this.Controls.Add(this.txt_despliegue_pares);
            this.Controls.Add(this.txt_despliegue_todos);
            this.Controls.Add(this.label_despliegue_pares);
            this.Controls.Add(this.label_despliegue_todos);
            this.Controls.Add(this.label_despliegue);
            this.Controls.Add(this.txt_valor_final);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_valor_inicial);
            this.Controls.Add(this.label_valor_inicial);
            this.Controls.Add(this.label_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_valor_inicial;
        private System.Windows.Forms.TextBox txt_valor_inicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_valor_final;
        private System.Windows.Forms.Label label_despliegue;
        private System.Windows.Forms.Label label_despliegue_todos;
        private System.Windows.Forms.Label label_despliegue_pares;
        private System.Windows.Forms.TextBox txt_despliegue_todos;
        private System.Windows.Forms.TextBox txt_despliegue_pares;
        private System.Windows.Forms.TextBox txt_suma_todos;
        private System.Windows.Forms.Label label_suma_todos;
        private System.Windows.Forms.TextBox txt_suma_pares;
        private System.Windows.Forms.Label label_suma_pares;
        private System.Windows.Forms.Button btn_desplegar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
    }
}

