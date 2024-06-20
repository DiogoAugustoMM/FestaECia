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
        }

        public void DeclaraNivel()
        {
            int opcao = -1;
            do
            {
                // Solicita ao usuário para escolher um nível
                Console.WriteLine("Qual o nivel desejado para o evento?" +
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
    }
}
