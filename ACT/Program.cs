using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ACT.pasta;
using System.Threading.Tasks;

namespace Banco
{

    class Program
    {
        static void Main(string[] args)
        {
            //VARIAVEIS
            int numero;
            string proprietario1;
            double saldo1 = 0;
            double limiteSaque1 = 1000;
            double saque1;
            double deposito1;
            int op;
            bool x = true;

            //INSTANCIA OBJETO CLASSE Conta
            Class1 ALEATORIA = new Class1();
            while (x)
            {
                try
                {
                    //MENU
                    Console.WriteLine("-----------------------\nDigite a opção desejada");
                    Console.WriteLine("-----------------------\nDigite 1 para cadastrar");
                    Console.WriteLine("-----------------------\nDigite 2 para sacar");
                    Console.WriteLine("-----------------------\nDigite 3 para depositar");
                    Console.WriteLine("-----------------------\nDigite 4 para detalhar");
                    Console.WriteLine("-----------------------\nDigite 5 alterar limite");
                    Console.WriteLine("-----------------------\nDigite 6 mostrar limite");
                    Console.WriteLine("-----------------------\nDigite 7 para sair byee\n");
                    op = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("Digite o nome do proprietario: ");
                            proprietario1 = Console.ReadLine();
                            Console.WriteLine("Digite o numero da conta: ");
                            numero = int.Parse(Console.ReadLine());
                            ALEATORIA.proprietario = proprietario1;
                            ALEATORIA.Numero = numero;
                            ALEATORIA.saldo = saldo1;
                            ALEATORIA.limiteSaque = limiteSaque1;
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
                            if (ALEATORIA.Numero == 0)
                            {
                                throw new Class2("Conta ainda não cadastrada");
                            }
                            Console.WriteLine("Usuario: {0}", ALEATORIA.proprietario);
                            Console.WriteLine("Numero da conta {0}", ALEATORIA.Numero);
                            Console.WriteLine("Saldo disponivel: {0}", ALEATORIA.saldo);
                            break;
                        case 5:
                            if (ALEATORIA.Numero == 0)
                            {
                                throw new Class2("Conta ainda não cadastrada");
                            }
                            Console.WriteLine("Digite o novo limite: ");
                            limiteSaque1 = double.Parse(Console.ReadLine());
                            break;
                        case 6:
                            if (ALEATORIA.Numero == 0)
                            {
                                throw new Class2("Conta ainda não cadastrada");
                            }
                            Console.WriteLine("Seu limite de saque atual é {0}", limiteSaque1);
                            Console.WriteLine("\nPrecione qualquer tecla para continuar");
                            Console.ReadKey();
                            break;
                        case 7:
                            x = false;
                            break;
                    }
                }
                   
                catch (Exception e)
                {
                     Console.WriteLine($"ERRO\n{e.GetType()}: {e.Message}");
                     Console.WriteLine("Precione qualquer tecla para continuar");
                     Console.ReadKey();
                     Console.Clear();
                     continue;
                }

            }
        }
    }
}
