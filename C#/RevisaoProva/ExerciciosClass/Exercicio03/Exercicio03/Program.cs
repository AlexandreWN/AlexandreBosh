using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tipo, nome;
            List<Animal> animais = new List<Animal>();
            for (int i = 0; i < 5; i++)
            {
                Animal novo = new Animal();
                Console.WriteLine("Digite o Tipo de animal");
                tipo = Console.ReadLine();
                Console.WriteLine("Digite o nome do animal");
                nome = Console.ReadLine();

                novo.Nome = nome;
                novo.Tipo = tipo;
                animais.Add(novo);
            }
            Animal.Printar(animais);   
        }
    }
}
