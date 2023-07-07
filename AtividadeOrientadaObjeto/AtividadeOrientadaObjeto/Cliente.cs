using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeOrientadaObjeto
{
    internal class Cliente
    {
        public int IdCliente;
        public string Nome;
        public int CPF;


        /*public Cliente(int idCliente = 0, string nome = "", int cPF = 0)
        {
            IdCliente = idCliente;
            Nome = nome;
            CPF = cPF;
        }*/

        public void ImprimirDados()
        {
            Console.WriteLine("Id Cliente: {0}", IdCliente);
            Console.WriteLine("Nome: {0}", Nome);
            Console.WriteLine("CPF: {0}", CPF);
        }

    }
}
