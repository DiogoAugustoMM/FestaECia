using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    internal class Aniversario: Evento
    {

        public int ValorServicos { get; set; }
        public string Nivel { get; set; }

        public Aniversario(int convidados, DateTime data, int valorEspaco, Espaco espaco,string cpf):base(data,convidados,espaco,cpf,valorEspaco)
        {
        }

    }
}
