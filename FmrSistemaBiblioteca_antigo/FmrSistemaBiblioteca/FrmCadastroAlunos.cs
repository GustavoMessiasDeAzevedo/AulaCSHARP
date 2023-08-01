using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FmrSistemaBiblioteca
{
    public partial class FrmCadastroAluno : Form
    {
        public string conexaoString;
        private SqlConnection conexaoDB;
        public FrmCadastroAluno()
        {
            InitializeComponent();

            conexaoString = "Data Source=.;Initial Catalog=Biblioteca;Integrated Security=True";

            conexaoDB = new SqlConnection(conexaoString);
        }



        private void FrmCadastroAluno_Load(object sender, EventArgs e)
        {
            CarregarDadosAlunos();
        }

        private void CarregarDadosAlunos()
        {
            try
            {

                conexaoDB.Open();
                string sql = " SELECT * FROM Alunos";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conexaoDB);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                DgvAlunos.DataSource = dataTable;

                conexaoDB.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO Alunos (Nome, CPF, Email, Telefone, Celular, Data_Nascimento) Values (@Nome, @CPF, @Email, @Telefone, @Celular, @Data_Nascimento)";

                conexaoDB.Open();

                SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                sqlCmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                sqlCmd.Parameters.AddWithValue("@CPF", txtCPF.Text);
                sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                sqlCmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                sqlCmd.Parameters.AddWithValue("@Celular", txtCelular.Text);

                DateTime dataNascimento;
                DateTime.TryParse(txtDataNascimento.Text, out dataNascimento);


                sqlCmd.Parameters.AddWithValue("@Data_Nascimento", txtCelular.Text);
            }
        }
    }
}
