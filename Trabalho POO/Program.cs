﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Trabalho_POO;

namespace Trabalho_POO
{
    internal class Program
    {
        static int MenuPrincipal()
        {
            int opcao = -1;
            do
            {
                Console.WriteLine("******* Festa&Cina *******");
                Console.WriteLine();
                Console.WriteLine("Opções:");
                Console.WriteLine();
                Console.WriteLine("1. Quero fazer um evento" +
                    "\n2. Quero pesquisar um evento" +
                    "\n3. Sair");
                try
                {
                    opcao = int.Parse(Console.ReadLine());

                    if (opcao < 1 || opcao > 3)
                    {
                        Console.WriteLine("Escolha uma opção entre 1 e 3 por favor");
                        opcao = -1;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Escolha um numero!!!");
                    opcao = -1;
                }

            }while (opcao==-1);
            return opcao;
        }
        static void Main(string[] args)
        {

            FestaECia festaECia = new FestaECia();

            int opcao = MenuPrincipal();

            if (opcao == 1)
            {
                int tipoevento = festaECia.TiposEventos();

                Console.WriteLine("\nQual a quantidade de convidados?");
                int quantconvidados = int.Parse(Console.ReadLine());

                Evento evento = festaECia.CriarEvento(new DateTime(2024, 06, 20), quantconvidados, tipoevento);

                if (evento.TipoEvento != "livre")
                {
                    evento.CalcularValorBebidas();
                    evento.CalcularValorComidas();

                    Console.WriteLine("**** VALORES ****");
                    Console.WriteLine("\n\nO valor das comidas é: " + evento.ValorBebidas);                  
                    Console.WriteLine("\nO valor das bebidas é: " + evento.ValorComidas);
                    Console.WriteLine("\nO valor do espaço é: " + evento.Espaco.Valor);
                    Console.WriteLine("\nO valor total é: " + (evento.Espaco.Valor + evento.ValorBebidas +evento.ValorComidas));


                    Console.WriteLine("\nDigite 1 para confirmar o evento e 2 para cancelar");
                    int confirme = int.Parse(Console.ReadLine());
                    if (confirme == 1)
                    {
                        //salvar evento no arquivo
                    }
                    else
                    {
                        Console.WriteLine("Agendamento cancelado");
                    }

                }
                else
                {
                    Console.WriteLine("o valor do espaço é: " + evento.Espaco.Valor);
                    Console.WriteLine("\nDigite 1 para confirmar o evento e 2 para cancelar");
                    int confirme = int.Parse(Console.ReadLine());
                    if (confirme == 1)
                    {
                        //salvar evento no arquivo
                    }
                    else
                    {
                        Console.WriteLine("Agendamento cancelado");
                    }

                }


            }
            else if (opcao == 2)
            {
                //pesquisar o evento
            }
            else if (opcao == 3) 
            {
                Console.WriteLine("saindo...");
            }
            
            

            

            
            /*


            double valorComidas = evento.CalcularValorComidas();
            double valorBebidas = evento.CalcularValorBebidas();
            double valorEspaco = evento.ValorEspaco;

            double valorTotal = valorComidas + valorBebidas + valorEspaco;

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Valor das comidas: {valorComidas:C}");
            Console.WriteLine($"Valor das bebidas: {valorBebidas:C}");
            Console.WriteLine($"Valor do espaço: {valorEspaco:C}");
            Console.WriteLine($"Valor total da festa: {valorTotal:C}");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();

            string resumo = evento.GerarResumo();
            Console.WriteLine(resumo);
            
            Console.ReadLine();
            */
        }
    }
}