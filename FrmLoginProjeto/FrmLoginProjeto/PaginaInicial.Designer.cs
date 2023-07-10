namespace FrmLoginProjeto
{
    partial class PaginaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaInicial));
            this.BtnReciclar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblNomeFerroVelho = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblCNPJ = new System.Windows.Forms.Label();
            this.LblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnReciclar
            // 
            this.BtnReciclar.Location = new System.Drawing.Point(70, 125);
            this.BtnReciclar.Name = "BtnReciclar";
            this.BtnReciclar.Size = new System.Drawing.Size(262, 47);
            this.BtnReciclar.TabIndex = 0;
            this.BtnReciclar.Text = "Adicionar Reciclagem";
            this.BtnReciclar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gerenciar Reciclagem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Remover Reciclagem";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(488, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 308);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LblNomeFerroVelho
            // 
            this.LblNomeFerroVelho.AutoSize = true;
            this.LblNomeFerroVelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeFerroVelho.Location = new System.Drawing.Point(546, 385);
            this.LblNomeFerroVelho.Name = "LblNomeFerroVelho";
            this.LblNomeFerroVelho.Size = new System.Drawing.Size(80, 25);
            this.LblNomeFerroVelho.TabIndex = 4;
            this.LblNomeFerroVelho.Text = "Nome: ";
            // 
            // LblNome
            // 
            this.LblNome.AllowDrop = true;
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(632, 385);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(92, 25);
            this.LblNome.TabIndex = 5;
            this.LblNome.Text = "Gustavo";
            this.LblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblCNPJ
            // 
            this.LblCNPJ.AutoSize = true;
            this.LblCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCNPJ.Location = new System.Drawing.Point(548, 444);
            this.LblCNPJ.Name = "LblCNPJ";
            this.LblCNPJ.Size = new System.Drawing.Size(79, 25);
            this.LblCNPJ.TabIndex = 6;
            this.LblCNPJ.Text = "CNPJ: ";
            this.LblCNPJ.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.Location = new System.Drawing.Point(632, 444);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(67, 25);
            this.LblInfo.TabIndex = 7;
            this.LblInfo.Text = "CNPJ";
            // 
            // PaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(876, 568);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.LblCNPJ);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.LblNomeFerroVelho);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnReciclar);
            this.Name = "PaginaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaginaInicial";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReciclar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblNomeFerroVelho;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblCNPJ;
        private System.Windows.Forms.Label LblInfo;
    }
}