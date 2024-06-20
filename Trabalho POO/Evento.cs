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
        public string TipoEvento { get; set; }
        public int Convidados { get; set; }
        public DateTime Data { get; set; }
        public string CPFNoiva { get; set; }
        public string Nivel { get; set; }
        public double ValorEspaco { get; set; }
        public double ValorComidas { get; set; }
        public double ValorBebidas { get; set; }
        public double ValorAdicionais { get; set; }

        public Evento(DateTime data, int convidados, Espaco espaco, string cpfnoiva, double valor)
        {
            this.Convidados = convidados;
            this.Data = data;
            this.Espaco = espaco;
            this.CPFNoiva = cpfnoiva;
            this.ValorEspaco = valor;
            this.Nivel = null;
            this.TipoEvento = "livre";

        }

        public void DeclaraNivel()
        {
            int opcao = -1;
            do
            {
                // Solicita ao usuário para escolher um nível
                Console.WriteLine("\nQual o nivel desejado para o evento?" +
                        "\n 1. Standard" +
                        "\n 2. Luxo" +
                        "\n 3. Premier");
                try
                {
                    // Tenta converter a entrada do usuário para um número inteiro
                    opcao = int.Parse(Console.ReadLine());

                    // Verifica se a opção está fora do intervalo de 1 a 3
                    if (opcao < 1 || opcao > 3)
                    {
                        Console.WriteLine("Por favor, selecione uma opção válida (1, 2 ou 3).");
                        opcao = -1; // Reseta a opção para um valor inválido para continuar o loop
                    }
                }
                catch (FormatException)
                {
                    // Informa ao usuário para digitar um número se a entrada não puder ser convertida para um número inteiro
                    Console.WriteLine("Responda com o numero desejado!!!");
                }
            } while (opcao == -1); // Repete o loop até que um número válido seja inserido

            if (opcao == 1)
            {
                this.Nivel = "standard";
            }
            else if (opcao == 2)
            {
                this.Nivel = "luxo";
            }
            else
            {
                this.Nivel = "premier";
            }
        }

        public double CalcularValorComidas()
        {
            double valorComidas = 0;
            double precoBase = 0;

            // Determinar o preço base conforme o tipo de festa
            string NivelLower = Nivel.ToLower();

            if (NivelLower == "standard")
            {
                precoBase = 40;
            }
            else if (NivelLower == "luxo")
            {
                precoBase = 48;
            }
            else if (NivelLower == "premier")
            {
                precoBase = 60;
            }
            else
            {
                throw new ArgumentException("Tipo de festa inválido.");
            }

            // Multiplicar o preço base pelo número de convidados
            valorComidas = precoBase * Convidados;
            this.ValorComidas= valorComidas;
            return valorComidas;
        }

        public double CalcularValorBebidas()
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
            this.ValorBebidas = valorBebidas;
            return valorBebidas;
        }


        public double CalculaValorAdicionais(){
            double valorAdicionais = 0;
            double precoBase = 0;

            // Determinar o preço base conforme o tipo de festa
            string NivelLower = Nivel.ToLower();

            if (NivelLower == "standard")
            {
                precoBase = 120;
            }
            else if (NivelLower == "luxo")
            {
                precoBase = 175;
            }
            else if (NivelLower == "premier")
            {
                precoBase = 230;
            }
            else
            {
                throw new ArgumentException("Tipo de festa inválido.");
            }

            valorAdicionais = precoBase;
            this.ValorAdicionais= valorAdicionais;
            return ValorAdicionais;
        }


        public double CalcularValorFesta()
        {
            double valorTotal = ValorEspaco;

            // Calcular valor das comidas
            valorTotal += CalcularValorComidas();

            // Calcular valor dos serviços adicionais
            valorTotal += CalculaValorAdicionais();

            // Calcular valor das bebidas
            valorTotal += CalcularValorBebidas();

            return valorTotal;
        }

        public string GerarResumo()
        {
            double valorComidas = CalcularValorComidas();
            double valorBebidas = CalcularValorBebidas();
            double valorAdicionais = CalculaValorAdicionais();

            double valorTotal = valorComidas + valorBebidas + ValorEspaco + ValorAdicionais;

            // Detalhes de bebidas
            int garrafasAgua = (int)Math.Ceiling(Convidados * 0.5 / 1.5);
            int garrafasSuco = (int)Math.Ceiling(Convidados * 0.4 / 1);
            int garrafasRefrigerante = (int)Math.Ceiling(Convidados * 0.4 / 2);
            int garrafasCervejaComum = (int)Math.Ceiling((double)Convidados * 3);
            int garrafasEspumanteNacional = (int)Math.Ceiling(Convidados / 2.0);

            string resumo = $"Resumo da Festa:\n";

            resumo += $"CPF: {CPFNoiva}\n";
            resumo += $"Tipo de Festa: {Nivel}\n";
            resumo += $"Quantidade de Convidados: {Convidados}\n";
            resumo += $"Valor do Espaço: {ValorEspaco:C}\n";
            resumo += $"Valores adicionais: {ValorAdicionais:C} \n\n";

            resumo += "Detalhes das Comidas:\n";
            resumo += $"Valor das Comidas: {valorComidas:C}\n\n";

            resumo += "Detalhes das Bebidas:\n";
            resumo += $"Água: {garrafasAgua} garrafas de 500ml\n";
            resumo += $"Suco: {garrafasSuco} garrafas de 1L\n";
            resumo += $"Refrigerante: {garrafasRefrigerante} garrafas de 2L\n";
            resumo += $"Cerveja Comum: {garrafasCervejaComum} garrafas de 600ml\n";
            resumo += $"Espumante Nacional: {garrafasEspumanteNacional} garrafas de 750ml\n";
            resumo += $"Valor das Bebidas: {valorBebidas:C}\n\n";

            resumo += $"Valor Total da Festa: {valorTotal:C}\n";

            resumo += "<<<<<<<<--------- --------->>>>>>>>>";

            return resumo;
        }

        public void SalvarResumo()
        {

            try
            {
                string txtSalvo = @"C:\Users\gabri\source\repos\TrabalhoPOO/agendamento.txt";

                using (StreamWriter sw = File.AppendText(txtSalvo))
                {
                    sw.WriteLine(GerarResumo());
                }
            }
            catch (Exception e)
            {

            }

        }

    }
}
