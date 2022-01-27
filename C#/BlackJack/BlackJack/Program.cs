using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {

        static void Main(string[] args)
        {
            //Variaveis, Listas, Vetores
            decimal saldo = 500, aposta = 0;
            

            while (true)
            {
                int cp = 0, cc = 0, x = 0, kk = 2, z = 0;
                List<string> lista = new List<string>();
                List<string> lcc = new List<string>();
                List<string> lpc = new List<string>();
                List<int> lcc1 = new List<int>();
                List<int> lpc1 = new List<int>();
                string[] op = { "a", "2", "3", "4", "5", "6", "7", "8", "9", "10", "j", "q", "k" };
                int a = 0, a2 = 0, a3 = 0, a4 = 0, a5 = 0, a6 = 0, a7 = 0, a8 = 0, a9 = 0, a10 = 0, aq = 0, aj = 0, ak = 0;
                Console.WriteLine("Seu saldo é: {0}", saldo);
                Console.WriteLine("Digite o valor da aposta"); 
                aposta = decimal.Parse(Console.ReadLine());

                if (saldo >= aposta)
                {
                    //Joagada player
                    while (x < 2)
                    {

                        Random rnd = new Random();
                        cc = rnd.Next(0, 13);
                        lista.Add(op[cc]);
                        lcc.Add(op[cc]);
                        x++;
                    }

                    //Jogada pc
                    while (z < 2)
                    {
                        Random rnd1 = new Random();
                        cp = rnd1.Next(0, 13);
                        lista.Insert(kk, op[cp]);
                        lpc.Add(op[cp]);
                        kk++;
                        z++;
                    }

                    //lista jogada player
                    for (int j = 0; j < lcc.Count; j++)
                    {

                        if (lcc[j] == "j" || lcc[j] == "q" || lcc[j] == "k")
                        {
                            lcc1.Insert(j, 10);
                        }
                        else if (lcc[j] == "a")
                        {
                            lcc1.Insert(j, 1);
                        }
                        else
                        {
                            lcc1.Insert(j, int.Parse(lcc[j]));
                        }
                    }

                    //lista jogada pc

                    for (int k = 0; k < lpc.Count; k++)
                    {

                        if (lpc[k] == "j" || lpc[k] == "q" || lpc[k] == "k")
                        {
                            lpc1.Insert(k, 10);
                        }
                        else if (lpc[k] == "a")
                        {
                            lcc1.Insert(k, 1);
                        }
                        else
                        {
                            lpc1.Insert(k, int.Parse(lpc[k]));
                        }

                    }

                    Console.WriteLine("uma das cartas do pc foi: {0}\n", lpc[1]);

                    Console.WriteLine("Suas cartas foram");
                    //Sistema BlackJack
                    if (lcc.Contains("a") && lcc.Contains("k") || lcc.Contains("a") && lcc.Contains("q") || lcc.Contains("a") && lcc.Contains("j"))
                    {
                        Console.WriteLine("Jogador BlacJack");
                        saldo += aposta;
                        continue;
                    }

                    if (lpc.Contains("a") && lpc.Contains("k") || lpc.Contains("a") && lpc.Contains("q") || lpc.Contains("a") && lpc.Contains("j"))
                    {
                        Console.WriteLine("Pc BlacJack");
                        saldo -= aposta;
                        continue;
                    }

                    int hhhh = lpc1.Sum();
                    int nnnn = lcc1.Sum();
                    while (hhhh < 17)
                    {
                        Random rnd = new Random();
                        cp = rnd.Next(0, 13);
                        if (a > 4 || a2 > 4 || a3 > 4 || a4 > 4 || a5 > 4 || a6 > 4 || a7 > 4 || a8 > 4 || a9 > 4 || a10 > 4 || aq > 4 || aj > 4 || ak > 4)
                        {
                            cp = rnd.Next(0, 13);
                        }
                        else
                        {
                            lista.Add(op[cp]);
                            lpc.Add(op[cp]);
                            hhhh += cp;
                        }

                        for (int i = 0; i < lista.Count; i++)
                        {
                            if (lista[i] == "a")
                            {
                                a++;
                            }
                            else if (lista[i] == "2")
                            {
                                a2++;
                            }
                            else if (lista[i] == "3")
                            {
                                a3++;
                            }
                            else if (lista[i] == "4")
                            {
                                a4++;
                            }
                            else if (lista[i] == "5")
                            {
                                a5++;
                            }
                            else if (lista[i] == "6")
                            {
                                a6++;
                            }
                            else if (lista[i] == "7")
                            {
                                a7++;
                            }
                            else if (lista[i] == "8")
                            {
                                a8++;
                            }
                            else if (lista[i] == "9")
                            {
                                a9++;
                            }
                            else if (lista[i] == "10")
                            {
                                a10++;
                            }
                            else if (lista[i] == "q")
                            {
                                aq++;
                            }
                            else if (lista[i] == "j")
                            {
                                aj++;
                            }
                            else if (lista[i] == "k")
                            {
                                ak++;
                            }
                        }




                    }



                    string opk = "";
                    while (true)
                    {
                        for (int k1 = 0; k1 < lcc.Count; k1++)
                        {
                            Console.WriteLine(lcc[k1]);
                        }

                        Console.WriteLine("\nA soma da tua mão foi: {0}", nnnn);
                        Console.WriteLine("\nSe desejart parar digite * se não pressione enter");
                        opk = Console.ReadLine();

                        if (nnnn > 21)
                        {
                            Console.WriteLine("\nA soma da tua mão passou de 21");
                            break;
                        }

                        if (opk == "*")
                        {
                            break;
                        }

                        else
                        {
                            Random rnd = new Random();
                            cc = rnd.Next(0, 13);
                            if (a > 4 || a2 > 4 || a3 > 4 || a4 > 4 || a5 > 4 || a6 > 4 || a7 > 4 || a8 > 4 || a9 > 4 || a10 > 4 || aq > 4 || aj > 4 || ak > 4)
                            {
                                cc = rnd.Next(0, 13);
                            }
                            else
                            {
                                lista.Add(op[cc]);
                                lcc.Add(op[cc]);
                            }

                            for (int i = 0; i < lista.Count; i++)
                            {
                                if (lista[i] == "a")
                                {
                                    a++;
                                }
                                else if (lista[i] == "2")
                                {
                                    a2++;
                                }
                                else if (lista[i] == "3")
                                {
                                    a3++;
                                }
                                else if (lista[i] == "4")
                                {
                                    a4++;
                                }
                                else if (lista[i] == "5")
                                {
                                    a5++;
                                }
                                else if (lista[i] == "6")
                                {
                                    a6++;
                                }
                                else if (lista[i] == "7")
                                {
                                    a7++;
                                }
                                else if (lista[i] == "8")
                                {
                                    a8++;
                                }
                                else if (lista[i] == "9")
                                {
                                    a9++;
                                }
                                else if (lista[i] == "10")
                                {
                                    a10++;
                                }
                                else if (lista[i] == "q")
                                {
                                    aq++;
                                }
                                else if (lista[i] == "j")
                                {
                                    aj++;
                                }
                                else if (lista[i] == "k")
                                {
                                    ak++;
                                }
                            }

                            if (op[cc] == "a")
                            {
                                nnnn += 1;
                            }
                            else if (op[cc] == "j" || op[cc] == "q" || op[cc] == "k")
                            {
                                nnnn += 10;
                            }
                            else
                            {
                                nnnn += int.Parse(op[cc]);
                            }
                        }
                    }

                    if (nnnn > hhhh && nnnn <= 21 || nnnn <= 21 && hhhh > 21)
                    {
                        Console.WriteLine("\nA soma da mão do pc foi: {0}", hhhh);
                        Console.WriteLine("Voce ganhou");
                        saldo += aposta;
                    }
                    else if (nnnn < hhhh && hhhh <= 21 || nnnn > 21 && hhhh <= 21)
                    {
                        Console.WriteLine("\nA soma da mão do pc foi: {0}", hhhh);
                        Console.WriteLine("Voce perdeu");
                        saldo -= aposta;
                    }
                    else
                    {
                        Console.WriteLine("\nA soma da mão do pc foi: {0}", hhhh);
                        Console.WriteLine("Empate");
                    }
                }
                else
                {
                    Console.WriteLine("Saldo insulficiente");
                }



            }



        }
    }
}
