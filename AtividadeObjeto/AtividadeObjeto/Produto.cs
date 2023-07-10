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

        public int total;
        private List<string> nome;


        public Produto(string nome = "", int preco = 0, int Total = 0)
        {
            Nome = nome;
            Preco = preco;
            total = Total;
        }

 

        public void ImprimirDetalhesProduto()
        {
 
            Console.WriteLine("Total: {0}", total);
            Console.WriteLine("====================");
        }


  
    }
}
