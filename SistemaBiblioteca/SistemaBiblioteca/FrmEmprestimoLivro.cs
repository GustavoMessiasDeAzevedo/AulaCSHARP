using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class FrmEmprestimoLivro : Form
    {
        public string conexaoString;
        private SqlConnection conexaoDB;
        DataGridView linhaSelecionada;
        public FrmEmprestimoLivro()
        {
            InitializeComponent();

            conexaoString = "Data Source=MAR0625654w10-1;Initial Catalog=Biblioteca;Integrated Security=True";

            conexaoDB = new SqlConnection(conexaoString);
        }

        public void carregarEmprestimoLivros(int id = 0)
        {
            try
            {
                conexaoDB.Open();

                string sql;

                if(id == 0)
                {
                    sql = "select * from emprestimos";
                }
                else
                {
                    sql = "select * from emprestimos WHERE id=" + id;
                }

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conexaoDB);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dvgEmprestimo.DataSource = dataTable;
                conexaoDB.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex);
            }
        }

        private void FrmEmprestimoLivro_Load(object sender, EventArgs e)
        {
            carregarEmprestimoLivros();
        }

        private void btnEmprestar_Click(object sender, EventArgs e)
        {

        }
    }
}
