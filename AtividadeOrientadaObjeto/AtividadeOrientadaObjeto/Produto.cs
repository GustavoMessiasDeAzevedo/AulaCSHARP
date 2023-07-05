using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeOrientadaObjeto
{
    internal class Produto
    {

        public string NomeProduto;
        public double Preco;

        public Produto(string nomeProduto = "", double preco = 0.0)
        {
            NomeProduto = nomeProduto;
            Preco = preco;
        }
    }
}
