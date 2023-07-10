using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            string Produtos;
            string preco;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("====================");
            Cliente cliente = new Cliente(idCliente: 1, nome: nome);


            List<string> lista = new List<string>();
            List<int> lista_ = new List<int>();
            Produto produto = new Produto();
            while (true)
            {


                Console.Write("Digite um produto: ");
                produto.Nome = Console.ReadLine();
                Console.WriteLine("====================");

                if (produto.Nome.ToLower() == "parar")
                {
                    break;
                }

                Console.Write("Digite o preço: ");
                preco = Console.ReadLine();
                Console.WriteLine("====================");


                produto.Preco = Convert.ToInt32(preco.ToString());



                lista.Add(produto.Nome);
                lista_.Add(produto.Preco);
                Console.WriteLine("Item adicionado com sucesso!");
                Console.WriteLine("====================");
            }

            while (true)
            {
                produto.total = lista_.Sum();

                if (produto.Nome == "parar")
                {
                    break;
                }
            }


          
            

            produto = new Produto(nome: produto.Nome, preco: produto.Preco, Total: produto.total);

            

            produto.ImprimirDetalhesProduto();
            foreach (string item in lista)
            {
                Console.WriteLine("====================");
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine("====================");
            cliente.ImprimirDetalhes();
        }
    }
}
