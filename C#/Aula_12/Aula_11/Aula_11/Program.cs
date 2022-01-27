using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11
{
    class Animal
    {
        public virtual void Mover()
        {
            Console.WriteLine("Andando 1 metro");
        }
    }
    class Peixe : Animal
    {
        public override void Mover()
        {
            Console.WriteLine("Nadar 1 metro");
        }
    }

    class Cobra : Animal
    {
        public override void Mover()
        {
            Console.WriteLine("Rasteja 1 metro");
        }
    }

    class Jacare : Animal
    {
        int x = 0;
        public override void Mover()
        {
            
            for (int i = 0; i < 10000; i++)
            {
                Task.Delay(250).Wait();
                Console.WriteLine("Jacaré andando {0}", x);
                x++;
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Peixe peixe = new Peixe();
            Cobra cobra = new Cobra();
            Jacare jac = new Jacare();
            animal.Mover();
            peixe.Mover();
            cobra.Mover();
            jac.Mover();
            
        }
    }
}
