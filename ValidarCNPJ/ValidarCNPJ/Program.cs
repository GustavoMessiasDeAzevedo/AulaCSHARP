using System;




namespace validar_cnpj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] multiplicacao = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicacao2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
           
            Console.WriteLine("ESCERVA ");
            string numero = Console.ReadLine();



            int[] numerocnpj = new int[14];
            for (int i = 0; i < 14; i++)
            {
                numerocnpj[i] = int.Parse(numero[i].ToString());
            }



            int soma = 0;

            for (int i = 0; i < 12; i++)
            {
                soma += numerocnpj[i] * multiplicacao[i];
            }
            int divisao = soma % 11;

            if (divisao < 2)
            {
                numerocnpj[12] = 0;
            }
            else
            {
                numerocnpj[12] = 11 - divisao;
            }


            int soma2 = 0;
            for (int i = 0; i < 13; i++)
            {

                soma2 += numerocnpj[i] * multiplicacao2[i];

            }
              int divisao2 = soma2 % 11;

            if (divisao2 < 2)
            {
                numerocnpj[13] = 0;
            }
            else
            {
                numerocnpj[13] = 11 - divisao;
            }

            char digito1 = numero[12];
            char digito2 = numero[13];
            char dig1 = Convert.ToChar(numerocnpj[12].ToString());
            char dig2 = Convert.ToChar(numerocnpj[13].ToString());
            string cnpjnovo = $"{numero.Substring(0, 2)}.{numero.Substring(2, 3)}.{numero.Substring(5, 3)}/{numero.Substring(8, 4)}-{numero.Substring(12, 2)}";



            if (digito1 == dig1 && digito2 == dig2)
            {
                Console.WriteLine("Seu CNPJ ta certo");
                Console.WriteLine("==================================");
                Console.WriteLine($"{cnpjnovo}");
                Console.WriteLine("==================================");
            }
            else
            {
                Console.WriteLine("Seu CNPJ está errado");
            }




        }
    }
}