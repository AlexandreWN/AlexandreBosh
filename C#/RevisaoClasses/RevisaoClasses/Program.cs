using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoClasses
{
    class erro : ApplicationException
    {
        public erro(string mensage) : base(mensage)
        {

        }
    }
    public class Circunferencia
    {
        public double raio { get; set; }
        double areaa { get; set; }

        public double area()
        {
            double area;
            area = 3.14 * (raio * raio);
            return area;
        }
    }

    public class Retangulo
    {
        public double lado1 { get; set; }
        public double lado2 { get; set; }

        public double area()
        {
            double area = 0;
            area = lado1 * lado2;
            return area;
        }

        public double perimetro()
        {
            double perimetro = 0;
            perimetro = (lado1 * 2) + (lado2 * 2);
            return perimetro;
        }
    }

    public class Triangulo
    {
        public double basee { get; set; }
        public double altura { get; set; }

        public double area()
        {
            double area = 0;
            area = (basee * altura) / 2;
            return area;
        }
    }

    public class UsarFormas
    {
        public void Main()
        {
            int quantidade;
            string op;
            double raio, lado1, lado2, altura, basee;

            List<Circunferencia> circulo = new List<Circunferencia>();
            List<Retangulo> retangulo = new List<Retangulo>();
            List<Triangulo> triangulo = new List<Triangulo>();
            try
            {
                Console.WriteLine("Digite Quantas formas deseja criar: ");
                quantidade = int.Parse(Console.ReadLine());

                for (int i = 0; i < quantidade; i++)
                {
                    Console.WriteLine("Digite c para circulo");
                    Console.WriteLine("Digite r para retangulo");
                    Console.WriteLine("Digite t para triangulo");
                    Console.WriteLine("Digite * para sair");

                    op = Console.ReadLine();
                    switch (op)
                    {
                        case "c":
                            Circunferencia novoCirculo = new Circunferencia();
                            Console.WriteLine("Digite o raio do circulo");
                            raio = double.Parse(Console.ReadLine());

                            novoCirculo.raio = raio;
                            circulo.Add(novoCirculo);
                            break;
                        case "r":
                            Retangulo novoRetangulo = new Retangulo();
                            Console.WriteLine("Digite o lado 1 do retangulo");
                            lado1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o lado 2 do retangulo");
                            lado2 = double.Parse(Console.ReadLine());

                            novoRetangulo.lado1 = lado1;
                            novoRetangulo.lado2 = lado2;
                            retangulo.Add(novoRetangulo);
                            break;
                        case "t":
                            Triangulo novoTriangulo = new Triangulo();
                            Console.WriteLine("Digite a base do triangulo");
                            basee = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite a altura do triangulo");
                            altura = double.Parse(Console.ReadLine());

                            novoTriangulo.basee = basee;
                            novoTriangulo.altura = altura;
                            triangulo.Add(novoTriangulo);
                            break;
                        case "*":
                            i = quantidade;
                            break;
                    }
                }
                for (int c = 0; c < circulo.Count; c++)
                {
                    Console.WriteLine("\nO circulo: {0} tem uma area de: {1}", c + 1, circulo[c].area());
                }

                for (int r = 0; r < retangulo.Count; r++)
                {
                    Console.WriteLine("\nO retangulo: {0} tem uma area de: {1}", r + 1, retangulo[r].area());
                    Console.WriteLine("\nO retangulo: {0} tem um perimetro de: {1}", r + 1, retangulo[r].perimetro());
                }

                for (int t = 0; t < triangulo.Count; t++)
                {
                    Console.WriteLine("\nO triangulo: {0} tem uma area de: {1}", t + 1, triangulo[t].area());
                }
                Console.WriteLine("Precione qualquer tecla para continuar");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n{e.Message}");
                Console.WriteLine("Precione qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
                UsarFormas novo = new UsarFormas();
                novo.Main();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            UsarFormas novo = new UsarFormas();
            novo.Main();
        }
    }
}
