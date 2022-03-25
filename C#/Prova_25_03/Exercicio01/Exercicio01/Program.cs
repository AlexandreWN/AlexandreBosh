using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Vo
    {
        private int passageiros;
        private int numero;

        public Vo(){}
        public Vo(int passageiros, int numero) { 
            this.passageiros = passageiros;
            this.numero = numero;
        }

        public int Passageiros
        {
            get { return passageiros; }
            set { passageiros = value; }
        }
        public int Numero { 
            get { return numero; }
            set { numero = value; }
        }

        public static int proximoLivre(List<int> lista)
        {
            int cadeira = 0;
            for(int i = 0; i < lista.Count; i++)
            {
                cadeira = lista[i] + 2;
            }
            return cadeira;
        }

        public static string verifica(List<int> lista, int cadeira)
        {
            int x = 0;
            for (int i = 0; i < lista.Count; i++)
            {                
                if(lista[i] == cadeira)
                {
                    x++;
                }
            }
            if(x == 0)
            {
                return "Cadeira disponivel";
            }
            else
            {
                return "Cadeira indisponivel";
            }
        }

        public static string ocupa(List<int> lista, int cadeira)
        {
            int x = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == cadeira)
                {
                    x++;
                }
            }
            if (x == 0)
            {
                return "Operação bem sucedida";
            }
            else
            {
                return "Operação mal sucedida";
            }
        }
        public static int vagas(List<int> lista)
        {
            int quantidade = 100 - lista.Count;
            return quantidade;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            int cadeira;
            List<int> lista = new List<int>();
            Vo novo = new Vo(70,177);
            
            for (int i = 0; i < 20; i++)
            {
                lista.Add(i);
            }
            
            while (x)
            {
                int op;
                Console.WriteLine("Digite a opção");
                Console.WriteLine("Digite 1 para ver o numero da proxima cadeira");
                Console.WriteLine("Digite 2 para ver o se acadeira está ocupada");
                Console.WriteLine("Digite 3 para ocupar cadeira");
                Console.WriteLine("Digite 4 para Ver o numero de vagas");
                Console.WriteLine("Digite 5 para Ver o numero do Voo");
                Console.WriteLine("Digite 6 para Ver a data");
                Console.WriteLine("Digite 7 para sair");
                op = int.Parse(Console.ReadLine());
                
                switch (op)
                {
                    case 1:
                        Console.WriteLine(Vo.proximoLivre(lista));
                        break;
                    case 2:
                        Console.WriteLine("Digite o numero da cadeira");
                        cadeira = int.Parse(Console.ReadLine());
                        Console.WriteLine(Vo.verifica(lista, cadeira));
                        break;
                    case 3:
                        Console.WriteLine("Digite o numero da cadeira");
                        cadeira = int.Parse(Console.ReadLine());
                        if (Vo.verifica(lista, cadeira) == "Operação bem sucedida")
                        {
                            Console.WriteLine("Operação bem sucedida");
                            lista.Add(cadeira);
                        }
                        else
                        {
                            Console.WriteLine("Operação mal sucedida");
                        }
                        break;
                    case 4:
                        Console.WriteLine(Vo.vagas(lista));
                        break;
                    case 5:
                        Console.WriteLine(novo.Numero);
                        break;
                    case 6:
                        break;
                    case 7:
                        x = false;
                        break;
                }
            }
        }
    }
}