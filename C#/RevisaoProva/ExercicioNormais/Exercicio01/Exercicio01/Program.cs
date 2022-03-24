using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            int op;
            double lado;
            int quantidade = 0;
            double area;
            while (x)
            {
                Console.WriteLine("Digite 1 para adicionar um lado");
                Console.WriteLine("Digite 2 para parar");
                op = int.Parse(Console.ReadLine());
                List<double> lados = new List<double>();
                switch (op){
                    case 1:
                        Console.WriteLine("Digite a medida do lado em centimetros:");
                        lado = double.Parse(Console.ReadLine());
                        lados.Add(lado);
                        quantidade = lados.Count;
                        break;
                    case 2:
                        if(quantidade == 3)
                        {
                            Console.WriteLine("TRIÂNGULO");
                        }
                        if(quantidade == 4)
                        {
                            Console.WriteLine("QUADRADO");
                            area = lados[1] * lados[3];
                            Console.WriteLine($"Sua area é : {area}");
                        }
                        if (quantidade == 5)
                        {
                            Console.WriteLine("PENTAGONO");
                        }
                        x = false;
                        break;
                    case 3:
                        Console.WriteLine("oi");
                        Console.WriteLine(quantidade);
                        break;
                    case 4:
                        for(int i = 0; i < lados.Count; i++)
                        {
                            Console.WriteLine(lados[i]);
                        }
                        break;
                }
            }
            
        }
    }
}
