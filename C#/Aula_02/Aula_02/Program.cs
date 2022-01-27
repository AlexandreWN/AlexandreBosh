using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Pega dois valores e inverte eles
            int a, b, c;
            Console.WriteLine("Digite o valor de a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de b: ");
            b = int.Parse(Console.ReadLine());

            c = a;
            a = b;
            b = c;

            Console.WriteLine("Seus valores invertidos são: valor de a: {0}, valor de b: {1}", a, b);
            */



            /*
            //Conversor de temperatura

            //variaveis
            float temp, result;
            Console.WriteLine("Digite a temperatura em graus celsos: ");
            temp = int.Parse(Console.ReadLine());

            //converte a temperatura
            result = (9 * temp + 160) / 5;
            Console.WriteLine("Sua temperatura em Fahrenheit é: {0}",result);
            */


            /*
            //Conversor de real para dolar

            //variaveis 
            float dolar, cot, result;
            
            Console.WriteLine("Digite o valor em doalres: ");
            dolar = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a cotação do dolar para real: ");
            cot = int.Parse(Console.ReadLine());

            result = dolar * cot;

            Console.WriteLine("Você possue: {0} dolares e seu valor em reais fica: {1} reais", dolar, result);

            */


            /*
            //Use dois operadores de atribuição

            //variaveis
            float num1, num2;
            string op;
            
            Console.WriteLine("Digite um valor: ");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite + para soma");
            Console.WriteLine("Digite - para subtração");
            Console.WriteLine("Digite * para multiplicação");
            Console.WriteLine("Digite / para divisão\n");

            Console.WriteLine("Digite a operação que deseja: ");
            op = Console.ReadLine();

            if (op == "+")
            {
                num1 += num2;
            }
            else if (op == "-")
            {
                num1 -= num2;
            }
            else if (op == "*")
            {
                num1 *= num2;
            }
            else
            {
                num1 /=num2;
            }

            Console.WriteLine("Seu resultado foi: {0}", num1);

            */

            /*
            //Recebe 3 numeros e faz eles em ordem decrescente

            //variaveis
            int n1, n2, n3, maior, meio, menor, result;

            Console.WriteLine("Digite um valor: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            n3 = int.Parse(Console.ReadLine());

            maior = 0;
            meio = 0;
            menor = 0;

            // Maior
            if (n1 > n2 && n1 > n3)
            {
                maior = n1;
            }
            else if (n2 > n1 && n2 > n3)
            {
                maior = n2;
            }
            else if (n3 > n1 && n3 > n2)
            {
                maior = n3;
            }

            //Meio

            if (n1 > n2 && n1 < n3)
            {
                meio = n1;
            }
            else if (n2 > n1 && n2 < n3)
            {
                meio = n2;
            }
            else if (n3 > n1 && n3 < n2)
            {
                meio = n3;
            }

            //Menor

            if (n1 < n2 && n1 < n3)
            {
                menor = n1;
            }
            else if (n2 < n1 && n2 < n3)
            {
                menor = n2;
            }
            else if (n3 < n1 && n3 < n2)
            {
                menor = n3;
            }

            Console.WriteLine("Seu valor em ordem decrescente é: {0}, {1}, {2}",maior, meio, menor);

            */


            /*
            //Recebe dois valores e calcula media ponderada

            //Variaveis
            float n1, n2, result;
            
            Console.WriteLine("Digite um valor: ");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            n2 = float.Parse(Console.ReadLine());

            result = (n1 * 4 + n2 * 6) / 10;
            Console.WriteLine("Sua média ponderada é: {0}",result);
            */

            /*
              //bytes para gigabytes

              //variaveis
              long a;
              double b;
              Console.WriteLine("Digite um valor em bytes: ");
              a = long.Parse(Console.ReadLine());

              b = a / 1024;

              b /= 1024;

              b /= 1024;

              Console.WriteLine("Seu valor em Gigabytes é: {0}", b);

              */
            /*
            //Entra peso e altura e retorna IMC
            //Variaveis
            float peso, altura, IMC;
            string result;

            Console.WriteLine("Digite o peso: ");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            altura = float.Parse(Console.ReadLine());

            IMC = peso / (altura * altura);

            if (IMC < 20)
            {
                result = "abaixo do peso";
            }
            else if (IMC >= 20 && IMC <= 25)
            {
                result = "no peso correto";
            }
            else
            {
                result = "acima do peso";
            }

            Console.WriteLine("Você está {0}", result);
            */


            /*
            //Le as dimenssões de um retangulo e retorna sua area
            // variaveis 
            float b, a, result;
            
            Console.WriteLine("Digite a base: ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            a = float.Parse(Console.ReadLine());

            result = b * a;

            Console.WriteLine("A área do seu retangulo é: {0}",result);
            */


            /*
            // Le um valor e informa se ele é positivo ou negativo
            // variaveis 
            float n;
            string result;

            Console.WriteLine("Digite um valor: ");
            n = float.Parse(Console.ReadLine());

            if (n >= 0)
            {
                result = "positivo";
            }
            else
            {
                result = "negativo";
            }

            Console.WriteLine("Seu valor é: {0}",result);
            */

            /*
            //Variveis
            float saldo, debito, credito, conta;

            Console.WriteLine("Digite o numero da sua conta: ");
            conta = float.Parse(Console.ReadLine());

            Console.WriteLine("Seu saldo é de 0 reais");
            
            Console.WriteLine("Digite o valor do debito: ");
            debito = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o valor do credito: ");
            credito = float.Parse(Console.ReadLine());

            saldo = credito - debito;

            Console.WriteLine("Sua conta é: {1} e seu saldo é: {0} reais ", saldo, conta);

            if (saldo < 0)
            {
                Console.WriteLine("Sua conta esta negativa");
            }
            else
            {
                Console.WriteLine("Sua conta está positiva");
            }
            */


            //Matriz
            int[] matriz = new int[10];
            // variaveis 
            int x,maior = 0,menor = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um numero");
                x = int.Parse(Console.ReadLine());
                matriz[i] = x;
                if (i == 0)
                {
                    maior = matriz[i];
                    menor = matriz[i];
                }
                else
                {
                    if (matriz[i] > maior)
                    {
                        maior = matriz[i];
                    }
                    if (matriz[i] < menor)
                    {
                        menor = matriz[i];
                    }
                }
                
            }
            Console.WriteLine("Seu maior número é: {0} ", maior);
            Console.WriteLine("Seu menor número é: {0} ", menor);

        }
    }
}
