using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeObjeto
{
    internal class Cliente
    {

        public int IdCliente;
        public string Nome;

        public Cliente(int idCliente = 0, string nome = "") { 
            IdCliente = idCliente;
            Nome = nome;
        }


        public void  ImprimirDetalhes()
        {
         
            Console.WriteLine("Id cliente: {0}", IdCliente);
            Console.WriteLine("Nome Cliente: {0}", Nome);
            Console.WriteLine("====================");
        }
    }
}
