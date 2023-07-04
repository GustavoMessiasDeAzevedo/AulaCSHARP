using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto
{
    internal class AppBiblioteca
    {

        static void Main()
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.Nome = "Senac Marilia";

            Livro livro = new Livro();
            livro.IdLivro = 1;
            livro.Titulo = "É assim que acaba";
            livro.Autor = "Colleen Hoover";
            livro.NumeroPaginas = 368;
            livro.Preco = 30.80;

            Livro livros2 = new Livro();

            livros2.IdLivro = 2;
            livros2.Titulo = "É assim que começa";
            livros2.Autor = "Colleen Hoover";
            livros2.NumeroPaginas = 336;
            livros2.Preco = 30.80;

            biblioteca.CadastrarLivro(livro);
            biblioteca.CadastrarLivro(livros2);

            biblioteca.MostrarCatalogo();

          

            

        }
    }
}
