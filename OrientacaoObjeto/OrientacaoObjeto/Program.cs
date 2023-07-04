using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Livro livro = new Livro();


            livro.IdLivro = 1;
            livro.Titulo = "É assim que acaba";
            livro.Autor = "Colleen Hoover";
            livro.NumeroPaginas = 368;
            livro.Preco =  30.80;

            livro.ImprimirDetalhes();

            Livro livros2 = new Livro();

            livros2.IdLivro = 2;
            livros2.Titulo = "É assim que começa";
            livros2.Autor = "Colleen Hoover";
            livros2.NumeroPaginas = 336;
            livros2.Preco = 30.80;

            livros2.ImprimirDetalhes();

            Livro livro3 = new Livro(3, "Trono de vidro", "Sarah J. Maas", 420, 34.99);

            livro3.ImprimirDetalhes();

            Livro livro4 = new Livro(idLivro: 4, numeroPaginas: 635, titulo: "Homem aranha", autor: "Stan Lee", preco: 26.78);
            livro4.ImprimirDetalhes();

            Livro livro5 = new Livro()
            {
                IdLivro = 5,
                Titulo = "Senac livro",
                NumeroPaginas = 50,
                Preco = 39.90,
                Autor = "Microsoft"
            };

            livro5.ImprimirDetalhes();



        }
    }
}
