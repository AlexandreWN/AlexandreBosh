using System;

namespace questão_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string pergunta, resp, resp1;
            int per, dica = 0;
            Random rnd = new Random();
            per = rnd.Next(0, 3);

            if (per == 0)
            {
                pergunta = "Qual o meu nome?";
                resp = "Alexandre";
            }
            else if (per == 1)
            {
                pergunta = "Qual numero vem na sequencia de 8?";
                resp = "9";
            }
            else
            {
                pergunta = "O que é uma banana?";
                resp = "fruta";
            }

            Console.WriteLine(pergunta);

            string escolha;
            int tent = 0;
            Console.WriteLine("\nDigite a resposta da pergunta: \n");
            escolha = Console.ReadLine();
            while (true)
            {
                
                if (tent < 1)
                {
                    if (escolha == resp)
                    {
                        Console.WriteLine("Voce acertou");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Voce errou tente novamente");
                        tent++;
                        Console.WriteLine("\nDigite a resposta da pergunta: \n");
                        escolha = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Voce perdeu o jogo");
                    break;
                }

            }

        }
    }
}

