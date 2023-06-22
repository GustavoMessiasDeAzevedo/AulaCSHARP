using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string confirm_calculadora;
            int confirm;
            do
            {

                double num1, num2, num3;

                string tmp, count;


                Console.WriteLine("Digite um Numero: ");
                tmp = Console.ReadLine();
                num1 = Convert.ToDouble(tmp);


                Console.WriteLine("Digite um Numero: ");
                tmp = Console.ReadLine();
                num2 = Convert.ToDouble(tmp);

                Console.WriteLine("Digite uma operação (1 - Soma; 2 - Subtração; 3 - Multiplicação; 4 - Divisão): ");
                count = Console.ReadLine();
                num3 = Convert.ToDouble(count);

                switch (num3)
                {
                    case 1:
                        Console.WriteLine($"A soma é {num1 + num2}");
                        break;

                    case 2:
                        Console.WriteLine($"A subtração é {num1 - num2}");
                        break;

                    case 3:
                        Console.WriteLine($"A multiplicação é {num1 * num2}");
                        break;

                    case 4:
                        Console.WriteLine($"A divisão é {num1 / num2}");
                        break;
                }

                Console.WriteLine("Deseja continuar?");
                confirm_calculadora = Console.ReadLine();
                confirm = Convert.ToInt32( confirm_calculadora );
                

            } while (confirm == 1);
            {
                Console.WriteLine("Encerrando..." +
                    "");
            }

            
           
        }
    }
}
