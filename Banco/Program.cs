using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIAVEIS
            int numero1;
            string proprietario1;
            double saldo1 = 0;
            double limiteSaque1 = 1000;
            double saque1;
            double deposito1;
            int op;
            bool x = true;

            //INSTANCIA OBJETO CLASSE Conta
            Conta ALEATORIA = new Conta();

            try
            {
                while (x)
                {
                    //MENU
                    Console.WriteLine("---------------------------\n+ Digite a opção desejada +\n---------------------------");
                    Console.WriteLine("---------------------------\n+ Digite 1 para cadastrar +\n---------------------------");
                    Console.WriteLine("---------------------------\n+ Digite 2 para sacar din +\n---------------------------");
                    Console.WriteLine("---------------------------\n+ Digite 3 para depositar +\n---------------------------");
                    Console.WriteLine("---------------------------\n+ Digite 4 para detalharr +\n---------------------------");
                    Console.WriteLine("---------------------------\n+ Digite 5 para sair byee +\n---------------------------\n");
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("Digite o nome do proprietario: ");
                            proprietario1 = Console.ReadLine();
                            Console.WriteLine("Digite o numero da conta: ");
                            numero1 = int.Parse(Console.ReadLine());
                            ALEATORIA.proprietario = proprietario1;
                            Console.WriteLine("kkkkkkkkkk");
                            ALEATORIA.numero = numero1;
                            Console.WriteLine("kkkkkkkkkk");
                            ALEATORIA.saldo = saldo1;
                            Console.WriteLine("kkkkkkkkkk");
                            ALEATORIA.limiteSaque = limiteSaque1;
                            Console.WriteLine("kkkkkkkkkk");
                            break;
                        case 2:
                            Console.WriteLine("Digite o valor que deseja sacar: ");
                            saque1 = double.Parse(Console.ReadLine());
                            ALEATORIA.saque(saque1);
                            break;
                        case 3:
                            Console.WriteLine("Digite o valor que deseja depositar: ");
                            deposito1 = double.Parse(Console.ReadLine());
                            ALEATORIA.deposito(deposito1);
                            break;
                        case 4:
                            Console.WriteLine("Usuario: {0}",ALEATORIA.proprietario);
                            Console.WriteLine("Numero da conta {0}",ALEATORIA.numero);
                            Console.WriteLine("Saldo disponivel: {0}",ALEATORIA.saldo);
                            break;
                        case 5:
                            x = false;
                            break;
                    }
                }
                
            }
            catch
            {
                Console.WriteLine("ERRO");
            }

        }
    }
}
