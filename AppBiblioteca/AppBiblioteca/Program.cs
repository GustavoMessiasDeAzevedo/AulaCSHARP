using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Livro livro = new Livro();

            livro.id = 1;
            livro.titulo = "Harry Potter";
            livro.Ano = 2021;
            livro.NumeroPagina = 20;

            livro.MostrarDetalhes();

            Console.WriteLine("==================================");
            LivroDigital livroDigital = new LivroDigital();

            livroDigital.id = 2;
            livroDigital.titulo = "Harry Potter 2";
            livroDigital.Ano = 2022;
            livroDigital.NumeroPagina = 50;
            livroDigital.tipoArquivo = "PDF";
            livroDigital.TamanhoMB = 258;
            livroDigital.MostrarDetalhes();
        }


    }
}
