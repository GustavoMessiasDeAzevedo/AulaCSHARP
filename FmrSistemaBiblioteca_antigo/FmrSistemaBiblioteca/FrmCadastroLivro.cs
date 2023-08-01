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

namespace FmrSistemaBiblioteca
{
    public partial class FrmCadastroLivro : Form
    {
        public string conexaoString;
        private SqlConnection conexaoDB;
        public FrmCadastroLivro()
        {
            InitializeComponent();

            conexaoString = "Data Source=.;Initial Catalog=Biblioteca;Integrated Security=True";
            conexaoDB = new SqlConnection(conexaoString);
        }



        public void FmrCadastroLivro_load(object sender, EventArgs e)
        {

            CarregarDadosLivros();

        }

        private void CarregarDadosLivros()
        {
            try
            {
                conexaoDB.Open();

                string sql = "SELECT * FROM Livros";
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sql, conexaoDB);
                DataTable dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);

                DgvLivros.DataSource = dataTable;

                conexaoDB.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex);
            }

        }

    
    }
}
