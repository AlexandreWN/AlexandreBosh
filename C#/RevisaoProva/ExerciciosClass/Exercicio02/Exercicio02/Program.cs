using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double basse, altura;
            Console.WriteLine("Digite a base do retangulo: ");
            basse = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do retangulo: ");
            altura = double.Parse(Console.ReadLine());

            Forma novo = new Forma();
            novo.altura = altura;
            novo.basee = basse;
            Console.WriteLine(novo.ExibirPropriedades());
        }
    }
}
