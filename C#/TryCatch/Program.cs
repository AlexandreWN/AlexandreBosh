using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Digite um numero: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro numero: ");
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;
                Console.WriteLine("O resultado de sua divisão foi: {0}", result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("ERRO PIRANHA ZERO NÂO DIVIDE KRL!!" + " "+ e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("ERRO LETRA NÂO DIVIDE PIRANHA KRL!!" + " "+ e.Message);
            }
                  

        }
    }
}
