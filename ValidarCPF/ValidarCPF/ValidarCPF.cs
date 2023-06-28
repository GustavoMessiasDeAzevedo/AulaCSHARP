using System;

namespace ValidarCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string confirmacao;
            do
            {
                Console.Write("Digite seu CPF (apenas números): ");
                string num = Console.ReadLine();

                if (!IsNumeric(num))
                {
                    Console.WriteLine("Erro: O CPF deve conter apenas números.");
                    Console.WriteLine("Deseja digitar novamente? (sim/não)");
                    confirmacao = Console.ReadLine();
                    continue;
                }

                int[] numeroCPF = new int[11];

                for (int i = 0; i < 11; i++)
                {
                    numeroCPF[i] = int.Parse(num[i].ToString());
                }

                int soma = 0;
                for (int i = 0; i < 9; i++)
                {
                    soma += numeroCPF[i] * (10 - i);
                }

                int div = (soma * 10) % 11;
                numeroCPF[9] = (div == 10) ? 0 : div;

                int soma2 = 0;
                for (int i = 0; i < 10; i++)
                {
                    soma2 += numeroCPF[i] * (11 - i);
                }
                int div2 = (soma2 * 10) % 11;

                numeroCPF[10] = (div2 == 11) ? 0 : div2;

                char digito1 = num[9];
                char digito2 = num[10];
                char dig = Convert.ToChar(numeroCPF[9].ToString());
                char dig2 = Convert.ToChar(numeroCPF[10].ToString());


                string cpfNovo = ($"{num.Substring(0,3)}.{num.Substring(3, 3)}.{num.Substring(6, 3)}-{num.Substring(9, 2)}");
                if (dig == digito1 && dig2 == digito2)
                {
                    Console.WriteLine("CPF Aprovado");
                    Console.WriteLine("============================");
                    Console.WriteLine($"Seu CPF é: {cpfNovo}" );
                    Console.WriteLine("============================");
                    break;
                }
                else
                {
                    Console.WriteLine("CPF Negado");
                }

                Console.WriteLine("Deseja tentar novamente? (sim/não)");
                confirmacao = Console.ReadLine();
            } while (confirmacao.Equals("sim", StringComparison.OrdinalIgnoreCase) || confirmacao.Equals("s", StringComparison.OrdinalIgnoreCase));
        }

        static bool IsNumeric(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                {
                    
                    return false;
                }
            }
            return true;
        }
    }
}
