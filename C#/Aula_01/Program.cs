using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoCSharp
{
    class Program
    {
        static void Main()
        {
            /*
            //Declarar variaveis
            int a = 15;
            int b = 7;

            //inicio do codigo
            string nome = null;
            string m1 = "maio";
            string m2 = "junho";
            bool aprovado = true;
            //Inicio da aplicação
            Console.WriteLine("meus meses preferidos são: {1} e {0}", m1, m2);
            if (aprovado)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

            //Fim do código
            */

            // EXERCICIO 01 
            /*
            //Declaração de Variaveis
            int val1;
            int val2;
            
            //Inicio do código

            //Recebe os valores
            Console.WriteLine("Digite um Valor: ");
            val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro valor: ");
            val2 = int.Parse(Console.ReadLine());

            //Soma
            Console.WriteLine("A soma dos seus valores é: {0}", val1 + val2);

            //Subtração
            Console.WriteLine("A subtração dos seus valores é: {0}", val1 - val2);

            //Multiplicação
            Console.WriteLine("A multiplicação dos seus valores é: {0}" , val1 * val2);
            
            //Divisão
            Console.WriteLine("A multiplicação dos seus valores é: {0}", val1 / val2);
            */
            //Fim do código

            //EXERCICIO 02
            /*
            //Declaração de variaveis
            float dist;
            float total;

            //inicio do código
            // Recebe os valores
            Console.WriteLine("Digite a Distancia percorrida: ");
            dist = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o gasto de combustivel: ");
            total = float.Parse(Console.ReadLine());

            //Faz o calculo do consumo

            Console.WriteLine("O consumo medio foi de: {0} {1}", dist / total, "km/litro");

            //Fim do codigo

            */

            //EXERCICIO 03

            //Declarar variaveis
            string nome;
            float n1;
            float n2;
            float n3;

            //inicio do codigo
            //Recebe os valores
            Console.WriteLine("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a nota 1 do aluno: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 2 do aluno: ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 3 do aluno: ");
            n3 = float.Parse(Console.ReadLine());

            //Calcula e mostra a média

            Console.WriteLine("O nome do Aluno é:{0} {1} {2}", nome, "Sua média foi: ", (n1 + n2 + n3) / 3);
        }
    }
}
