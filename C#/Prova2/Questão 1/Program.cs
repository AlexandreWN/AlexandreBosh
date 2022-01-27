using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string rua, cidade, estado, result;

            int numero, qua;
            string re;
            List<string> SP = new List<string>();
            List<string> PR = new List<string>();
            List<string> SC = new List<string>();

            Console.WriteLine("quantos deseja?");
            qua = int.Parse(Console.ReadLine());

            for (int i = 0; i < qua; i++)
            {
                Console.WriteLine("DIgite sua rua");
                rua = Console.ReadLine();
                Console.WriteLine("DIgite o numero");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("DIgite a cidade");
                cidade = Console.ReadLine();
                Console.WriteLine("DIgite o estado");
                estado = Console.ReadLine();

                result = rua + "," + numero + "-" + cidade + "/" + estado;

                if (estado == "SP")
                {
                    SP.Add(result);
                }
                else if(estado == "PR")
                {
                    PR.Add(result);
                }
                else
                {
                    SC.Add(result);
                }
            }
            int c = 0, d =0, e = 0;
            
            if (SP.Any() == true)
            {
                Console.WriteLine("SP");
                foreach (string i in SP)
                {
                    Console.WriteLine(SP[c]);
                    c++;
                }
            }
            
            if (SC.Any() == true)
            {
                Console.WriteLine("SC");
                foreach (string i in SC)
                {
                    Console.WriteLine(SC[d]);
                    d++;
                }
            }
            
            if (PR.Any() == true)
            {
                Console.WriteLine("PR");
                foreach (string i in PR)
                {
                    Console.WriteLine(PR[e]);
                    e++;
                }
            }
            


        }
    }
}
