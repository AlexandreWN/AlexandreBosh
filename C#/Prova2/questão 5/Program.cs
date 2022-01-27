using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questão_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string produtos;
            string valor;
            decimal soma = 0;
            int x = 0;
            List<string> lista = new List<string>();
            do
            {
                Console.WriteLine("Digite um produto");
                produtos = Console.ReadLine();
                Console.WriteLine("Digite o valor");
                valor = Console.ReadLine();
                if (produtos != "" && valor != "")
                {
                    lista.Add(produtos);
                    soma += decimal.Parse(valor);
                }
                else
                {
                    x = 1;
                }


            } while (x < 1);

            Console.WriteLine("Seus produtos foram\n");
            foreach (string i in lista)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nSeu total foi : {0}", soma);
        }
    }
}
