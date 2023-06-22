using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o CPF (Apenas numeros): ");
            string cpf = Console.ReadLine();

            char[] numerosCpf = cpf.ToCharArray();

            for (int i = 0; i < numerosCpf.Length; i++){

                Console.WriteLine(numerosCpf[i]);

            }



            Console.WriteLine("====================================");

            foreach(char numero in numerosCpf){

                Console.WriteLine(numero);

            }

            int[] numeroInteiro = numerosCpf.Select(numero => Convert.ToInt32(numero.ToString())).ToArray();]
        }
    }
}
