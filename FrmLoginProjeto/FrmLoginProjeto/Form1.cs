using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLoginProjeto
{
    public partial class Form1 : Form
    {
        private List<string> listaEmail = new List<string>(); 
        private List<string> listaSenha = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }



        private void btnListar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            if (email.Length == 0 && senha.Length == 0)
            {
                MessageBox.Show("Nenhum campo foi preenchido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            listaEmail.Add(txtEmail.Text);
            listaSenha.Add(txtSenha.Text);

            txtEmail.Clear();
            txtSenha.Clear();

            MessageBox.Show("Seu email e senha foram listados com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogar_Click_1(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            if (listaEmail.Contains(email) && listaSenha.Contains(senha)) 
            {
                MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Email ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtEmail.Clear();
            txtSenha.Clear();
        }
    }
}

