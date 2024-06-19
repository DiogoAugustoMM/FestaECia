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

        private double CalcularValorComidas()
        {
            double valorComidas = 0;
            double precoBase = 0;

            // Determinar o preço base conforme o tipo de festa
            string tipoFestaLower = TipoFesta.ToLower();

            if (tipoFestaLower == "standard")
            {
                precoBase = 40;
            }
            else if (tipoFestaLower == "luxo")
            {
                precoBase = 48;
            }
            else if (tipoFestaLower == "premier")
            {
                precoBase = 60;
            }
            else
            {
                throw new ArgumentException("Tipo de festa inválido.");
            }

            // Multiplicar o preço base pelo número de convidados
            valorComidas = precoBase * Convidados;

            return valorComidas;
        }

        private double CalcularValorBebidas()
        {
            double valorBebidas = 0;

            // Água (1 garrafa de 500ml por pessoa)
            int garrafasAgua = (int)Math.Ceiling((double)Convidados * 0.5 / 1.5);  // 1.5L garrafas
            valorBebidas += garrafasAgua * 5;

            // Sucos (400 ml por pessoa)
            int garrafasSuco = (int)Math.Ceiling((double)Convidados * 0.4 / 1);  // 1L garrafas
            valorBebidas += garrafasSuco * 7;

            // Refrigerante (400 ml por pessoa)
            int garrafasRefrigerante = (int)Math.Ceiling((double)Convidados * 0.4 / 2);  // 2L garrafas
            valorBebidas += garrafasRefrigerante * 8;

            // Cerveja Comum (3 garrafas de 600ml por pessoa)
            int garrafasCervejaComum = (int)Math.Ceiling((double)Convidados * 3);  // 600ml garrafas
            valorBebidas += garrafasCervejaComum * 20;

            // Espumante (1 garrafa para cada 2 pessoas)
            int garrafasEspumanteNacional = (int)Math.Ceiling((double)Convidados / 2.0);  // 750ml garrafas
            valorBebidas += garrafasEspumanteNacional * 80;

            int garrafasEspumanteImportado = (int)Math.Ceiling((double)Convidados / 2.0);  // 750ml garrafas
            valorBebidas += garrafasEspumanteImportado * 140;

            return valorBebidas;
        }

        public double CalcularValorFesta()
        {
            double valorTotal = ValorEspaco;

            // Calcular valor das comidas
            valorTotal += CalcularValorComidas();

            // Calcular valor dos serviços adicionais
             
            // ***** FAZER

            // Calcular valor das bebidas
            valorTotal += CalcularValorBebidas();

            return valorTotal;
        }   
    }
}
