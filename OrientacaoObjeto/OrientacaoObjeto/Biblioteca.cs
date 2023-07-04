using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto
{
    internal class Biblioteca
    {

        public string Nome;
        public List<Livro> catalogo;

        public Biblioteca()
        {
            catalogo = new List<Livro>();
        }

        public void CadastrarLivro(Livro livro)
        {
            catalogo.Add(livro);
        }

        public void MostrarCatalogo()
        {
            Console.WriteLine("Catalogo de livros da Biblioteca: {0}", Nome);
            Console.WriteLine("===============================================");
            foreach (var livro in catalogo)
            {
                Console.WriteLine("Identificação: {0:4}  |  {1}  |  Preço: {2:C} ", livro.IdLivro, livro.Titulo, livro.Preco) ;
            }
            Console.WriteLine("===============================================");
            Console.WriteLine("Total de livros: {0}", catalogo.Count());
        }
    }
}
    
