namespace COSA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.cosa = new System.Windows.Forms.Label();
            this.BotonAparece = new System.Windows.Forms.Button();
            this.OtraCosa = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.IVA = new System.Windows.Forms.Label();
            this.TOTAL = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 124);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(383, 141);
            this.CalcularButton.Margin = new System.Windows.Forms.Padding(2);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(79, 19);
            this.CalcularButton.TabIndex = 1;
            this.CalcularButton.Text = "CALCULAR";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.Boton_Click);
            // 
            // cosa
            // 
            this.cosa.AutoSize = true;
            this.cosa.Location = new System.Drawing.Point(226, 274);
            this.cosa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cosa.Name = "cosa";
            this.cosa.Size = new System.Drawing.Size(35, 13);
            this.cosa.TabIndex = 2;
            this.cosa.Text = "label1";
            this.cosa.Click += new System.EventHandler(this.label1_Click);
            // 
            // BotonAparece
            // 
            this.BotonAparece.Location = new System.Drawing.Point(232, 96);
            this.BotonAparece.Name = "BotonAparece";
            this.BotonAparece.Size = new System.Drawing.Size(75, 23);
            this.BotonAparece.TabIndex = 3;
            this.BotonAparece.Text = "button1";
            this.BotonAparece.UseVisualStyleBackColor = true;
            this.BotonAparece.Click += new System.EventHandler(this.BotonAparece_Click);
            // 
            // OtraCosa
            // 
            this.OtraCosa.Location = new System.Drawing.Point(233, 67);
            this.OtraCosa.Name = "OtraCosa";
            this.OtraCosa.Size = new System.Drawing.Size(75, 23);
            this.OtraCosa.TabIndex = 4;
            this.OtraCosa.Text = "button1";
            this.OtraCosa.UseVisualStyleBackColor = true;
            this.OtraCosa.Click += new System.EventHandler(this.OtraCosa_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(233, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "0";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(232, 175);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "0";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // IVA
            // 
            this.IVA.AutoSize = true;
            this.IVA.Location = new System.Drawing.Point(234, 309);
            this.IVA.Name = "IVA";
            this.IVA.Size = new System.Drawing.Size(24, 13);
            this.IVA.TabIndex = 7;
            this.IVA.Text = "IVA";
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSize = true;
            this.TOTAL.Location = new System.Drawing.Point(234, 332);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(42, 13);
            this.TOTAL.TabIndex = 8;
            this.TOTAL.Text = "TOTAL";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(232, 201);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "0";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(233, 227);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "0";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.TOTAL);
            this.Controls.Add(this.IVA);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.OtraCosa);
            this.Controls.Add(this.BotonAparece);
            this.Controls.Add(this.cosa);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Label cosa;
        private System.Windows.Forms.Button BotonAparece;
        private System.Windows.Forms.Button OtraCosa;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label IVA;
        private System.Windows.Forms.Label TOTAL;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

