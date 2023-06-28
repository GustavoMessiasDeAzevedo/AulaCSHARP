using System;
using System.Text.RegularExpressions;

namespace validar_cnpj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] multiplicacao = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicacao2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            string confirmacao;
            do
            {
                Console.WriteLine("Escreva seu CNPJ: ");
                string numero = Console.ReadLine();

                string cpnjSemMascara = RemoverCaracteresEspeciais(numero);
               

                if (ContemLetras(numero))
                {
                    Console.WriteLine("Erro: O CNPJ não pode conter letras.");
                    Console.WriteLine("Deseja digitar novamente? (sim/não)");
                    confirmacao = Console.ReadLine();
                    continue;
                }

                int[] numerocnpj = new int[14];
                for (int i = 0; i < 14; i++)
                {
                    numerocnpj[i] = int.Parse(cpnjSemMascara[i].ToString());
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

                if (digito1 == dig1 && digito2 == dig2)
                {
                    Console.WriteLine("Seu CNPJ está correto");
                    Console.WriteLine("==================================");
                    Console.WriteLine($"{numero}");
                    Console.WriteLine("==================================");
                    break;
                }
                else
                {
                    Console.WriteLine("Seu CNPJ está incorreto");
                }

                Console.WriteLine("Deseja tentar novamente? (sim/não)");
                confirmacao = Console.ReadLine();
            } while (confirmacao.Equals("sim", StringComparison.OrdinalIgnoreCase) || confirmacao.Equals("s", StringComparison.OrdinalIgnoreCase));
        }

        static string RemoverCaracteresEspeciais(string input)
        {
            string resultado = Regex.Replace(input, @"[^0-9]", "");
            return resultado;
        }

        static bool ContemLetras(string value)
        {
            foreach (char c in value)
            {
                if (char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
