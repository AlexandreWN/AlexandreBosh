using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    class Program
    {
        public static void Per(int x)
        {
            int y = 0;
            

            for (int i = 1; i < x; i++)
            {
                if (x % i == 0)
                {
                    y = y + i;
                }
            }
            if (y == x)
            {
                Console.WriteLine("Perfeito");
            }
            else
            {
                Console.WriteLine("Imperfeito");
            }
        }
        static void Main(string[] args)
        {


            int x;
            Console.WriteLine("Digite um numero");
            
            x = int.Parse(Console.ReadLine());
            Per(x);

        }
    }
}
