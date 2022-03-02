using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcomercce
{
    class produto
    {
        public string nomeProduto { get; set;}
        public double valorProduto { get; set;}
    }
    class compra
    {
        public string nomeProduto { get; set;}
        public float quantidadeProduto { get; set;}
        public double valorProduto { get; set;}
        public double valorTotalProduto { get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            int op = 0, verifica = 0, posi = 0, verifica2 = 0, posi2 = 0;
            string NovoProduto, nomeProdutoCompra;
            double NovoValor, total = 0;
            float quantidadeCompra;
  
            List<produto> Produtos = new List<produto>();
            List<compra> Carrinho = new List<compra>();
            while (x)
            {
                Console.WriteLine("Projeto Ecomercce");
                Console.WriteLine("Digite 1 para cadastrar produto");
                Console.WriteLine("Digite 2 para listar produtos");
                Console.WriteLine("Digite 3 para para comprar produto");
                Console.WriteLine("Digite 4 para visualizar carrinho");
                Console.WriteLine("Digite 5 para fechar pedido");
                Console.WriteLine("Digite 6 para sair do sistema");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        produto estoque = new produto();
                        Console.WriteLine("Digite o nome do produto");
                        NovoProduto = Console.ReadLine();
                        Console.WriteLine("Digite o valor do produto");
                        NovoValor = double.Parse(Console.ReadLine());
                        estoque.nomeProduto = NovoProduto;
                        estoque.valorProduto = NovoValor;

                        Produtos.Add(estoque);
                        break;
                    case 2:
                        for (int i = 0; i < Produtos.Count; i++){
                            Console.WriteLine("\n\nProduto: {0}",Produtos[i].nomeProduto);
                            Console.WriteLine("Valor: {0}", Produtos[i].valorProduto);
                        }
                        break;
                    case 3:
                        compra comprando = new compra();
                        Console.WriteLine("Digite o nome do produto que deseja comprar");
                        nomeProdutoCompra = Console.ReadLine();
                        for (int i = 0; i < Produtos.Count; i++)
                        {
                            if(Produtos[i].nomeProduto == nomeProdutoCompra)
                            {
                                verifica++;
                                posi = i;
                            }
                        }
                        if (verifica > 0)
                        {
                            for (int i = 0; i < Carrinho.Count; i++)
                            {
                                if (Carrinho[i].nomeProduto == nomeProdutoCompra)
                                {
                                    verifica2++;
                                    posi2 = i;
                                }
                            }
                            if (verifica2 > 0)
                            {
                                Console.WriteLine("Digite a quantidade que deseja comprar");
                                quantidadeCompra = float.Parse(Console.ReadLine());
                                Carrinho[posi2].quantidadeProduto += quantidadeCompra;
                                Carrinho[posi2].valorTotalProduto += Produtos[posi].valorProduto * quantidadeCompra;
                            }
                            else
                            {
                                comprando.nomeProduto = nomeProdutoCompra;
                                Console.WriteLine("Digite a quantidade que deseja comprar");
                                quantidadeCompra = float.Parse(Console.ReadLine());
                                comprando.quantidadeProduto = quantidadeCompra;
                                comprando.valorProduto = Produtos[posi].valorProduto;
                                comprando.valorTotalProduto = Produtos[posi].valorProduto * quantidadeCompra;
                            }
                            Carrinho.Add(comprando);
                        }
                        else
                        {
                            Console.WriteLine("Produto não cadastrado");
                        }
                        verifica = 0;
                        verifica2 = 0;
                        break;
                    case 4:
                        for (int i = 0; i < Carrinho.Count; i++)
                        {
                            for (int c = 0; i < Carrinho.Count; i++)
                            {
                                total += Carrinho[c].valorTotalProduto;
                            }
                            Console.WriteLine("\n\nProduto: {0}", Carrinho[i].nomeProduto);
                            Console.WriteLine("Valor: {0}", Carrinho[i].valorProduto);
                            Console.WriteLine("quantidade: {0}", Carrinho[i].quantidadeProduto);
                            Console.WriteLine("Valor total do produto: {0}", Carrinho[i].valorTotalProduto);
                            Console.WriteLine("O valor total do pedido foi: {0}", total);
                        }
                        break;
                    case 5:
                        for (int i = 0; i < Carrinho.Count; i++)
                        {
                            total += Carrinho[i].valorTotalProduto;
                        }
                        Console.WriteLine("O valor total do pedido foi: {0}", total);
                        Console.WriteLine("Pedido concluido");
                        x = false;
                        break;
                    case 6:
                        x = false;
                        break;
                }
            }
        }
    }
}
