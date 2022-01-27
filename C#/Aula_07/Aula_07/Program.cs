using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_07
{
    public class Bicicleta
    {
        public int velocidade = 0;
        public int marcha = 1;

        public void MudarMarcha (int novaMarcha)
        {
            marcha = novaMarcha;
        }

        public void AumentarVelocidade (int incremento)
        {
            velocidade = velocidade + incremento;
        }
    }

    public class Peixe
    {
        public int speed = 0;
        public int tamanho = 0;
        public string tipo = "";

        public void speeds (int nspeed)
        {
            speed = nspeed;
        }

        public void tamanhos (int ntamanho)
        {
            tamanho = ntamanho;
        }

        public void tipos (string ntipo)
        {
            tipo = ntipo;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Bicicleta bi = new Bicicleta();
            Bicicleta bici = new Bicicleta();
            Bicicleta bicicl = new Bicicleta();

            //VELOCIDADE
            //bi
            Console.WriteLine("bike do Luis");
            Console.WriteLine("velocidade ant: " + bi.velocidade);
            bi.AumentarVelocidade(4);
            Console.WriteLine("velocidade nov: " + bi.velocidade);

            //bici
            Console.WriteLine("\nbike do Bruno");
            Console.WriteLine("velocidade ant: " + bici.velocidade);
            bici.AumentarVelocidade(5);
            Console.WriteLine("velocidade nov: " + bici.velocidade);

            //bicicl
            Console.WriteLine("\nbike do Alexandre");
            Console.WriteLine("velocidade ant: " + bicicl.velocidade);
            bicicl.AumentarVelocidade(6);
            Console.WriteLine("velocidade nov: " + bicicl.velocidade);

            //MARCHA
            //bi
            Console.WriteLine("\n\nbike do Luis");
            Console.WriteLine("Marcha ant: " + bi.marcha);
            bi.MudarMarcha(4);
            Console.WriteLine("Marcha nov: " + bi.marcha);

            //bici
            Console.WriteLine("\nbike do Bruno");
            Console.WriteLine("Marcha ant: " + bici.marcha);
            bici.MudarMarcha(5);
            Console.WriteLine("Marcha nov: " + bici.marcha);

            //bicicl
            Console.WriteLine("\nbike do Alexandre");
            Console.WriteLine("Marcha ant: " + bicicl.marcha);
            bicicl.MudarMarcha(6);
            Console.WriteLine("Marcha nov: " + bicicl.marcha);
            */
            int velo = 0;
            Console.WriteLine("Digite a velocidade do peixe: ");
            velo = int.Parse(Console.ReadLine());
            Peixe pei = new Peixe();
            pei.speeds
        }
    }
}
