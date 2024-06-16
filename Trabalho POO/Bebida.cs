using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    public class Bebida : Bebes
    {
        public string Nome { get; set; }
        public string Quantidade { get; set; }

        public Bebida(string nome, string quantidade, int valor) : base(valor)
        {
            Nome = nome;
            Quantidade = quantidade;
            Valor = valor;
        }
    }
}
