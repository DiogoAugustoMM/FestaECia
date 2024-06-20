using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    internal class Casamento:Evento
    {
        public int ValorServicos { get; set; }


        public Casamento(int convidados, DateTime data, int valorEspaco, Espaco espaco, string cpf) : base(data, convidados, espaco, cpf, valorEspaco)
        {
            this.TipoEvento = "casamento";
        }

        public override double CalcularValorBebidas()
       {
           double valorBebidas = base.CalcularValorBebidas();

           if (Nivel == "luxo" || Nivel == "premier")
           {
               // Espumante Importado (1 garrafa para cada 2 pessoas)
               int garrafasEspumanteImportado = (int)Math.Ceiling((double)Convidados / 2.0);  // 750ml garrafas
               valorBebidas += garrafasEspumanteImportado * 140;

               // Cerveja Premium (3 garrafas de 600ml por pessoa)
               int garrafasCervejaPremium = (int)Math.Ceiling((double)Convidados * 3);  // 600ml garrafas
               valorBebidas += garrafasCervejaPremium * 30; // Ajuste o preço conforme necessário
           }

           return valorBebidas;
       }
       
    }
}
