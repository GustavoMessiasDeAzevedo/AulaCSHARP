using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosDiversosCsharp
{
    internal class ListadeCompras
    {

        static void ImprimirLista(List<string> listaDeCompra)
        {
                foreach (string compra in listaDeCompra)
                {
                Console.WriteLine(compra);   
                }
        }

        static void Main()
        {
            List<string> listaDeCompra = new List<string>();

            Console.WriteLine(": : : : : : :  Programa de lista de compras  : : : : : : :");


            while (true){

                Console.Write("Digite um item para adicionar à lista (ou 'parar' para sair): ");

                string item = Console.ReadLine();

                if (item.ToLower() == "parar"){
                    break;
                }

                listaDeCompra.Add(item);
                Console.WriteLine("Item adicionado com sucesso!");

            }

            Console.WriteLine("-----------------");
            Console.WriteLine("  Cupom Fiscal  ");
            Console.WriteLine("-----------------");

            if (listaDeCompra.Count == 0) {

                Console.WriteLine("A lista ta vazia");
            }else{
                ImprimirLista(listaDeCompra);
                Console.WriteLine("-----------------");
            }

            

            //Imprimir a lista, porem caso esteja vazia, retornar o texto "A lista ta vazia",
            //caso contrario imprimir todos os itens na tela
        }
    }
}
