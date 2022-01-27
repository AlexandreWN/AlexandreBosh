using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string data, hora, data1 , hora1;
            int somad, somah;
            Console.WriteLine("digite um data dd/mm/aaaa");
            data = Console.ReadLine();
            Console.WriteLine("digite a hora hh:mm");
            hora = Console.ReadLine();

            Console.WriteLine("digite a nova data dd/mm/aaaa");
            data1 = Console.ReadLine();
            Console.WriteLine("digite a nova hora hh:mm");
            hora1 = Console.ReadLine();

            data.Split('/');
            hora.Split(':');

            data1.Split('/');
            hora1.Split(':');

            somad = data[0] + data1[0];
            Console.WriteLine(somad);

        }
    }
}
