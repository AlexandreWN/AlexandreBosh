using System;

namespace EXERCICIO_TRY
{
    class Program
    {
        public static int Duration(DateTime entrada, DateTime saida)
        {
            TimeSpan duration = saida.Subtract(entrada);
            return (int)duration.TotalDays;
        }
        static void Main(string[] args)
        {
            int quarto;
            DateTime data_entrada;
            DateTime data_saida;
            int op;
            bool x = true;
            Cadastrar RANDON = new Cadastrar();
            DateTime Now;
            string text = "";
            while (x)
            {
                try
                {
                    //MENU
                    Console.WriteLine("\nDigite 1 para cadastrar\nDigite 2 para atualizar data\nDigite 3 para mostrar dados da reserva\nDigite 4 para sair");
                    Console.WriteLine("Digite a opcao desejada: ");
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            while (true)
                            {
                                Console.Write("Digite o numerto do quarto: ");
                                quarto = int.Parse(Console.ReadLine());

                                Console.Write("Digite a data de entrada dd/mm/aaaa: ");
                                data_entrada = DateTime.Parse(Console.ReadLine());

                                Console.Write("Digite a data de saida dd/mm/aaaa: ");
                                data_saida = DateTime.Parse(Console.ReadLine());


                                Now = DateTime.Now;

                                if (data_entrada <= data_saida && data_entrada >= Now)
                                {
                                    RANDON.setQuarto(quarto);
                                    RANDON.setDataEntrada(data_entrada);
                                    RANDON.setDataSaida(data_saida);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nData de entrada maior que a de saida tente novamente: \n");
                                }
                            }

                            break;
                        case 2:
                            while (true)
                            {
                                Console.Write("Digite a data de entrada dd/mm/aaaa: ");
                                data_entrada = DateTime.Parse(Console.ReadLine());

                                Console.Write("Digite a data de saida dd/mm/aaaa: ");
                                data_saida = DateTime.Parse(Console.ReadLine());

                                Now = DateTime.Now;

                                if (data_entrada < data_saida && data_entrada > Now)
                                {
                                    RANDON.setDataEntrada(data_entrada);
                                    RANDON.setDataSaida(data_saida);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nData de entrada menor que a de saida tente novamente: \n");
                                }
                            }
                            break;
                        case 3:
                            Console.WriteLine("Numero do quarto: {0}",RANDON.getQuarto());
                            Console.WriteLine("Data de entrada: {0}", RANDON.getDataEntrada());
                            Console.WriteLine("Data de saida: {0}",RANDON.getDataSaida());
                            Console.WriteLine("Dias de reserva:{0} dias.\n", Duration(RANDON.getDataEntrada(), RANDON.getDataSaida()));
                            break;
                        case 4:
                            x = false;
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("O tipo de dado inserido não é valido");
                }
            }
        }
    }
}
