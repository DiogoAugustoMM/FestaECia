using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    internal class FestaECia
    {
        public Espaco[] Espacos = new Espaco[8];
        public Cerimonia[] Cerimonias = new Cerimonia[31];

        public FestaECia()
        {
            Espaco A = new Espaco("A", 100);
            Espacos[0] = A;
            Espaco B = new Espaco("B", 100);
            Espacos[1] = B;
            Espaco C = new Espaco("C", 100);
            Espacos[2] = C;
            Espaco D = new Espaco("D", 100);
            Espacos[3] = D;
            Espaco E = new Espaco("E", 200);
            Espacos[4] = E;
            Espaco F = new Espaco("F", 200);
            Espacos[5] = F;
            Espaco G = new Espaco("G", 50);
            Espacos[6] = G;
            Espaco H = new Espaco("H", 500);
            Espacos[7] = H;
        }

        private Espaco VerificaEspaco(DateTime data, int convidados)
        {
            //verifica a quantidade de convidados e retorna o espaço adequado
            if (convidados <= 50)
            {
                Console.WriteLine("a proxima data disponivel é em " + Espacos[6].VerificaDataDisponivel(data) + " No espaço" + Espacos[6].Tipo
                + "\nDeseja essa Data?(disgite sim ou não)");
                string opcao = Console.ReadLine();
                if (opcao == "sim")
                {
                    Espacos[6].AdicionaData(Espacos[6].VerificaDataDisponivel(data));
                    return Espacos[6];
                }
                else return new Espaco("Z", -2);


            }
            else if (convidados <= 100)
            {
                DateTime menor = DateTime.MaxValue;
                Espaco disponivel = new Espaco("z", 0);
                for (int i = 0; i < 4; i++)
                {
                    DateTime atual = Espacos[i].VerificaDataDisponivel(data);
                    if (atual <= menor)
                    {
                        menor = atual;
                        disponivel = Espacos[i];
                    }
                }
                Console.WriteLine("a proxima data disponivel é em " + menor + " No espaço" + disponivel.Tipo + "\nDeseja essa Data?(disgite sim ou não)");
                string opcao = Console.ReadLine();
                if (opcao == "sim")
                {
                    disponivel.AdicionaData(disponivel.VerificaDataDisponivel(data));
                    return disponivel;
                }
                else return new Espaco("Z", -2);


            }
            else if (convidados <= 200)
            {
                DateTime menor = DateTime.MaxValue;
                Espaco disponivel = new Espaco("z", 0);
                for (int i = 4; i < 6; i++)
                {
                    DateTime atual = Espacos[i].VerificaDataDisponivel(data);
                    if (atual <= menor)
                    {
                        menor = atual;
                        disponivel = Espacos[i];
                    }
                }
                Console.WriteLine("a proxima data disponivel é em " + menor + " No espaço" + disponivel.Tipo + "\nDeseja essa Data?(disgite sim ou não)");
                string opcao = Console.ReadLine();
                if (opcao == "sim")
                {
                    disponivel.AdicionaData(disponivel.VerificaDataDisponivel(data));
                    return disponivel;
                }
                else return new Espaco("Z", -2);

            }
            else if (convidados <= 500)
            {
                Console.WriteLine("a proxima data disponivel é em " + Espacos[7].VerificaDataDisponivel(data) + " No espaço " + Espacos[7].Tipo + "\nDeseja essa Data?(disgite sim ou não)");
                string opcao = Console.ReadLine();
                if (opcao == "sim")
                {
                    Espacos[7].AdicionaData(Espacos[7].VerificaDataDisponivel(data));
                    return Espacos[7];
                }
                else return new Espaco("Z", -2);



            }
            else
            {
                return new Espaco("Z", -1);
            }
        }

        public bool CriarEvento(DateTime data, int convidados, string cpfnoiva)
        {
            //cria a cerimonia com o espaço ideal
            Espaco disponivel = VerificaEspaco(data, convidados);
            if (disponivel.Capacidade == -1)
            {
                Console.WriteLine("o numero de convidados excede nossa capacidade maxima de pessoas");
                return false;
            }
            else if (disponivel.Capacidade == -2)
            {
                Console.WriteLine("Agendamento cancelado");
                return false;
            }
            else
            {
                Cerimonia nova = new Cerimonia(data, convidados, disponivel, cpfnoiva);
                for (int i = 0; i < Cerimonias.Length; i++)
                {
                    if (Cerimonias[i] == null)
                    {
                        Cerimonias[i] = nova;
                        Console.WriteLine("Cerimonia no espaço {0} confirmada!", disponivel.Tipo);
                        return true;
                    }
                }
                Console.WriteLine("Agendamento cancelado");
                return false;
            }
        }

        public bool Informacoes(string cpfnoiva)
        {
            for (int i = 0; i < Cerimonias.Length; i++)
            {
                if (Cerimonias[i] != null && Cerimonias[i].CPFNoiva == cpfnoiva)
                {
                    Console.WriteLine("Casamento da noiva de cpf {0} ocorrera no dia {1} para {2} convidados", Cerimonias[i].CPFNoiva, Cerimonias[i].Data, Cerimonias[i].Convidados);
                    return true;
                }
            }
            Console.WriteLine("CPF de noiva invalido ou casamento não cadastrado ainda");
            return false;
        }

        public int TiposEventos()
        {
            Console.WriteLine("Os eventos ofertados são:" +
                "\n 1. Casamento" +
                "\n 2. Aniversario" +
                "\n 3. Festa de Empresa" +
                "\n 4. Formatura" +
                "\n 5. Apenas aluguel de espaco ");
            Console.Write("Escolha o numero correspondente ao evento desejado: ");
            return int.Parse(Console.ReadLine());
            
        }
    }
}
