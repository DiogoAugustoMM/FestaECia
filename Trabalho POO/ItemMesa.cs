using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    public class ItemMesa : IServicos
    {
        public string Nivel { get; set; }
        public int Valor { get ; set; }

        public ItemMesa(string nível, int valor)
        {
            Nivel = nível;
            Valor = valor;
        }
    }
}
