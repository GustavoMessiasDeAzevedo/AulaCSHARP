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
           
            int multi = 10, multi2 = 11, mult, mult2, soma = 0, soma2 = 0 , div, div2;
            string num;
            char digito1, digito2, dig, dig2;

            Console.Write("Digite seu CPF (apenas números): ");
            num = Console.ReadLine();



            char[] cpf = new char[11];
            int[] numeroCPF = new int[11];


            for (int i = 0; i <= 10; i++){

                cpf[i] = num[i];
                numeroCPF[i] = Convert.ToInt32(cpf[i].ToString());

            }

                digito1 = cpf[9];
                digito2 = cpf[10];


            for (int i = 0;i < 9; i++){

                mult = numeroCPF[i] * multi;
                multi --;

                soma += mult;
            }

                div = (soma * 10) % 11;
         
            if (div == 10){

                numeroCPF[9] = 0;

            }else if (div != 11){
                numeroCPF[9] = div;
            }

            for (int i = 0; i < 10; i++)
            {

                mult2 = numeroCPF[i] * multi2;
                multi2--;

                soma2 += mult2;
            }
            div2 = (soma2 * 10) % 11;
      
            if (div2 == 11)
            {

                numeroCPF[10] = 0;

            }else if(div2 != 11){

                numeroCPF[10] = div2;

            }

            dig = Convert.ToChar(numeroCPF[9].ToString());
            dig2 = Convert.ToChar(numeroCPF[10].ToString());


            if (dig == digito1 && dig2 == digito2){

                Console.WriteLine("CPF Aprovado");

            }else{

                Console.WriteLine("CPF Negado");
            }
        }
    }
}
