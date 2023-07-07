using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeObjeto
{
    internal class Produto
    {

        public string Nome;
        public int Preco;
        public int Quantidade;
        public int total;

        public List<Produto> Produtos;


        public void AdicionarProduto()
        {
            Produtos
        }

        public void ImprimirDetalhesProduto()
        {
            Console.WriteLine("====================");
            Console.WriteLine("Nome produto: {0}", Nome);
            Console.WriteLine("Preço: {0}", Preco);
            Console.WriteLine("Quantidade comprada: {0}", Quantidade);
            Console.WriteLine("====================");
        }


        public void CalcularPreco()
        {
            total = Preco * Quantidade;

            Console.WriteLine("O total da compra foi: {0}", total);
            
        }
    }
}
