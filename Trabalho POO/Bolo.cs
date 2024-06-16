using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    public class Bolo : IServicos
    {
        public string Nivel { get; set; }
        public int Valor { get; set; }

        public Bolo(string nivel, int valor)
        {
            Nivel = nivel;
            Valor = valor;
        }
    }

    public void DecorarBolo(string nivel)
    {
        //
    }
}
