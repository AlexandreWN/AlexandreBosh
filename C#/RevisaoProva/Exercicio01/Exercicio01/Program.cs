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
            string nome;
            int idade;
            List<Pessoa> pessoas = new List<Pessoa>();
            for(int i = 0; i < 3; i++)
            {
                
                Console.WriteLine("Digite o nome da pessoa {0}: ", i + 1);
                nome = Console.ReadLine();
                Console.WriteLine("Digite a idade da pessoa {0}: ", i + 1);
                idade = int.Parse(Console.ReadLine());

                Pessoa novo = new Pessoa(nome,idade);
                pessoas.Add(novo);
            }
            Console.WriteLine(Pessoa.ExibirDados(pessoas));
        }
    }
}
