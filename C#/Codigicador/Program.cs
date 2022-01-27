using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigicador_Binario
{
    class Program
    {
        static void LetraMai(string frase)
        {
            char caractere;
            for (int i = 0; i < frase.Count(); i++)
            {
                caractere = frase[i];
                if(caractere == 'A')
                {
                    Console.Write("01000001 ");
                }
                else if (caractere == 'B')
                {
                    Console.Write("01000010 ");
                }
                else if (caractere == 'C')
                {
                    Console.Write("01000011 ");
                }
                else if (caractere == 'D')
                {
                    Console.Write("01000100 ");
                }
                else if (caractere == 'E')
                {
                    Console.Write("01000101 ");
                }
                else if (caractere == 'F')
                {
                    Console.Write("01000110 ");
                }
                else if (caractere == 'G')
                {
                    Console.Write("01000111 ");
                }
                else if (caractere == 'H')
                {
                    Console.Write("01001000 ");
                }
                else if (caractere == 'I')
                {
                    Console.Write("01001001 ");
                }
                else if (caractere == 'J')
                {
                    Console.Write("01001010 ");
                }
                else if (caractere == 'K')
                {
                    Console.Write("01001011 ");
                }
                else if (caractere == 'L')
                {
                    Console.Write("01001100 ");
                }
                else if (caractere == 'M')
                {
                    Console.Write("01001101 ");
                }
                else if (caractere == 'N')
                {
                    Console.Write("01001110 ");
                }
                else if (caractere == 'O')
                {
                    Console.Write("01001111 ");
                }
                else if (caractere == 'P')
                {
                    Console.Write("01010000 ");
                }
                else if (caractere == 'Q')
                {
                    Console.Write("01010001 ");
                }
                else if (caractere == 'R')
                {
                    Console.Write("01010010 ");
                }
                else if (caractere == 'S')
                {
                    Console.Write("01010011 ");
                }
                else if (caractere == 'T')
                {
                    Console.Write("01010100 ");
                }
                else if (caractere == 'U')
                {
                    Console.Write("01010101 ");
                }
                else if (caractere == 'V')
                {
                    Console.Write("01010110 ");
                }
                else if (caractere == 'W')
                {
                    Console.Write("01010111 ");
                }
                else if (caractere == 'X')
                {
                    Console.Write("01011000 ");
                }
                else if (caractere == 'Y')
                {
                    Console.Write("01011001 ");
                }
                else if (caractere == 'Z')
                {
                    Console.Write("01011010 ");
                }
            }
        }
        static void LetraMen(string frase)
        {
            char caractere;
            for (int i = 0; i < frase.Count(); i++)
            {
                caractere = frase[i];
                if(caractere == 'a')
                {
                    Console.Write("01100001 ");
                }
                else if (caractere == 'b')
                {
                    Console.Write("01100010 ");
                }
                else if (caractere == 'c')
                {
                    Console.Write("01100011 ");
                }
                else if (caractere == 'd')
                {
                    Console.Write("01100100 ");
                }
                else if (caractere == 'e')
                {
                    Console.Write("01100101 ");
                }
                else if (caractere == 'f')
                {
                    Console.Write("01100110 ");
                }
                else if (caractere == 'g')
                {
                    Console.Write("01100111 ");
                }
                else if (caractere == 'h')
                {
                    Console.Write("01101000 ");
                }
                else if (caractere == 'i')
                {
                    Console.Write("01101001 ");
                }
                else if (caractere == 'j')
                {
                    Console.Write("01101010 ");
                }
                else if (caractere == 'k')
                {
                    Console.Write("01101011 ");
                }
                else if (caractere == 'l')
                {
                    Console.Write("01101100 ");
                }
                else if (caractere == 'm')
                {
                    Console.Write("01101101 ");
                }
                else if (caractere == 'n')
                {
                    Console.Write("01101110 ");
                }
                else if (caractere == 'o')
                {
                    Console.Write("01101111 ");
                }
                else if (caractere == 'p')
                {
                    Console.Write("01110000 ");
                }
                else if (caractere == 'q')
                {
                    Console.Write("01110001 ");
                }
                else if (caractere == 'r')
                {
                    Console.Write("01110010 ");
                }
                else if (caractere == 's')
                {
                    Console.Write("01110011 ");
                }
                else if (caractere == 't')
                {
                    Console.Write("01110100 ");
                }
                else if (caractere == 'u')
                {
                    Console.Write("01110101 ");
                }
                else if (caractere == 'v')
                {
                    Console.Write("01110110 ");
                }
                else if (caractere == 'w')
                {
                    Console.Write("01110111 ");
                }
                else if (caractere == 'x')
                {
                    Console.Write("01111000 ");
                }
                else if (caractere == 'y')
                {
                    Console.Write("01111001 ");
                }
                else if (caractere == 'z')
                {
                    Console.Write("01111010 ");
                }
            }
        }
        static void LetraEspMin(string frase)
        {
            char caractere;
            for (int i = 0; i < frase.Count(); i++)
            {
                caractere = frase[i];
                if(caractere == 'ç')
                {
                    Console.WriteLine("11100111 ");
                }
                else if (caractere == 'Ç')
                {
                    Console.WriteLine("11000111 ");
                }
                else if (caractere == 'á')
                {
                    Console.WriteLine("11100001");
                }
                else if (caractere == 'à')
                {
                    Console.WriteLine("11100000");
                }
                else if (caractere == 'ã')
                {
                    Console.WriteLine("11100011");
                }
                else if (caractere == 'â')
                {
                    Console.WriteLine("11100010 ");
                }
                else if (caractere == 'é')
                {
                    Console.WriteLine("11101001 ");
                }
                else if (caractere == 'è')
                {
                    Console.WriteLine("11101000 ");
                }
                else if (caractere == 'ê')
                {
                    Console.WriteLine("11101010 ");
                }
                else if (caractere == 'í')
                {
                    Console.WriteLine("11101101 ");
                }
                else if (caractere == 'ì')
                {
                    Console.WriteLine("11101100 ");
                }
                else if (caractere == 'î')
                {
                    Console.WriteLine("11101110 ");
                }
                else if (caractere == 'ó')
                {
                    Console.WriteLine("11110011 ");
                }
                else if (caractere == 'ò')
                {
                    Console.WriteLine("11110010 ");
                }
                else if (caractere == 'õ')
                {
                    Console.WriteLine("11110100 ");
                }
                else if (caractere == 'ô')
                {
                    Console.WriteLine("11110101 ");
                }
                else if (caractere == 'ú')
                {
                    Console.WriteLine("11111010 ");
                }
                else if (caractere == 'ù')
                {
                    Console.WriteLine("11111001 ");
                }
                else if (caractere == 'û')
                {
                    Console.WriteLine("11111011 ");
                }
            }
        }
        static void LetraEspMai(string frase)
        {
            char caractere;
            for (int i = 0; i < frase.Count(); i++)
            {
                caractere = frase[i];
                if (caractere == 'À')
                {
                    Console.WriteLine("11000000 ");
                }
                else if(caractere == 'Á')
                {
                    Console.WriteLine("11000001 ");
                }
                else if (caractere == 'Â')
                {
                    Console.WriteLine("11000010 ");
                }
                else if (caractere == 'Ã')
                {
                    Console.WriteLine("11000011 ");
                }
                else if (caractere == 'È')
                {
                    Console.WriteLine("11001000");
                }
                else if (caractere == 'É')
                {
                    Console.WriteLine("11001001");
                }
                else if (caractere == 'Ê')
                {
                    Console.WriteLine("11001010 ");
                }
                else if (caractere == 'Ì')
                {
                    Console.WriteLine("11001100 ");
                }
                else if (caractere == 'Í')
                {
                    Console.WriteLine("11001101 ");
                }
                else if (caractere == 'Î')
                {
                    Console.WriteLine("11001110 ");
                }
                else if (caractere == 'Ò')
                {
                    Console.WriteLine("11010010 ");
                }
                else if (caractere == 'Ó')
                {
                    Console.WriteLine("11010011 ");
                }
                else if (caractere == 'Ô')
                {
                    Console.WriteLine("11010100 ");
                }
                else if (caractere == 'Õ')
                {
                    Console.WriteLine("11010101	");
                }
                else if (caractere == 'Ù')
                {
                    Console.WriteLine("11011001 ");
                }
                else if (caractere == 'Ú')
                {
                    Console.WriteLine("11011010	");
                }
                else if (caractere == 'Û')
                {
                    Console.WriteLine("11011011 ");
                }
            }
        }
        static void Numeros(int numero)
        {
            string nubi = "", nubii = "";
            int kk = numero;
            for (int i = numero; i > 0; i--)
            {
                if (numero % 2 == 0)
                {
                    nubi += "0";
                    numero /= 2;
                }
                else
                {
                    nubi += "1";
                    numero /= 2;
                }
            }
            for (int i = kk; i > 0; i--)
            {
                nubii += nubi[i - 1];
            }
            Console.WriteLine(nubii);
        }
        static void Main(string[] args)
        {
            string frase;
            int c = 0, numero = 0;
            while (c != 2) 
            {
                Console.WriteLine("Digite 0 para numeros, 1 para frases/caracteres ou 2 para sair");
                c = int.Parse(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        Console.WriteLine("Digite uma frase:");
                        frase = Console.ReadLine();
                        Console.WriteLine("\nEM BINARIO:");
                        LetraMai(frase);
                        LetraMen(frase);
                        LetraEspMin(frase);
                        break;
                    case 0:
                        Console.WriteLine("Digite um numero:");
                        numero = int.Parse(Console.ReadLine());
                        Numeros(numero);
                        break;
                }
            }
            

        }
    }
}