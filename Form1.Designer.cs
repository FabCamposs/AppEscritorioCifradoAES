namespace AppDesktopCifradoAES
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.txtCifrado = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtVector = new System.Windows.Forms.TextBox();
            this.txtSaltos = new System.Windows.Forms.TextBox();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.btnDescifrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(64, 72);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(425, 31);
            this.txtTexto.TabIndex = 0;
            // 
            // txtCifrado
            // 
            this.txtCifrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCifrado.Location = new System.Drawing.Point(64, 278);
            this.txtCifrado.Name = "txtCifrado";
            this.txtCifrado.Size = new System.Drawing.Size(425, 31);
            this.txtCifrado.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(64, 150);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(120, 31);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // txtVector
            // 
            this.txtVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVector.Location = new System.Drawing.Point(213, 150);
            this.txtVector.Name = "txtVector";
            this.txtVector.Size = new System.Drawing.Size(120, 31);
            this.txtVector.TabIndex = 3;
            // 
            // txtSaltos
            // 
            this.txtSaltos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaltos.Location = new System.Drawing.Point(369, 150);
            this.txtSaltos.Name = "txtSaltos";
            this.txtSaltos.Size = new System.Drawing.Size(120, 31);
            this.txtSaltos.TabIndex = 4;
            // 
            // btnCifrar
            // 
            this.btnCifrar.Location = new System.Drawing.Point(136, 210);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(103, 34);
            this.btnCifrar.TabIndex = 5;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Click += new System.EventHandler(this.BtnCifrar_Click);
            // 
            // btnDescifrar
            // 
            this.btnDescifrar.Location = new System.Drawing.Point(315, 210);
            this.btnDescifrar.Name = "btnDescifrar";
            this.btnDescifrar.Size = new System.Drawing.Size(103, 34);
            this.btnDescifrar.TabIndex = 6;
            this.btnDescifrar.Text = "Descifrar";
            this.btnDescifrar.UseVisualStyleBackColor = true;
            this.btnDescifrar.Click += new System.EventHandler(this.BtnDescifrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cifrado-Descifrado AES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Texto  cifrar ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vector ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Saltos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Texto cifrado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(551, 349);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDescifrar);
            this.Controls.Add(this.btnCifrar);
            this.Controls.Add(this.txtSaltos);
            this.Controls.Add(this.txtVector);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtCifrado);
            this.Controls.Add(this.txtTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.TextBox txtCifrado;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtVector;
        private System.Windows.Forms.TextBox txtSaltos;
        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.Button btnDescifrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

