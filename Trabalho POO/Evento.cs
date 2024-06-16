using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    internal class Evento
    {
        public Espaco Espaco { get; set; }
        public int Convidados { get; set; }
        public DateTime Data { get; set; }

        public string CPFNoiva { get; set; }


        public double ValorEspaco { get; set; }

        public Evento(DateTime data, int convidados, Espaco espaco, string cpfnoiva, double valor)
        {
            this.Convidados = convidados;
            this.Data = data;
            this.Espaco = espaco;
            this.CPFNoiva = cpfnoiva;
            this.ValorEspaco = valor;

        }
    }
}
