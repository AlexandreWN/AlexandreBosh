using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questão_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha, numero, soma, vitorias = 0;
            while (true)
            {
                Console.WriteLine("Digite um numero");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Escolha 0 para par ou 1 para impar");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 0)
                {
                    Console.WriteLine("Voce escolheu PAR");
                }
                else if (escolha == 1)
                {
                    Console.WriteLine("Voce escolheu IMPAR");
                }

                int parimpar;
                Random rnd = new Random();
                parimpar = rnd.Next(0, 100);

                Console.WriteLine("Voce seu numero foi: {0}", numero);
                Console.WriteLine("Voce numero do pc foi: {0}", parimpar);

                soma = parimpar + numero;

                Console.WriteLine("A soma deles foi: {0}", soma);

                if (escolha == 0 && soma % 2 == 0)
                {
                    Console.WriteLine("Voce venceu");
                    vitorias++;
                }
                else if (escolha == 1 && soma % 2 != 0)
                {
                    Console.WriteLine("Voce venceu");
                    vitorias++;
                }
                else
                {
                    Console.WriteLine("Voce perdeu");
                    Console.WriteLine("a quantidade de vitorias foram: {0}", vitorias);
                    break;
                }


            }
            
        }
    }
}

