using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_12_02
{
    class ContaBancaria
    {
        string nomeCliente;
        int numConta;
        decimal saldo;
        
        public virtual void Saque(decimal saque)
        {
            this.saldo = saldo - saque;
        }
        public void Deposito(decimal deposito)
        {
            this.saldo = saldo + deposito;
        }

        public decimal GetSaldo()
        {
            return saldo;
        }

        public decimal GetSaqueDeposito()
        {
            return saldo;
        }

        public string GetNomeCliente()
        {
            return nomeCliente;
        }

        public int GetNumConta()
        {
            return numConta;
        }

        public void SetSaqueDeposito(decimal num)
        {
            this.saldo = num + saldo;
        }

        public void SetNomeCliente(string x)
        {
            this.nomeCliente = x;
        }

        public void SetNumConta(int n)
        {

            this.numConta = n;
        }

        public void SetSaldo(decimal s)
        {
            this.saldo = saldo - s;
        }

    }

    class ContaPoupanca : ContaBancaria
    {
        public override void Saque(decimal s)
        {
            SetSaldo(s);
        }

    }

    class ContaEspecial : ContaBancaria
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria jose = new ContaBancaria();
            ContaPoupanca ale = new ContaPoupanca();
            string x = "alex";
            decimal num = 1000;
            int n = 145255;
            decimal s = 10;
            jose.SetNomeCliente(x);
            jose.SetSaqueDeposito(num);
            jose.SetNumConta(n);
            jose.Saque(10);
            jose.Deposito(100);
            ale.SetSaqueDeposito(num);
            ale.SetSaldo(15);
            Console.WriteLine(jose.GetNomeCliente());
            Console.WriteLine(jose.GetNumConta());
            Console.WriteLine(jose.GetSaqueDeposito());
            Console.WriteLine(ale.GetSaldo());
        }
    }
}
