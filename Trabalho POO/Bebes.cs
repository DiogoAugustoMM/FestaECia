using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    public class Bebes : IServicos
    {
        public string Nivel { get; set; }
        public List<Bebida> Bebidas { get; set; }
        public int Valor { get; set; }

        public Bebes(int valor)
        {
            Bebidas = new List<Bebida>();
            Valor = valor;
        }

        public void AdicionarBebida(Bebida bebida)
        {
            Bebidas.Add(bebida);
        }

        public string MostrarBebidas()
        {
            string bebidasStr = "Bebidas: ";
            foreach (var bebida in Bebidas)
            {
                bebidasStr += bebida.Nome + " ";
            }
            return bebidasStr;
        }
    }
}
