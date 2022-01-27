using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Banco
{
    class Conta
    {
        //variaveis

        public int numero { get { return numero; } set { if (numero > 1) numero = value; else throw new Excecao("O valor iserido é invalido");} }
        public string proprietario {get; set;}
        public double saldo {get; set;}
        public double limiteSaque {get; set;}

        public void deposito(double quantia)
        {
            if(quantia > 0)
            {
                saldo += quantia;
                Console.WriteLine("Seu novo saldo é: {0}", saldo);
            }
            else
            {
                //throw new Excecao("O valor inserido é invalido");
            }
        }
        public void saque(double quantia)
        {
            if(saldo >= quantia || limiteSaque > quantia)
            {
                saldo -= quantia;
            }
            else if(limiteSaque < quantia)
            {
                //throw new Excecao("O limite de saque é menor que a quantia requisitada");
            }
            else if(saldo < quantia)
            {
                //throw new Excecao("O saldo é menor que a quantia requisitada");
            }
            else
            {
                //throw new Excecao("O valor insertido é invalido");
            }
        }
    }
}
