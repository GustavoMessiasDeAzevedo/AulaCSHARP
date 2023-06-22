using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAlgoritmoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero1, numero2, total;

            Console.Write("Digite o numero 1: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o numero 2: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            total = numero1 + numero2;

            Console.WriteLine($"O total é: {total}");
            Console.WriteLine("A soma do {0} e {1} é: {2}", numero1, numero2, total);
            Console.WriteLine("Numero 1........:{0, 10}", numero1);
            Console.WriteLine("Numero 2........:{0, 10}", numero2);
            Console.WriteLine("Total...........:{0, 10:p}", total);
        }
    }
}
