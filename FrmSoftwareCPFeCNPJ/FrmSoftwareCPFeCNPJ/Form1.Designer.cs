﻿namespace FrmSoftwareCPFeCNPJ
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
            this.BtnSair = new System.Windows.Forms.Button();
            this.txtCPForCNPJ = new System.Windows.Forms.TextBox();
            this.RadCPF = new System.Windows.Forms.RadioButton();
            this.RadCNPJ = new System.Windows.Forms.RadioButton();
            this.BtnValidar = new System.Windows.Forms.Button();
            this.LblEntrada = new System.Windows.Forms.Label();
            this.MenuGerar = new System.Windows.Forms.MenuStrip();
            this.MenuGERADOR = new System.Windows.Forms.ToolStripMenuItem();
            this.validarCPFECNPJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarCPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnGerar = new System.Windows.Forms.Button();
            this.MenuGerar.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.Blue;
            this.BtnSair.Location = new System.Drawing.Point(328, 299);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(168, 41);
            this.BtnSair.TabIndex = 1;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // txtCPForCNPJ
            // 
            this.txtCPForCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPForCNPJ.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtCPForCNPJ.Location = new System.Drawing.Point(173, 161);
            this.txtCPForCNPJ.Name = "txtCPForCNPJ";
            this.txtCPForCNPJ.ReadOnly = true;
            this.txtCPForCNPJ.Size = new System.Drawing.Size(362, 47);
            this.txtCPForCNPJ.TabIndex = 2;
            // 
            // RadCPF
            // 
            this.RadCPF.AutoSize = true;
            this.RadCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadCPF.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.RadCPF.Location = new System.Drawing.Point(109, 59);
            this.RadCPF.Name = "RadCPF";
            this.RadCPF.Size = new System.Drawing.Size(72, 29);
            this.RadCPF.TabIndex = 3;
            this.RadCPF.TabStop = true;
            this.RadCPF.Text = "CPF";
            this.RadCPF.UseVisualStyleBackColor = true;
            // 
            // RadCNPJ
            // 
            this.RadCNPJ.AutoSize = true;
            this.RadCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadCNPJ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RadCNPJ.Location = new System.Drawing.Point(355, 59);
            this.RadCNPJ.Name = "RadCNPJ";
            this.RadCNPJ.Size = new System.Drawing.Size(85, 29);
            this.RadCNPJ.TabIndex = 4;
            this.RadCNPJ.TabStop = true;
            this.RadCNPJ.Text = "CNPJ";
            this.RadCNPJ.UseVisualStyleBackColor = true;
            // 
            // BtnValidar
            // 
            this.BtnValidar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnValidar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnValidar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValidar.ForeColor = System.Drawing.Color.Blue;
            this.BtnValidar.Location = new System.Drawing.Point(63, 299);
            this.BtnValidar.Name = "BtnValidar";
            this.BtnValidar.Size = new System.Drawing.Size(168, 41);
            this.BtnValidar.TabIndex = 5;
            this.BtnValidar.Text = "Validar";
            this.BtnValidar.UseVisualStyleBackColor = false;
            this.BtnValidar.Click += new System.EventHandler(this.BtnValidar_Click);
            // 
            // LblEntrada
            // 
            this.LblEntrada.AutoSize = true;
            this.LblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEntrada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblEntrada.Location = new System.Drawing.Point(29, 169);
            this.LblEntrada.Name = "LblEntrada";
            this.LblEntrada.Size = new System.Drawing.Size(138, 39);
            this.LblEntrada.TabIndex = 6;
            this.LblEntrada.Text = "Entrada";
            // 
            // MenuGerar
            // 
            this.MenuGerar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuGERADOR});
            this.MenuGerar.Location = new System.Drawing.Point(0, 0);
            this.MenuGerar.Name = "MenuGerar";
            this.MenuGerar.Size = new System.Drawing.Size(562, 24);
            this.MenuGerar.TabIndex = 7;
            this.MenuGerar.Text = "menuStrip1";
            // 
            // MenuGERADOR
            // 
            this.MenuGERADOR.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validarCPFECNPJToolStripMenuItem,
            this.gerarCPFToolStripMenuItem});
            this.MenuGERADOR.Name = "MenuGERADOR";
            this.MenuGERADOR.Size = new System.Drawing.Size(50, 20);
            this.MenuGERADOR.Text = "Menu";
            // 
            // validarCPFECNPJToolStripMenuItem
            // 
            this.validarCPFECNPJToolStripMenuItem.Name = "validarCPFECNPJToolStripMenuItem";
            this.validarCPFECNPJToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.validarCPFECNPJToolStripMenuItem.Text = "Validar CPF e CNPJ";
            this.validarCPFECNPJToolStripMenuItem.Click += new System.EventHandler(this.validarCPFECNPJToolStripMenuItem_Click);
            // 
            // gerarCPFToolStripMenuItem
            // 
            this.gerarCPFToolStripMenuItem.Name = "gerarCPFToolStripMenuItem";
            this.gerarCPFToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gerarCPFToolStripMenuItem.Text = "Gerar CPF";
            this.gerarCPFToolStripMenuItem.Click += new System.EventHandler(this.gerarCPFToolStripMenuItem_Click);
            // 
            // BtnGerar
            // 
            this.BtnGerar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGerar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerar.ForeColor = System.Drawing.Color.Blue;
            this.BtnGerar.Location = new System.Drawing.Point(63, 299);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(168, 41);
            this.BtnGerar.TabIndex = 8;
            this.BtnGerar.Text = "Gerar";
            this.BtnGerar.UseVisualStyleBackColor = false;
            this.BtnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnValidar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.CancelButton = this.BtnSair;
            this.ClientSize = new System.Drawing.Size(562, 411);
            this.Controls.Add(this.BtnGerar);
            this.Controls.Add(this.LblEntrada);
            this.Controls.Add(this.BtnValidar);
            this.Controls.Add(this.RadCNPJ);
            this.Controls.Add(this.RadCPF);
            this.Controls.Add(this.txtCPForCNPJ);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.MenuGerar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validador de CPF e CNPJ";
            this.MenuGerar.ResumeLayout(false);
            this.MenuGerar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.TextBox txtCPForCNPJ;
        private System.Windows.Forms.RadioButton RadCPF;
        private System.Windows.Forms.RadioButton RadCNPJ;
        private System.Windows.Forms.Button BtnValidar;
        private System.Windows.Forms.Label LblEntrada;
        private System.Windows.Forms.MenuStrip MenuGerar;
        private System.Windows.Forms.ToolStripMenuItem MenuGERADOR;
        private System.Windows.Forms.ToolStripMenuItem validarCPFECNPJToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarCPFToolStripMenuItem;
        private System.Windows.Forms.Button BtnGerar;
    }
}

