﻿using System;
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


            Console.WriteLine("Digite seu CPF");
            num = Console.ReadLine();



            char[] cpf = new char[11];
            int[] numeroCPF = new int[11];


            for (int i = 0; i < 9; i++){

                cpf[i] = num[i];
                numeroCPF[i] = Convert.ToInt32(cpf[i].ToString());

            }

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

            
            
            
            if (cpf[9] == numeroCPF[9] && cpf[10] == numeroCPF[10]){

                Console.WriteLine("CPF Aprovado");

            }else{

                Console.WriteLine("CPF Negado");
            }
        }
    }
}
