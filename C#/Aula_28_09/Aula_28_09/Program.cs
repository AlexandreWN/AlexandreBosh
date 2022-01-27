using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_28_09
{
    class Circunferencia
    {
        double raio = 1;
        double x = 0;

        public Circunferencia(double raio)
        {
            if (raio > 0)
            {
                this.raio = raio;
            }
        }

        public double area()
        {
            x = 3.14 * (raio * raio);
            return x;
        }

    }
    class Retangulo
    {
        double lado1 = 1, lado2 = 1, y1 = 0, y2 = 0;
        public Retangulo(double lado1, double lado2)
        {
            if (lado1 > 0)
            {
                this.lado1 = lado1;
            }
            if (lado2 > 0)
            {
                this.lado2 = lado2;
            }
        }
        public double perimetro()
        {
            y1 = (lado1 * 2) + (lado2 * 2);
            return y1;
        }

        public double area()
        {
            y2 = lado1 * lado2;
            return y2;
        }
    }
    class Triangulo
    {
        double basse = 1, altura = 1, z = 0;
        public Triangulo(double basse, double altura){
            if (basse > 0)
            {
                this.basse = basse;
            }
            if (altura > 0)
            {
                this.altura = altura;
            } 
        }
        public double area()
        {
            z = (basse * altura) / 2;
            return z;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int quant = 0, oi = 0;
            string opcao = " ", quadop = " ";
            double valor, valor2;
            Console.WriteLine("Digite a quantidade de formas");
            quant = int.Parse(Console.ReadLine());
            List<double> Lista = new List<double> { };

            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Digite a forma que deseja c / r/ t");
                opcao = Console.ReadLine();
                if (opcao == "c")
                {
                    Console.WriteLine("digite o raio: ");
                    valor = double.Parse(Console.ReadLine());
                    Circunferencia circ = new Circunferencia(valor);
                    Lista.Add(circ.area());
                }
                if (opcao == "t")
                {
                    Console.WriteLine("digite a altura: ");
                    valor = double.Parse(Console.ReadLine());
                    Console.WriteLine("digite a base: ");
                    valor2 = double.Parse(Console.ReadLine());

                    Triangulo tri = new Triangulo(valor2, valor);
                    Lista.Add(tri.area());
                }
                else if (opcao == "r")
                {
                    Console.WriteLine("digite a para area e p para perimetro");
                    quadop = Console.ReadLine();
                    if (quadop == "a")
                    {
                        Console.WriteLine("digite a altura: ");
                        valor = double.Parse(Console.ReadLine());
                        Console.WriteLine("digite a base: ");
                        valor2 = double.Parse(Console.ReadLine());

                        Retangulo re = new Retangulo(valor2, valor);
                        Lista.Add(re.area());
                    }
                    else
                    {
                        Console.WriteLine("digite a altura: ");
                        valor = double.Parse(Console.ReadLine());
                        Console.WriteLine("digite a base: ");
                        valor2 = double.Parse(Console.ReadLine());

                        Retangulo re = new Retangulo(valor2, valor);
                        Lista.Add(re.perimetro());
                    }
                }
            }
            
            foreach (double c in Lista)
            {

                Console.WriteLine(c);
            }
                
        }
        
    }
}