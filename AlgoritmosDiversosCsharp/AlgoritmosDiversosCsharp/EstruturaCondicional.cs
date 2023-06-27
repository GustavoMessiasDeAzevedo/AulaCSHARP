using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosDiversosCsharp
{
    internal class EstruturaCondicional
    {


        static void Main()
        {

            Console.WriteLine("======== Estrutura Condicional ========");


            int nota = 8;


            //estrutura simples
            if (nota >= 7)
            {
                Console.WriteLine("Aluno aprovado");
            }

            Console.WriteLine("=========================================================");

            //estrutura composta
            if (nota >= 7){
                Console.WriteLine("Aluno aprovado");
            }else{
                Console.WriteLine("Aluno reprovado");
            }

            Console.WriteLine("=========================================================");

            if(nota >= 9) {

                Console.WriteLine("Aluno nota A");
            }else if (nota >= 7) {

                Console.WriteLine("Aluno nota B");
            }else if (nota >= 5) {

                Console.WriteLine("Aluno nota C");
            }else if (nota >= 3){

                Console.WriteLine("Aluno nota D");
            }else{

                Console.WriteLine("Aluno nota E");
            }

            Console.WriteLine("=========================================================");

            string cor = "Vermelho";

            switch (cor.ToLower()){

                case "verde":
                    Console.WriteLine("A cor é verde");
                    break;

                case "Vermelho":
                    Console.WriteLine("A cor é vermelho");
                    break;

                case "Azul":
                    Console.WriteLine("A cor é azul");
                    break;

                default:
                    Console.WriteLine("A cor não foi reconhecida");
                    break;

            }

        }
            
    
    }
}
