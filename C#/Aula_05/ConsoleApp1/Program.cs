using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            float a, b, c;
            double x1, x2;
            Console.WriteLine("Digite o valor de a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de c: ");
            c = float.Parse(Console.ReadLine());

            x1 = (-b + Math.Sqrt(b * b - (4 * a * c))) / (2 * a);
            x2 = (-b - Math.Sqrt(b * b - (4 * a * c))) / (2 * a);

            Console.WriteLine("X1 é = {0}",x1);
            Console.WriteLine("X2 é = {0}",x2);
            */
            /*
            int n1 = 0, n2 = 0, res = 1, i = 2;
            Console.WriteLine("Digite um numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            n2 = int.Parse(Console.ReadLine());

            while (true)
            {
                if (n1 == 1 && n2 == 1)
                {
                    break;
                }
                else
                {
                    if (n1 % i == 0 && n2 % i == 0)
                    {
                        n1 /= i;
                        n2 /= i;
                        res *= i;
                        i--;
                    }
                    else
                    {
                        if (n1 % i == 0)
                        {
                            n1 /= i;
                            res *= i;
                            i--;
                        }
                        else if (n2 % i == 0)
                        {
                            n2 /= i;
                            res *= i;
                            i--;
                        }
                    }
                }
                i++;
            }

            Console.WriteLine(res);
            */
            /* Raiz Cubica*/
            /*
            double result;
            int n1;
            Console.Write("Digite um valor: ");
            n1 = int.Parse(Console.ReadLine());
            result = Math.Pow (n1, 1.0/3);
            Console.WriteLine(result);
            */
            /*
            int n1 = 0, n2 = 0, res = 1, i = 2, maior = 0, ni = 0;
            Console.WriteLine("Digite um numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                maior = n1;
            }
            else
            {
                maior = n2;
            }
            for (int c = 0; c < maior; c++)
            {
                if (n1 == 1 || n2 == 1)
                {
                    break;

                }
                else
                {
                    if (n1 % i == 0 && n2 % i == 0)
                    {
                        n1 /= i;
                        n2 /= i;
                        res *= i;
                        i--;
                    }
                }
                i++;
                ni++;
            }
            Console.WriteLine(res);
            Console.WriteLine(ni);
            */
            /*
            double result;
            float raio = 0;
            Console.WriteLine("Digite o raio");
            raio = float.Parse(Console.ReadLine());
            const double PI = Math.PI;
            result = ((4 * PI) * Math.Pow(raio, 3)) / 3;
            Console.WriteLine(Math.Round(result, 3));
            */
        }
    }
}
