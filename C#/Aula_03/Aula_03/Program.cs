using System;

namespace Aula_03
{
    class Program
    {
        static void Main(string[] args)
        {/*
            int n = 0;
            int valor;
            int soma = 0;
            int z = 0;
            while (true)
            {
                Console.WriteLine("Digite um valor: ");
                valor = int.Parse(Console.ReadLine());
                if (z == 0 && valor == 0)
                {
                    Console.WriteLine("Digite um valor: ");
                    valor = int.Parse(Console.ReadLine());
                }
                if (valor != n)
                {
                    soma += valor;
                    n = valor;
                }
                else
                {
                    break;
                }
                z += 1;
            }
            Console.WriteLine("A soma dos seus valores é: {0}", soma);
            */
            /*
            float n1, n2, result = 0;
            int i = 0;
            string operador;
            float[] matriz = new float[10000];
            while (true)
            {
                Console.WriteLine("Bem vindo a calculadora");

                Console.WriteLine("Digite o valor 1: ");
                n1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor 1: ");
                n2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Escolha seu operador");
                Console.WriteLine("Para soma digite (+) ");
                Console.WriteLine("Para subtração digite (-) ");
                Console.WriteLine("Para multiplicação digite (*) ");
                Console.WriteLine("Para divisão digite (/) ");
                Console.WriteLine("Para finalizar digite (s)");
                operador = Console.ReadLine();

                if (operador == "s")
                {
                    break;
                }
                else
                {
                    if (operador == "+")
                    {
                        result = n1 + n2;

                    }
                    else if (operador == "-")
                    {
                        result = n1 - n2;
                    }
                    else if (operador == "*")
                    {
                        result = n1 * n2;
                    }
                    else if (operador == "/")
                    {
                        result = n1 / n2;
                    }
                    matriz[i] = result;
                    i += 1;
                }
            }
                Console.WriteLine("Seus resultados são: ");
            for (int c = 0; c < i; c++)
                {
                    Console.WriteLine(matriz[c]);
                }
            */
            /*
            float valor;
            int neg = 0, posi = 0;
            while (true)
            {
                Console.WriteLine("Para sair digite (0) ");
                Console.Write("Digite um valor: ");
                valor = float.Parse(Console.ReadLine());
                if (valor == 0)
                {
                    break;
                }
                else
                {
                    if (valor < 0)
                    {
                        neg += 1;
                    }
                    else
                    {
                        posi += 1;
                    }
                }

            }
            Console.WriteLine("Voce teve: {0} valores positivos e {1} valores negativos", posi, neg);
            */
            /*
            int senha, tent;
            Console.WriteLine("Grave sua senha de quatro digitos: ");
            senha = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Digite sua senha: ");
                tent = int.Parse(Console.ReadLine());
                if (senha == tent)
                {
                    Console.WriteLine("Senha correta");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha incorreta, tente novamente");
                }
                

            }
            */
            int valor, resu = 1;
            Console.WriteLine("Digite um valor: ");
            valor = int.Parse(Console.ReadLine());
            for(int i = 1; i <= valor; i++)
            {
                resu *= i;
            }
            Console.WriteLine(resu);
        }   
    }
}
