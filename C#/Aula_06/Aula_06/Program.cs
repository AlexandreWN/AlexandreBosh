using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06
{
    class Program
    {
        
        public static void soma(float n1, float n2)
        {
            float soma;
            soma = n1 + n2;
            Console.WriteLine("O resultado da soma é: {0}", soma);
        }
        public static void sub(float n1, float n2)
        {
            float sub;
            sub = n1 - n2;
            Console.WriteLine("O resultado da soma é: {0}", sub);
        }
        public static void mult(float n1, float n2)
        {
            float mult;
            mult = n1 * n2;
            Console.WriteLine("O resultado da soma é: {0}", mult);
        }
        public static void div(float n1, float n2)
        {
            float div;
            div = n1 / n2;
            Console.WriteLine("O resultado da soma é: {0}", div);
        }
       
        public static void num (int n)
        {
            if (n > 0)
            {
                Console.WriteLine("Positivo");
            }
            else if (n < 0)
            {
                Console.WriteLine("Negativo");
            }
            else
            {
                Console.WriteLine("valor nulo");
            }

        }
    
        public static int valid(int n1, int n2)
        {
            int x;
            if (n1 < n2)
            {
                x = -1;
                return (x);
            }
            else if (n1 > n2)
            {
                x = 0;
                return (x);
            }
            else
            {
                x = 1;
                return (x);
            }
        }
       

        public static int parinp(int n)
        {
            int x;
            if (n % 2 == 0)
            {
                
                x = 1;
                return (x);
            }
            else
            {
                x = -1;
                return (x);
            }
        }
        
        public static void elev(int n1, int n2)
        {
            int x = n1;
            for (int i = 1; i < n2; i++)
            {
                x *= n1;
            }
            Console.WriteLine(x);
        }

        public static void vog(string pa)
        {
            int tot = 0;
            foreach (char i in pa)
            {   
                if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
                {
                    tot += 1;
                }
            }
            Console.WriteLine(tot);
        }

        public static void raizc(int n1)
        {
            double result;
            result = Math.Pow(n1, 1.0 / 3);
            Console.WriteLine(result);
        }

        public static void cons(string pa)
        {
            int tot = pa.Length;
            foreach (char i in pa)
            {
                if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
                {
                    tot--;
                }
            }
            Console.WriteLine(tot);
        }

        public static double ck(double c)
        {
            double k = 0;
            k = c + 273.15;
            return k;
        }

        public static void brank(string pala)
        {
            int tot = pala.Length;
            foreach (char i in pala)
            {
                if (i != ' ')
                {
                    tot--;
                }
            }
            Console.WriteLine(tot);
        }

        public static int num1(int nume)
        {
            int tot = 0;
            int x;
            for (int i = 1; i <= nume; i++)
            {
                if (nume % i == 0 || nume % i == nume)
                {
                    tot++;
                }
            }
            if (tot == 2)
            {
                x = 1;
                return (x);
            }
            else
            {
                x = 0;
                return (x);
            }
        }
        public static void data(string d)
        {
            string mes1;
            string meses =""; 
            string[] mes = d.Split('/');
            mes1 = (mes[1]);
            int dia = int.Parse(mes[0]);
            int mess = int.Parse(mes[1]);
            if (dia > 0 && dia < 32 && mess > 0 && mess < 13)
            {
                if (mes1 == "01" || mes1 == "1")
                {
                    meses = "janeiro";
                }
                else if (mes1 == "02" || mes1 == "2")
                {
                    meses = "fevereiro";
                }
                else if (mes1 == "03" || mes1 == "3")
                {
                    meses = "março";
                }
                else if (mes1 == "04" || mes1 == "4")
                {
                    meses = "abril";
                }
                else if (mes1 == "05" || mes1 == "5")
                {
                    meses = "maio";
                }
                else if (mes1 == "06" || mes1 == "6")
                {
                    meses = "junho";
                }
                else if (mes1 == "07" || mes1 == "7")
                {
                    meses = "julho";
                }
                else if (mes1 == "08" || mes1 == "8")
                {
                    meses = "agosto";
                }
                else if (mes1 == "09" || mes1 == "9")
                {
                    meses = "setembro";
                }
                else if (mes1 == "10")
                {
                    meses = "outubro";
                }
                else if (mes1 == "11")
                {
                    meses = "novembro";
                }
                else if (mes1 == "12")
                {
                    meses = "dezembro";
                }

                Console.WriteLine("{0} de {1} de {2}", mes[0], meses, mes[2]);
            }
            else
            {
                Console.WriteLine("data invalida");
            }
        }


        static void Main(string[] args)
        {
            /*
            float n1, n2;
            string op;

            Console.WriteLine("Digite um numero: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o operador EX((+),(-),(*),(/): ");
            op = Console.ReadLine();

            if (op == "+")
            {
                soma(n1, n2);
            }
            else if (op == "-")
            {
                sub(n1, n2);
            }
            else if (op == "*")
            {
                mult(n1, n2);
            }
            else if (op == "/")
            {
                div(n1, n2);
            }
            */
            /*
            int n;
            Console.WriteLine("Digite um numero: ");
            n = int.Parse(Console.ReadLine());
            num(n);
            */
            /*
            int n1, n2;
            Console.WriteLine("Digite um valor");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(valid(n1, n2));
            */
            /*
            int n;
            Console.WriteLine("Digite um valor");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(parinp(n));
            */
            /*
            int n1 = 0, n2 = 0;

            Console.WriteLine("Digite um numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero: ");
            n2 = int.Parse(Console.ReadLine());

            elev(n1, n2);
            */
            /*
            string pa;
            Console.WriteLine("digite uma palavra: ");
            pa = Console.ReadLine();
            vog(pa);
            */
            /*
            int n1 = 0;
            Console.Write("Digite um valor: ");
            n1 = int.Parse(Console.ReadLine());
            raizc(n1);
            */
            /*
            string pa;
            Console.WriteLine("digite uma palavra: ");
            pa = Console.ReadLine();
            cons(pa);
            */
            /*
            double c;
            Console.WriteLine("digite o valor em Graus C: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine(ck(c));
            */
            /*
            string pala;
            Console.WriteLine("digite uma palavra: ");
            pala = Console.ReadLine();
            brank(pala);
            */
            /*
            int nume = 0;
            Console.WriteLine("Digite um numero: ");
            nume = int.Parse(Console.ReadLine());
            if (num1(nume) == 1)
                Console.WriteLine("primo");
            else
            {
                Console.WriteLine("não é primo");
            }
            */
            string d;
            Console.WriteLine("digite uma data formato dd/mm/aaaa: ");
            d = Console.ReadLine();
            data(d);
        }
    }
}
