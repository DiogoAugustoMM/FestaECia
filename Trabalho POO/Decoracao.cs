using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    public class Decoracao : IServicos
    {
        public string Nivel {  get; set; }
        public int Valor { get; set; }
        public Decoracao(string nivel, int valor) {
            Nivel = nivel;
            Valor = valor;
        }
    }
}
