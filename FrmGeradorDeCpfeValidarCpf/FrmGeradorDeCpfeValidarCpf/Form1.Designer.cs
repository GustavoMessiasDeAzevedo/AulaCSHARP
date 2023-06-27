namespace FrmGeradorDeCpfeValidarCpf
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblDigiteCPF = new System.Windows.Forms.Label();
            this.Lbl = new System.Windows.Forms.Label();
            this.btnValidarCPF = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.btnGeradorCPF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblDigiteCPF
            // 
            this.LblDigiteCPF.AutoSize = true;
            this.LblDigiteCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDigiteCPF.ForeColor = System.Drawing.Color.Blue;
            this.LblDigiteCPF.Location = new System.Drawing.Point(197, 33);
            this.LblDigiteCPF.Name = "LblDigiteCPF";
            this.LblDigiteCPF.Size = new System.Drawing.Size(224, 39);
            this.LblDigiteCPF.TabIndex = 0;
            this.LblDigiteCPF.Text = "Digite o CPF";
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl.ForeColor = System.Drawing.Color.Blue;
            this.Lbl.Location = new System.Drawing.Point(167, 251);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(283, 39);
            this.Lbl.TabIndex = 1;
            this.Lbl.Text = "Gerador de CPF";
            // 
            // btnValidarCPF
            // 
            this.btnValidarCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarCPF.Location = new System.Drawing.Point(204, 154);
            this.btnValidarCPF.Name = "btnValidarCPF";
            this.btnValidarCPF.Size = new System.Drawing.Size(193, 54);
            this.btnValidarCPF.TabIndex = 3;
            this.btnValidarCPF.Text = "Validar CPF";
            this.btnValidarCPF.UseVisualStyleBackColor = true;
            this.btnValidarCPF.Click += new System.EventHandler(this.btnValidarCPF_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(97, 293);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(420, 62);
            this.textBox2.TabIndex = 5;
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(97, 75);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(420, 62);
            this.txtCPF.TabIndex = 6;
            // 
            // btnGeradorCPF
            // 
            this.btnGeradorCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeradorCPF.Location = new System.Drawing.Point(204, 372);
            this.btnGeradorCPF.Name = "btnGeradorCPF";
            this.btnGeradorCPF.Size = new System.Drawing.Size(193, 54);
            this.btnGeradorCPF.TabIndex = 7;
            this.btnGeradorCPF.Text = "Gerar CPF";
            this.btnGeradorCPF.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 473);
            this.Controls.Add(this.btnGeradorCPF);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnValidarCPF);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.LblDigiteCPF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDigiteCPF;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.Button btnValidarCPF;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Button btnGeradorCPF;
    }
}

