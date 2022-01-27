using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string nome;
            Console.Write("Digite um nome: ");
            nome = (Console.ReadLine());
            String nome1 = nome;
            String nome2 = nome1.ToLower();
            if (nome2.StartsWith("a"))
            {
                Console.WriteLine("O nome inicia com (a)");
                Console.WriteLine("Seu nome é: {0}", nome1);
            }
            else
            {
                Console.WriteLine("O nome não inicia com (a)");
            }
            */
            /*
            string nome;
            Console.Write("Digite um nome: ");
            nome = (Console.ReadLine());
            String nome1 = nome;

            nome = nome1.Substring(0,4);
            Console.WriteLine("As quatro primeiras letras do nome são: {0}", nome);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(nome1[i]);
            }
            */
            /*
            string nome;
            Console.Write("Digite um nome: ");
            nome = (Console.ReadLine());
            String nome1 = nome;
            int quant = 0;

            Console.WriteLine(nome1.Length);

            foreach (char i in nome1)
            {
                quant += 1; 
            }
            Console.WriteLine(quant);
            */
            /*
            string nomea;
            Console.Write("Digite um nome: ");
            nomea = (Console.ReadLine());
            String nome1 = nomea;
            
            string nomeb;
            Console.Write("Digite outro nome: ");
            nomeb = (Console.ReadLine());
            String nome2 = nomeb;

            if (nome2 == nome1)
            {
                Console.WriteLine("Os nomes são iguais");
            }
            else
            {
                Console.WriteLine("Os nomes são diferentes");
            }

            if (nome1.Contains(nome2) && nome2.Contains(nome1))
            {
                Console.WriteLine("Os nomes são iguais");
            }
            else
            {
                Console.WriteLine("Os nomes são diferentes");
            }
            */
            /*
            string nome;
            Console.Write("Digite um conjunto de numeros: ");
            nome = (Console.ReadLine());
            String nome1 = nome;
            int c = 0, d = 0;
            foreach (char i in nome1)
            {
                Console.WriteLine(nome1[c]);
                if (nome1[c] == '1')
                {
                    d++;
                }
                c++;
            }
            Console.Write(d);
            */
            /*
            string nome;
            Console.Write("Digite um conjunto de numeros: ");
            nome = (Console.ReadLine());
            String nome1 = nome;
            nome1 = nome1.Replace('0', '1');
            Console.WriteLine(nome1);
            */
            /*
            string nome, text = "";
            Console.Write("Digite um nome: ");
            nome = (Console.ReadLine());
            String nome1 = nome;
            nome1 = nome1.Replace('a', ' ');
            nome1 = nome1.Replace('e', ' ');
            nome1 = nome1.Replace('i', ' ');
            nome1 = nome1.Replace('o', ' ');
            nome1 = nome1.Replace('u', ' ');
            
            foreach(char i in nome1)
            {
                if (i != ' ')
                {
                    text += i;
                }
            }
            Console.WriteLine(text);
            */
            /*
            string nome;
            int tot = 0;
            Console.Write("digite uma palavra: ");
            nome = (Console.ReadLine());
            String nome1 = nome;

            foreach(char i in nome1)
            {
                if (i == ' ')
                {
                    tot += 1;
                }
            }
            Console.WriteLine(tot);
            */
            /*
            string nome, texto = "";
            char let, let2;

            Console.Write("digite uma palavra: ");
            nome = (Console.ReadLine());
            String nome1 = nome;
            Console.Write("digite uma letra para busca: ");
            let = char.Parse(Console.ReadLine());
            Console.Write("digite uma letra para substituir a de busca : ");
            let2 = char.Parse(Console.ReadLine());
            foreach (char i in nome1)
            {
                if (i == let)
                {
                    texto += let2;
                }
                else
                {
                    texto += i;
                }
            }
            Console.WriteLine(texto);
            */
            string nomea, nomeb, nomec, res = "", res2 = "";

            Console.Write("digite uma palavra: ");
            nomea = (Console.ReadLine());
            String nome1 = nomea;
            
            Console.Write("outra palavra: ");
            nomeb = (Console.ReadLine());
            String nome2 = nomeb;
            
            if (nome1.Length < nome2.Length)
            {
                nomec = nome2;
            }
            else
            {
                nomec = nome1;
            }
            
            for (int i = 0; i < nomec.Length; i++)
            {
               if (nome1[i] > nome2[i])
                {
                    res = nome2;
                    res2 = nome1;
                    break;
                }
               else if (nome1[i] < nome2[i])
                {
                    res = nome1;
                    res2 = nome2;
                    break;
                }
            }
            

            Console.WriteLine("{0}, {1}", res, res2);
            
               /*
            string nome, texto = "";

            Console.Write("digite uma palavra: ");
            nome = (Console.ReadLine());
            String nome1 = nome;

            for (int i = 0; i < nome1.Length; i++)
            {
                
            }

                
            Console.WriteLine(texto);
               */
        }
        
    }
}
