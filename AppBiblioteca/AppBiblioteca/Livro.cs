using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    internal class Livro
    {

        public int id { get; set; }
        public string titulo;
        private int ano;
        private int numeroPagina;

        public int Ano
        {
            get { return ano; }
            set { 
            
                if(value > 0) {
                    ano = value;
                }
                else
                {
                    Console.WriteLine("Ano de publicação inválido");
                }
            }

        }

        public int NumeroPagina
        {
            get { return numeroPagina; }

            set
            {
                if(value > 0) { 
                    numeroPagina = value;
                }
                else
                {
                    Console.WriteLine("Numero de páginas inválido ");
                }
            }
        }


        public virtual void MostrarDetalhes()
        {

            Console.WriteLine("Id: {0}", id);
            Console.WriteLine("Título: {0}", titulo);
            Console.WriteLine("Ano: {0}", ano);
            Console.WriteLine("Número de Página: {0}", numeroPagina);
        }
    }
}

