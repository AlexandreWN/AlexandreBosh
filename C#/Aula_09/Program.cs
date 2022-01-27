using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_09
{
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
            List<string> lista = new List<string>();
            while (true)
            {
                Console.WriteLine("para finalizar digite *");
                Console.WriteLine("digite o nome");
                n = Console.ReadLine();
                if (n == "*")
                {
                    break;
                }
                Console.WriteLine("digite o endereco");
                e = Console.ReadLine();
                Console.WriteLine("digite o telefone");
                t = Console.ReadLine();

                Aluno Jose = new Aluno(n, e, t);

                lista.Add(Jose.Valores());
            }
            
            
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("\n\n{0}", lista[i]);
            }
            */
            /*
            string nome, nome2, op = "";
            List<string> lista = new List<string>();
            while (true)
            {
                Console.WriteLine("Digite * para parar");
                Console.WriteLine("Digite um produto");
                nome = Console.ReadLine();
                if (nome == "*")
                {
                    break;
                }
                lista.Add(nome);
            }
            Console.WriteLine("Digite / para listar os produtos");
            Console.WriteLine("Digite + para inserir um novo produto");
            Console.WriteLine("Digite - para remover um produto");
            Console.WriteLine("Digite * para ordenar os produtos");
            Console.WriteLine("Digite @ para inserir um produto em uma posição especifica");
            Console.WriteLine("Parar programa ç ");
            while (true)
            {
                Console.WriteLine("ESCOLHA SUA OPÇÃO");
                op = Console.ReadLine();
                if (op == "ç")
                {
                    break;
                }
                else if (op == "/")
                {
                    for (int i = 0; i < lista.Count; i++)
                    {
                        Console.WriteLine("\n{0}", lista[i]);
                    }
                }
                else if (op == "-")
                {
                    Console.WriteLine("Digite um nome para remover");
                    nome2 = Console.ReadLine();
                    while (true)
                    {
                        if (lista.Contains(nome2))
                        {
                            lista.Remove(nome2);
                        }
                        else
                        {
                            break;

                        }
                    }

                }
                else if (op == "+")
                {
                    Console.WriteLine("Digite um produto");
                    nome = Console.ReadLine();
                    lista.Add(nome);
                }
                else if (op == "*")
                {
                    lista.Sort();
                }
                else if (op == "@")
                {
                    Console.WriteLine("Digite um produto");
                    nome = Console.ReadLine();
                    Console.WriteLine("Digite onde ele vai ficar");
                    int pos = int.Parse(Console.ReadLine());
                    lista.Insert(pos, nome);
                }

            }*/
            string carro;
            List<string> lista1 = new List<string>();
            List<string> lista2 = new List<string>();
            List<string> lista3 = new List<string>();
        
            int x = 0;
            Console.WriteLine("Digite * para parar");
            do 
            { 
                Console.WriteLine("Digite um carro");
                carro = Console.ReadLine();
                if (carro == "*")
                {
                    break;
                }
                for (int i = 0; i < lista1.Count; i++)
                {
                    if (lista1.Contains(carro))
                    {
                        x = 1;
                        lista1.RemoveAt(i);
                    }
                }
                lista1.Add(carro);
            } while (x == 0);

            string a1 = ("abcdefghijklm");
            string a2 = ("nopqrstuvwxyz");
            for (int i = 0; i < lista1.Count; i++)
            {
                string palavra = lista1[i];
                if (a1.Contains(palavra[0]))
                {
                    lista2.Insert(0, palavra);
                    lista2.Sort();
                }
                else
                {
                    lista3.Insert(0, palavra);
                    lista3.Sort();
                    lista3.Reverse();
                }
            }

            lista2.AddRange(lista3);

            for (int i = 0; i < lista2.Count; i++)
            {
                Console.WriteLine(lista2[i]);
            }
        }

            







      
    }
}
