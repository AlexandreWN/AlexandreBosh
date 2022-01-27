using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ContaBancaria
    {
        public string nomeCilente;
        public int numConta;
        public float saldo;

        public float sacar(float valor)
        {
            float x = 0;
            x = saldo - valor;
            saldo = x;
            return saldo;
        }

        public float depositar(float valor)
        {
            float y = 0;
            y = saldo + valor;
            saldo = y;
            return saldo;
        }
    }
    class ContaPoupanca : ContaBancaria
    {
        public void CalcularNovoSaldo(float taxa)
        {
            float z = saldo * taxa / 100;
            this.saldo = saldo + z;
        }
    }
    class ContaEspecial : ContaBancaria
    {
        float limite = 1000;
        public float SacarLimite(float sac)
        {
            float yz = limite - sac;
            limite = yz;
            return limite;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crie suaconta");
            Console.WriteLine("Digite o nome");
            string n = Console.ReadLine();
            Console.WriteLine("Digite o numero da conta");
            int nu = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o saldo");
            float sal = float.Parse(Console.ReadLine());
            ContaBancaria cont = new ContaBancaria();
            ContaPoupanca con = new ContaPoupanca();
            cont.nomeCilente = n;
            cont.numConta = nu;
            con.saldo = sal;

            int op = 0;
            while (true)
            {
                Console.WriteLine("digite 1 para sacar, 2 para depositar, 3 paramostrar saldo pelo rend, 4 para mostrar dados da conta");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.WriteLine("Digite o valor que deseja sacar");
                    float valor = float.Parse(Console.ReadLine());
                    cont.sacar(valor);
                }
                else if (op == 2)
                {
                    Console.WriteLine("Digite o valor que deseja depositar");
                    float valor = float.Parse(Console.ReadLine());
                    cont.depositar(valor);
                }
                else if (op == 3)
                {
                    Console.WriteLine("Digite o valor do rendimento");
                    float taxa = float.Parse(Console.ReadLine());
                    con.CalcularNovoSaldo(taxa);
                }
                else if (op == 4)
                {
                    Console.WriteLine(cont.nomeCilente);
                    Console.WriteLine(cont.numConta);
                    Console.WriteLine(con.saldo);

                }

            }



        }
    }
}
