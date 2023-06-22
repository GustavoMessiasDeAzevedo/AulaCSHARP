using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade;

            Console.Write("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade");

            }
            if (idade >= 18)
            {
                int escolha;
                Console.Write("Escolha uma opção (1 - Filme, 2 - Bar, 3 - Balada): ");
                escolha = Convert.ToInt32(Console.ReadLine());
                switch (escolha)
                {

                    case 1:
                        int filme;
                        Console.WriteLine("Você escolheu  o filme");

                        Console.Write("Selecione o filme que vc deseja assitir (1- Barbie, 2 - Velozes e furiosos, 3 - Homem aranha) ");
                        filme = Convert.ToInt32(Console.ReadLine());

                        switch (filme)
                        {

                            case 1:
                                Console.WriteLine("Você escolheu o filme Barbie, boa seção...");
                                break;

                            case 2:
                                Console.WriteLine("Você escolheu o filme Velozes e furiosos, boa seção...");
                                break;

                            case 3:
                                Console.WriteLine("Você escolheu o filme Homem aranha, boa seção...");
                                break;
                        }
                        break;


                    case 2:
                        Console.WriteLine("Voce escolheu o bar");
                        break;

                    case 3:
                        Console.WriteLine("Voce escolheu a balada");
                        break;

                    default:
                        Console.WriteLine("Encerrando...");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Você é menor de idade");

            }

        }
    }
}