namespace SistemaBiblioteca
{
    partial class FrmEmprestimoLivro
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblLivro = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dvgEmprestimo = new System.Windows.Forms.DataGridView();
            this.btnEmprestar = new System.Windows.Forms.Button();
            this.txtDataRetirada = new System.Windows.Forms.TextBox();
            this.txtDataDevolucao = new System.Windows.Forms.TextBox();
            this.lblDataRetirada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(24, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(68, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivro.Location = new System.Drawing.Point(24, 115);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(141, 25);
            this.lblLivro.TabIndex = 1;
            this.lblLivro.Text = "Titulo do livro";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(27, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(740, 31);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(27, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(740, 31);
            this.textBox2.TabIndex = 3;
            // 
            // dvgEmprestimo
            // 
            this.dvgEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEmprestimo.Location = new System.Drawing.Point(12, 271);
            this.dvgEmprestimo.Name = "dvgEmprestimo";
            this.dvgEmprestimo.Size = new System.Drawing.Size(776, 167);
            this.dvgEmprestimo.TabIndex = 4;
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestar.Location = new System.Drawing.Point(27, 226);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(138, 39);
            this.btnEmprestar.TabIndex = 5;
            this.btnEmprestar.Text = "Empréstimo ";
            this.btnEmprestar.UseVisualStyleBackColor = true;
            this.btnEmprestar.Click += new System.EventHandler(this.btnEmprestar_Click);
            // 
            // txtDataRetirada
            // 
            this.txtDataRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataRetirada.Location = new System.Drawing.Point(611, 228);
            this.txtDataRetirada.Name = "txtDataRetirada";
            this.txtDataRetirada.Size = new System.Drawing.Size(156, 31);
            this.txtDataRetirada.TabIndex = 6;
            // 
            // txtDataDevolucao
            // 
            this.txtDataDevolucao.BackColor = System.Drawing.Color.White;
            this.txtDataDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataDevolucao.Location = new System.Drawing.Point(398, 228);
            this.txtDataDevolucao.Name = "txtDataDevolucao";
            this.txtDataDevolucao.Size = new System.Drawing.Size(156, 31);
            this.txtDataDevolucao.TabIndex = 7;
            // 
            // lblDataRetirada
            // 
            this.lblDataRetirada.AutoSize = true;
            this.lblDataRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataRetirada.Location = new System.Drawing.Point(393, 200);
            this.lblDataRetirada.Name = "lblDataRetirada";
            this.lblDataRetirada.Size = new System.Drawing.Size(124, 20);
            this.lblDataRetirada.TabIndex = 8;
            this.lblDataRetirada.Text = "Data de retirada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(606, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data de devolução";
            // 
            // FrmEmprestimoLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDataRetirada);
            this.Controls.Add(this.txtDataDevolucao);
            this.Controls.Add(this.txtDataRetirada);
            this.Controls.Add(this.btnEmprestar);
            this.Controls.Add(this.dvgEmprestimo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblLivro);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmEmprestimoLivro";
            this.Text = "FrmEmprestimoLivro";
            this.Load += new System.EventHandler(this.FrmEmprestimoLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmprestimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dvgEmprestimo;
        private System.Windows.Forms.Button btnEmprestar;
        private System.Windows.Forms.TextBox txtDataRetirada;
        private System.Windows.Forms.TextBox txtDataDevolucao;
        private System.Windows.Forms.Label lblDataRetirada;
        private System.Windows.Forms.Label label1;
    }
}