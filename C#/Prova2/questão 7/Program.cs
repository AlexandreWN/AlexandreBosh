using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questão_7
{
    public struct Pessoa
    {
        public string nome;
        public float altura;
        public string data;
    }
    class Program
    {
        static void Main(string[] args)
        {

            int op;
            Pessoa a = new Pessoa();
            string[] al = new string[3];
            string z, x;
            float c;
            int jj = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("deseja adicionar se sim diigte 1");
                Console.WriteLine("para listar digite 2");
                Console.WriteLine("para parar digite 3");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {

                    Console.WriteLine("Digite o nome");
                    z = Console.ReadLine();
                    Console.WriteLine("Digite a data");
                    x = Console.ReadLine();
                    Console.WriteLine("Digite a altura");
                    c = float.Parse(Console.ReadLine());

                    string u = a.nome;
                    float l = a.altura;
                    string w = a.data;
                    al[i] = u + l + w;

                    a.nome = z;
                    a.altura = c;
                    a.data = x;
                }
                
                else if(op == 2)
                {
                   
                    foreach(string kk in al)
                    {
                        Console.WriteLine(al[jj]);
                        jj++;
                    }
                }
                else
                {
                    break;
                }
            }
            

            

        }
    }
}
