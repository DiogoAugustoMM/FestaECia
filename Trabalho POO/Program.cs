using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Trabalho_POO;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            FestaECia festaECia = new FestaECia();

            int tipoevento = festaECia.TiposEventos();

            Console.WriteLine("Qual a quantidade de convidados?");
            int quantconvidados = int.Parse(Console.ReadLine());

            festaECia.CriarEvento(new DateTime(2024, 06, 11), quantconvidados, tipoevento);
            Evento evento = festaECia.Cerimonias[0];



            double valorComidas = evento.CalcularValorComidas();
            double valorBebidas = evento.CalcularValorBebidas();
            double valorEspaco = evento.ValorEspaco;

            double valorTotal = valorComidas + valorBebidas + valorEspaco;

            Console.WriteLine($"Valor das comidas: {valorComidas:C}");
            Console.WriteLine($"Valor das bebidas: {valorBebidas:C}");
            Console.WriteLine($"Valor do espaço: {valorEspaco:C}");
            Console.WriteLine($"Valor total da festa: {valorTotal:C}");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();

            string resumo = evento.GerarResumo();
            Console.WriteLine(resumo);

            Console.ReadLine();
        }
    }
}