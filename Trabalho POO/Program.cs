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
            festaECia.CriarEvento(new DateTime(2024, 06, 12), quantconvidados, tipoevento);


        }
    }
}