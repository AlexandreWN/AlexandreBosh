using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.pasta
{
    class Class1
    {
        private int numero;
        public int Numero { get { return numero; } set { if (value > 0) numero = value; else throw new Class2("O valor iserido é invalido"); } }
        public string proprietario { get; set; }
        public double saldo { get; set; }
        public double limiteSaque { get; set; }

        public void deposito(double quantia)
        {
            if (quantia < 0)
            {
                throw new Class2("O valor inserido é invalido");
            }
            if (Numero == 0)
            {
                throw new Class2("Conta ainda não cadastrada");
            }
            saldo += quantia;
            Console.WriteLine("Seu novo saldo é: {0}", saldo);
        }
        public void saque(double quantia)
        {
            if (Numero == 0)
            {
                throw new Class2("Conta ainda não cadastrada");
            }
            if (limiteSaque < quantia)
            {
                throw new Class2("O limite de saque é menor que a quantia requisitada");
            }
            if (saldo < quantia)
            {
                throw new Class2("O saldo é menor que a quantia requisitada");
            }
            saldo -= quantia;
        }
    }
}
