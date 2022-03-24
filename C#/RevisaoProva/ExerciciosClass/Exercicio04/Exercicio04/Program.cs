using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            string temp;
            int id, numero, qualidade, amarelo, vermelho;
            string nome, apelido, posicao;
            bool suspenso, treinou, x = true;
            DateTime data;


            //cadastrando  11  jogadores no sistema
            List<Jogador> jogadores = new List<Jogador>();
            jogadores.Add(new Jogador(1, "Marcos", "Marcão", DateTime.Parse("04/09/1973"), 1, "Goleiro", 90, 0, 0, false, false));
            jogadores.Add(new Jogador(2, "Cafú", "Capita", DateTime.Parse("07/06/1970"), 2, "Lateral Esquerdo", 100, 1, 0, false, false));
            jogadores.Add(new Jogador(3, "Lúcio", "Lúcio", DateTime.Parse("08/03/1978"), 3, "Zagueiro", 70, 0, 0, false, false));
            jogadores.Add(new Jogador(4, "Roque Júnior", "Roque", DateTime.Parse("03/08/1976"), 4, "Zagueiro", 70, 1, 0, false, false));
            jogadores.Add(new Jogador(5, "José Edmílson", "Edmílson", DateTime.Parse("07/07/1976"), 5, "Zagueiro", 80, 0, 0, false, false));
            jogadores.Add(new Jogador(6, "Roberto Carlos", "R6", DateTime.Parse("10/04/1973"), 6, "Lateral Direito", 100, 0, 0, false, false));
            jogadores.Add(new Jogador(7, "Ricardo Luís", "Ricardinhos", DateTime.Parse("23/03/1976"), 7, "Meio-campista", 80, 0, 1, true, false));
            jogadores.Add(new Jogador(8, "Gilberto Silva", "Gilberto", DateTime.Parse("07/10/1976"), 8, "Volante", 90, 1, 0, false, true));
            jogadores.Add(new Jogador(9, "Ronaldo", "R9", DateTime.Parse("22/09/1976"), 9, "Atacante", 10, 0, 0, false, true));
            jogadores.Add(new Jogador(10, "Rivaldo Vítor", "Rivaldo", DateTime.Parse("19/04/1972"), 10, "Atacante", 95, 0, 0, false, true));
            jogadores.Add(new Jogador(11, "Ronaldinho Gaúcho", "R10", DateTime.Parse("21/03/1980"), 11, "Meio-campista", 90, 0, 0, false, true));
            
            while (x)
            {
                Console.WriteLine(" ____________________________________");
                Console.WriteLine("|Sistema de Controle de Jogos        |");
                Console.WriteLine("| 1 - Verificar jogadores suspensos  |");
                Console.WriteLine("| 2 - Cadastrar Jogadores            |");
                Console.WriteLine("| 3 - Ver Jogadores                  |");
                Console.WriteLine("| 4 - Aplicar Cartão                 |");
                Console.WriteLine("| 5 - Remover Suspenção              |");
                Console.WriteLine("| 6 - Gerar Lesão                    |");
                Console.WriteLine("| 7 - Treinar Jogador                |");
                Console.WriteLine("| 8 - Sair                           |");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {

                    case 1:
                        for (int i = 0; i < jogadores.Count; i++)
                        {
                            if (jogadores[i].Suspenso == true)
                            {
                                Console.WriteLine($"{jogadores[i].Nome} foi suspenso e ele teve {jogadores[i].CartaoAmarelo} cartão amarelo e {jogadores[i].CartaoVermelho} cartão vermelho");

                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("CADASTRAR JOGADORES");
                        Console.WriteLine("Digite o id");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o nome");
                        nome = Console.ReadLine();
                        Console.WriteLine("Digite o apelido");
                        apelido = Console.ReadLine();
                        Console.WriteLine("Digite a data de nascimento dd/mm/aaaa");
                        data = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o numero da camisa");
                        numero = int.Parse(Console.ReadLine());
                        Console.WriteLine("digite a função");
                        posicao = Console.ReadLine();
                        Console.WriteLine("digite a qualidade");
                        qualidade = int.Parse(Console.ReadLine());
                        Console.WriteLine("digite a quantidade de catões amarelos");
                        amarelo = int.Parse(Console.ReadLine());
                        Console.WriteLine("digite a quantidade de catões vermelhos");
                        vermelho = int.Parse(Console.ReadLine());
                        Console.WriteLine("O jogador treinou true or false");
                        treinou = bool.Parse(Console.ReadLine());

                        if (Jogador.Verifica(amarelo, vermelho) == true)
                        {
                            suspenso = true;
                        }
                        else
                        {
                            suspenso = false;
                        }

                        jogadores.Add(new Jogador(id, nome, apelido, data, numero, posicao, qualidade, amarelo, vermelho, suspenso, treinou));
                        break;
                    case 3:
                        Console.WriteLine("JOGADORES CADASTRADOS");
                        for (int i = 0; i < jogadores.Count; i++)
                        {
                            if (jogadores[i].Suspenso == true)
                            {
                                temp = "SUSPENSO";
                            }
                            else
                            {
                                temp = "TÁ PRA JOGO";
                            }
                            Console.WriteLine($"{jogadores[i].Posicao}: {jogadores[i].Id} - {jogadores[i].Nome} ({jogadores[i].Apelido}) - {jogadores[i].DataNascimento.ToString("dd/MM/yyyy")} QUALIDADE: {jogadores[i].Qualidade} TREINOU: {jogadores[i].Treinou} CONDIÇÃO: {temp}");
                        }
                        break;
                    case 4:
                        Console.WriteLine("APLICAR CARTOES");
                        Console.WriteLine("Digite o id");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine("digite a quantidade de catões amarelos");
                        amarelo = int.Parse(Console.ReadLine());
                        Console.WriteLine("digite a quantidade de catões vermelhos");
                        vermelho = int.Parse(Console.ReadLine());

                        Jogador.aplicarCartao(amarelo,vermelho,jogadores,id);
                        break;
                    case 5:
                        Console.WriteLine("REMOVER SUSPENÇÃO");
                        Console.WriteLine("Digite o id");
                        id = int.Parse(Console.ReadLine());
                        Jogador.cumprirSuspencao(jogadores, id);
                        break;
                    case 6:
                        Console.WriteLine("GERAR LESÃO");
                        Console.WriteLine("Digite o id");
                        id = int.Parse(Console.ReadLine());
                        Jogador.sofrerLesao(jogadores, id);
                        break;
                    case 7:
                        Console.WriteLine("TREINAR JOGADOR");
                        Console.WriteLine("Digite o id");
                        id = int.Parse(Console.ReadLine());
                        Jogador.executarTreinamento(jogadores, id);
                        break;
                    case 8:
                        x = false;
                        break;
                }
            }
        }
    }
}
