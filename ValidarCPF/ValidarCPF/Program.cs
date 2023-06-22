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
           
            int multi = 10, multi2 = 11, mult, mult2, soma = 0, soma2 = 0 , div;
            string num;
            char digito1, digito2;

            Console.WriteLine("Digite seu CPF");
            num = Console.ReadLine();



            char[] cpf = new char[11];
            int[] numeroCPF = new int[11];
            digito1 = cpf[9];
            digito2 = cpf[10];

            for (int i = 0; i < 9; i++){

                cpf[i] = num[i];
                numeroCPF[i] = num[i];

            }

            for (int i = 0;i < 9; i++){

                mult = cpf[i] * multi;
                multi --;

                soma += mult;
            }

            div = (soma * 10) % 11;

            if (div == 10){

                numeroCPF[9] = 0;

            }if else (div != 11){
                numeroCPF[9] = div;
            }

                

            


            for (int i = 0; i < 10; i++)
            {

                mult2 = cpf[i] * multi2;
                multi2--;

                soma2 += multi2;
            }
            div = (soma2 * 10) % 11;

            if (div == 11)
            {

                numeroCPF[10] = 0;

            }else{

                numeroCPF[10] = div;

            }


            if(digito1 == numeroCPF[9] && digito2 == numeroCPF[10]){

                Console.WriteLine("CPF Aprovado");

            }else{

                Console.WriteLine("CPF Negado");
            }





        }
    }
}
