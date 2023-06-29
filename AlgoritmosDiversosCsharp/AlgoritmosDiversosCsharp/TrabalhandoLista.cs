using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosDiversosCsharp
{
    internal class TrabalhandoLista
    {

        static void ImprimeLista(List<int> lista, String titulo){

            Console.WriteLine("=========="+ titulo + "==========");

            foreach (int num in lista)
            {
                Console.WriteLine(num);
            }
        }
        static void Main()
        {
            //Add: Adicionando elemento na lista
            List<int> lista = new List<int>();
            lista.Add(1);
            lista.Add(90);
            lista.Add(50);
            lista.Add(10);
            lista.Add(40);
            lista.Add(70);

            ImprimeLista(lista, "Adicionando elemento na lista");



            //Remove: Remove a primeira ocorrência de um elemento da lista
            lista.Remove(10);

            ImprimeLista(lista, "Removendo um elemento na lista");

       

            //RemoveAt: Remove o elemento de um indicie 

            lista.RemoveAt(0);

            ImprimeLista(lista, "Removendo um elemento de um indice");


            //Sort: Ordernar os elementos em ordem crescente

            lista.Sort();

            ImprimeLista(lista, "Ordena Lista");

            //Reverse: Ordernar os elementos em ordem decrescente

            lista.Reverse();

            ImprimeLista(lista, "Ordem inversa");

            //Count: Retorna a quantidade de elementos na lista

            int numeroItem = lista.Count();
            Console.WriteLine("Existe {0} itens na lista", numeroItem);


            //Contains: Verifica se a lista contem um determinado elemento

            if (lista.Contains(40)){

                Console.WriteLine("Foi encontrado o item na lista");
            }else{

                Console.WriteLine("Não foi encontrado nenhum item na lista");
            }

            //Insert: Insere um elemento em um determinado indice da lista

            lista.Insert(2, 45);

            ImprimeLista(lista, "Insere um elemento em um determinado indice da lista");

            //Clear: Limpar os itens da lista

            lista.Clear();
        }
    }
}
