using System;

namespace EXERCICIO_TRY
{
    class Program
    {
        static void Main(string[] args)
        {
            int quarto;
            DateTime data_entrada;
            DateTime data_saida;
            int op;
            bool x = true;
            Cadastrar RANDON =  new Cadastrar();
            DateTime Now;
            while (x)
            {
                //MENU
                Console.WriteLine("Digite 1 para cadastrar\nDigite 2 para atualizar data\nDigite 3 para mostrar dados da reserva\nDigite 4 para sair");
                Console.WriteLine("Digite a opcao desejada: ");
                op = int.Parse(Console.ReadLine());
                try
                {
                    switch (op)
                    {
                        case 1:
                            while(true){
                                Console.WriteLine("Digite o numerto do quarto: ");
                                quarto = int.Parse(Console.ReadLine());

                                Console.WriteLine("Digite a data de entrada dd/mm/aaaa: ");
                                data_entrada = DateTime.Parse(Console.ReadLine());

                                Console.WriteLine("Digite a data de saida dd/mm/aaaa: ");
                                data_saida = DateTime.Parse(Console.ReadLine());


                                Now = DateTime.Now;

                                if(data_entrada < data_saida && data_entrada > Now){
                                    RANDON.setQuarto(quarto);
                                    RANDON.setDataEntrada(data_entrada);
                                    RANDON.setDataSaida(data_saida);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Data de entrada menor que a de saida tente novamente: ");
                                }
                            }
                            
                            break;
                        case 2:
                            while(true){
                                Console.WriteLine("Digite a data de entrada dd/mm/aaaa: ");
                                data_entrada = DateTime.Parse(Console.ReadLine());

                                Console.WriteLine("Digite a data de saida dd/mm/aaaa: ");
                                data_saida = DateTime.Parse(Console.ReadLine());

                                Now = DateTime.Now;

                                if(data_entrada < data_saida && data_entrada > Now){
                                    RANDON.setDataEntrada(data_entrada);
                                    RANDON.setDataSaida(data_saida);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Data de entrada menor que a de saida tente novamente: ");
                                }
                            }
                            break;
                        case 3:
                            Console.WriteLine(RANDON.getQuarto());
                            Console.WriteLine(RANDON.getDataEntrada());
                            Console.WriteLine(RANDON.getDataSaida());
                            break;
                        case 4:
                            x = false;
                            break;
                    }
                }
                catch 
                {
                    Console.WriteLine("DEU ERRO:");
                }
            }
        }
    }
}
