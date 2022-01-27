using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questão_8
{
    class Program
    {
        public static bool verifica(string palavra)
        {

            string primeira = palavra.Substring(0, palavra.Length / 2);
            char[] arr = palavra.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string segunda = temp.Substring(0, temp.Length / 2);

            return primeira.Equals(segunda);
        }
        static void Main(string[] args)
        {
            int tamanho;
            string palavra;
            Console.WriteLine("escolha quantas palavras vai colocar");
            tamanho = int.Parse(Console.ReadLine());

            string[] palavras00 = new string[tamanho];
            string[] verificadas = new string[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite a palavra");
                palavra = Console.ReadLine();
                palavras00[i] = palavra;
                bool verificado = verifica(palavras00[i]);
                if (verificado == true)
                {
                    verificadas[i] = palavras00[i];
                }
                else
                {
                    verificadas[i] = "";
                }
            }
            Console.WriteLine("\nVerificadas\n");
            for (int i = 0; i < tamanho; i++)
            {
                if (verificadas[i] != "")
                {
                    Console.WriteLine(verificadas[i]);
                }

            }

        }
    }
}
