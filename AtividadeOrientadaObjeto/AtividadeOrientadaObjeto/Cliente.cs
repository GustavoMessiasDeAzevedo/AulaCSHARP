using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeOrientadaObjeto
{
    internal class Cliente
    {
        private int IdCliente;
        private string Nome;
        private int CPF;


        public Cliente(int idCliente = 0, string nome = "", int cPF = 0)
        {
            IdCliente = idCliente;
            Nome = nome;
            CPF = cPF;
        }
    }
}
