using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosDiversosCsharp
{
    internal class LacoDeRepeticao
    {

        static void Main()
        {

            Console.WriteLine("======== Laço de repetição ========");

            int contador = 0;

            while(contador <= 5){

                Console.WriteLine("O valor do contador é: " + contador);
                contador++;
            }

            Console.WriteLine("=========================================================");

            

            for(contador = 0; contador <= 5; contador++){

                Console.WriteLine("O valor do contador é: " + contador);
            }

            Console.WriteLine("=========================================================");

            for (int i = 0; i <= 5; i++) {
                Console.WriteLine("O valor do contador é: " + i);
            }


            Console.WriteLine("=========================================================");
            contador = 0;
            do
            {
                Console.WriteLine("O valor do contador é: " + contador);
                contador ++;
            }while(contador <= 5);


            Console.WriteLine("=========================================================");


            string[] frutas = { "maça", "banana", "laranja", "tomate" };

            for(int i = 0; i < frutas.Length; i++) {
                Console.WriteLine(frutas[i]);
            }


            Console.WriteLine("=========================================================");


            foreach(string fruta in frutas) {  
                Console.WriteLine(fruta);
            }
        }
    }
}
