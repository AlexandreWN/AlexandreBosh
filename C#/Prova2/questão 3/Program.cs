using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questão_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, sobrou, n100= 0,n50 = 0, n10 = 0, n5 = 0, n1 = 0;

            Console.WriteLine("Digite o valor que desaja entre 10 e 600");
            valor = int.Parse(Console.ReadLine());
            while (true)
            {
                if (valor < 10 || valor > 600)
                {
                    Console.WriteLine("Valor invalido digite outro");
                    valor = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }

            while (valor >= 100)
            {
                valor = valor - 100;
                n100++;
                    
            }
            while (valor >= 50)
            {
                valor = valor - 50;
                n50++;
            }
            while (valor >= 10)
            {
                valor = valor - 10;
                n10++;
            }
            while (valor >= 5)
            {
                valor = valor - 5;
                n5++;
            }
            while (valor >= 1)
            {
                valor = valor - 1;
                n1++;
            }


            Console.WriteLine("notas de 100: {0}", n100);
            Console.WriteLine("notas de 50: {0}", n50);
            Console.WriteLine("notas de 10: {0}", n10);
            Console.WriteLine("notas de 5: {0}", n5);
            Console.WriteLine("notas de 1: {0}", n1);



        }
    }
}
