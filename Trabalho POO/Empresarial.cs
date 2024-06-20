using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    internal class Empresarial:Evento
    {
        public int ValorServicos { get; set; }

        public Empresarial(int convidados, DateTime data, int valorEspaco, Espaco espaco, string cpf) : base(data, convidados, espaco, cpf, valorEspaco)
        {
            this.TipoEvento = "empresarial";
        }

      
    }
}
