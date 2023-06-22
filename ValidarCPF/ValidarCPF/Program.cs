using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multi = 10;
            int multi2 = 11, mult, soma = 0, soma2 = 0;
            string num;
            char digito1, digito2;

            Console.WriteLine("Digite seu CPF");
            num = Console.ReadLine();



            char[] cpf = new char[9];
            for (int i = 0; i < 9; i++){

                cpf[i] = num[i];

            }

            for (int i = 0;i < 9; i++){

                mult = cpf[i] * multi;
                multi--;

                soma += mult;
            }

            for (int i = 0; i < 10; i++)
            {

                mult = cpf[i] * multi2;
                multi2--;

                soma2 += mult;
            }





        }
    }
}
