using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeObjeto
{
    internal class Venda
    {

        static void Main()
        {
            string nome;


            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Cliente cliente = new Cliente(idCliente:1, nome: nome);

            cliente.ImprimirDetalhes();
        }
    }
}
