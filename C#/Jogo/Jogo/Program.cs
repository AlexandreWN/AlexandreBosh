using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, pp1 = 0,  ppc = 0, emp = 0;

            
            while (x <= 10000)
            {
                int pc, p;
                Random rnd = new Random();
                pc = rnd.Next(0, 3);
                Task.Delay(0).Wait();
                Random rnd1 = new Random();
                p = rnd1.Next(0, 3);
                

                Console.Clear();
                Console.WriteLine("-----------------------");
                Console.WriteLine("---pc: {0} X player: {1}---", ppc, pp1);
                Console.WriteLine("---Empates: {0}----------", emp);
                Console.WriteLine("-----------------------\n");

                Console.WriteLine("---------------------------");
                Console.WriteLine("----Pedra papel tesoura----");
                Console.WriteLine("-----Escolha soa opção-----");
                Console.WriteLine("---------0 = Pedra---------");
                Console.WriteLine("---------1 = Papel---------");
                Console.WriteLine("---------2 = Tesoura-------");
                Console.WriteLine("---------3 = Para sair-----");
                Console.WriteLine("---------------------------");

                //p = int.Parse(Console.ReadLine());
                
                switch (pc)
                {
                    case 0:
                        Console.WriteLine("\no pc escolheu Pedra");
                        Console.WriteLine("\n   ...");
                        Console.WriteLine(" .     .");
                        Console.WriteLine(".       .");
                        Console.WriteLine(" .......");
                        break;
                    case 1:
                        Console.WriteLine("\no pc escolheu Papel");
                        Console.WriteLine("\n-------");
                        Console.WriteLine("|     |");
                        Console.WriteLine("|     |");
                        Console.WriteLine("-------");
                        break;
                    case 2:
                        Console.WriteLine("\no pc escolheu Tesoura");
                        Console.WriteLine("\n                  //");
                        Console.WriteLine("  |||||       //");
                        Console.WriteLine(" |     |    //");
                        Console.WriteLine("  ||||| //");
                        Console.WriteLine("  ||||| //");
                        Console.WriteLine(" |     |    //");
                        Console.WriteLine("  |||||       //");
                        Console.WriteLine("                  //");
                        break;
                }

                switch (p)
                {
                    case 0:
                        Console.WriteLine("\nVoce escolheu Pedra");
                        Console.WriteLine("\n   ...");
                        Console.WriteLine(" .     .");
                        Console.WriteLine(".       .");
                        Console.WriteLine(" .......");
                        break;
                    case 1:
                        Console.WriteLine("\nVoce escolheu Papel");
                        Console.WriteLine("\n-------");
                        Console.WriteLine("|     |");
                        Console.WriteLine("|     |");
                        Console.WriteLine("-------");
                        break;
                    case 2:
                        Console.WriteLine("\nVoce escolheu Tesoura");
                        Console.WriteLine("\n                  //");
                        Console.WriteLine("  |||||       //");
                        Console.WriteLine(" |     |    //");
                        Console.WriteLine("  ||||| //");
                        Console.WriteLine("  ||||| //");
                        Console.WriteLine(" |     |    //");
                        Console.WriteLine("  |||||       //");
                        Console.WriteLine("                  //");

                        break;
                    case 3:
                        Console.WriteLine("\nTchau :(");
                        x = 0;
                        break;
                }

                if (p == 0 && pc == 2 || p == 1 && pc == 0 || p == 2 && pc == 1)
                {
                    Console.WriteLine("\n-------------");
                    Console.WriteLine("Voce ganhou");
                    Console.WriteLine("-------------");
                    pp1++;
                }
                else if (p == 2 && pc == 0 || p == 0 && pc == 1 || p == 1 && pc == 2)
                {
                    Console.WriteLine("\n-------------");
                    Console.WriteLine("Voce Perdeu");
                    Console.WriteLine("-------------");
                    ppc++;

                }
                else
                {
                    Console.WriteLine("\n--------");
                    Console.WriteLine("Empate");
                    Console.WriteLine("--------");
                    emp++;
                }
                x++;
            }
        }
    }
}
