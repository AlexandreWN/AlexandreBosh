using System; /*referencia_ao_namespace*/

namespace Teste 
{
    class Program /*declaração_da_classe*/
    {
        static void Main(string[] args) /*declaração_método_main*/
        {
            int x; /*codigo_a_ser_executado*/
            Console.WriteLine("Digite um numero: ");
            x = int.Parse(Console.ReadLine());
            while(true)
            { 
                if (x <= 10)
                {
                    Console.WriteLine(x); 
                    x = x + 1;
                };
                    
            };
            
        }
    }
}


