using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_28_09_02
{
    /*
    struct Aluno
    {

        string nome;
        string endereco;
        string tel;
        

        public Aluno(string n, string e, string t)
        {
            nome = n;
            endereco = e;
            tel = t;
        }
        public string Valores()
        {
            string a;
            a = nome + endereco + tel;
            return a;
        }
    }
    */
    struct Aluno
    {

        string nome;
        string endereco;
        string tel;
        

        public Aluno(string n, string e, string t)
        {
            nome = n;
            endereco = e;
            tel = t;
        }
        public string Valores()
        {
            string a;
            a = $"nome: {nome}\n" +
                $"endereço: {endereco}\n" +
                $"teleone: {tel}";
            return a;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            string n = "", e = "", t = "";
            Console.WriteLine("digite o nome");
            n = Console.ReadLine();
            Console.WriteLine("digite o endereco");
            e = Console.ReadLine();
            Console.WriteLine("digite o telefone");
            t = Console.ReadLine();
            Aluno Jose = new Aluno(n,e,t);
            Console.WriteLine(Jose.Valores());
            */

            string n = "", e = "", t = "";
            int tamanho = 0;
            Console.WriteLine("digite o tamanho do array");
            tamanho = int.Parse(Console.ReadLine());
            string [] alunos = new string[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("digite o nome");
                n = Console.ReadLine();
                Console.WriteLine("digite o endereco");
                e = Console.ReadLine();
                Console.WriteLine("digite o telefone");
                t = Console.ReadLine();
                Aluno Jose = new Aluno(n, e, t);
                alunos[i] = Jose.Valores();
            }

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("\n\n{0}", alunos[i]);
            }
        }
    }
}
