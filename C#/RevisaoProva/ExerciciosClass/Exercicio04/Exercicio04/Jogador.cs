using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class Jogador
    {
        private int id;
        private int numero;
        private int qualidade;
        private int cartaoAmarelo;
        private int cartaoVermelho;
        private string nome;
        private string apelido;
        private string posicao;
        private bool suspenso;
        private bool treinou;
        private DateTime dataNascimento;

        public Jogador()
        {

        }

        public Jogador(int id, string nome, string apelido, DateTime dataNascimento, int numero, string posicao, int qualidade, int amarelo, int vermelho, bool suspenso, bool treinou)
        {
            this.id = id;
            this.nome = nome;
            this.apelido = apelido;
            this.dataNascimento = dataNascimento;
            this.numero = numero;
            this.posicao = posicao;
            this.qualidade = qualidade;
            this.cartaoAmarelo = amarelo;
            this.cartaoVermelho = vermelho;
            this.suspenso = suspenso;
            this.treinou = treinou;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public int Qualidade
        {
            get { return qualidade; }
            set { qualidade = value; }
        }
        public int CartaoAmarelo
        {
            get { return cartaoAmarelo; }
            set { cartaoAmarelo = value; }
        }
        public int CartaoVermelho
        {
            get { return cartaoVermelho; }
            set { cartaoVermelho = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Apelido
        {
            get { return apelido; }
            set { apelido = value; }
        }
        public string Posicao
        {
            get { return posicao; }
            set { posicao = value; }
        }
        public bool Suspenso
        {
            get { return suspenso; }
            set { suspenso = value; }
        }

        public bool Treinou
        {
            get { return treinou; }
            set { treinou = value; }
        }

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public static bool Verifica(int Amarelo, int Vermelho)
        {
            if (Amarelo >= 3 || Vermelho >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void aplicarCartao(int vermelho, int amarelo, List<Jogador> jogadores, int id)
        {
            for (int i = 0; i < jogadores.Count; i++)
            {
                if (jogadores[i].id == id)
                {
                    jogadores[i].CartaoAmarelo += amarelo;
                    jogadores[i].CartaoVermelho += vermelho;
                }
            }
            for (int i = 0; i < jogadores.Count; i++)
            {
                if (Jogador.Verifica(jogadores[i].CartaoAmarelo, jogadores[i].CartaoVermelho) == true)
                {
                    jogadores[i].Suspenso = true;
                }
                else
                {
                    jogadores[i].Suspenso = false;
                }
            }
        }
        public static void cumprirSuspencao(List<Jogador> jogadores, int id)
        {
            for (int i = 0; i < jogadores.Count; i++)
            {
                if (jogadores[i].id == id)
                {
                    jogadores[i].suspenso = false;
                }
            }
        }
        public static void sofrerLesao(List<Jogador> jogadores, int id)
        {
            Random randNum = new Random();
            int rand;
            rand = randNum.Next(0, 100);
            for (int i = 0; i < jogadores.Count; i++)
            {
                if (jogadores[i].id == id)
                {
                    if(rand <= 40)
                    {
                        if(jogadores[i].qualidade >= 1)
                        {
                            jogadores[i].qualidade -= 1;
                        }
                        else
                        {
                            jogadores[i].qualidade = 0;
                        }
                    }
                    if(rand <= 70 && rand > 40)
                    {
                        if (jogadores[i].qualidade >= 2)
                        {
                            jogadores[i].qualidade -= 2;
                        }
                        else
                        {
                            jogadores[i].qualidade = 0;
                        }
                    }
                    if (rand <= 85 && rand > 70)
                    {
                        if (jogadores[i].qualidade - (jogadores[i].qualidade * 5) / 100 >= 0)
                        {
                            jogadores[i].qualidade -= (jogadores[i].qualidade * 5) / 100;
                        }
                        else
                        {
                            jogadores[i].qualidade = 0;
                        }
                    }
                    if (rand <= 95 && rand > 85)
                    {
                        if (jogadores[i].qualidade - (jogadores[i].qualidade * 10) / 100 >= 0)
                        {
                            jogadores[i].qualidade -= (jogadores[i].qualidade * 10) / 100;
                        }
                        else
                        {
                            jogadores[i].qualidade = 0;
                        }
                    }
                    if (rand <= 100 && rand > 85)
                    {
                        if (jogadores[i].qualidade - (jogadores[i].qualidade * 15) / 100 >= 0)
                        {
                            jogadores[i].qualidade -= (jogadores[i].qualidade * 15) / 100;
                        }
                        else
                        {
                            jogadores[i].qualidade = 0;
                        }
                    }
                }
            }
        }
        public static void executarTreinamento(List<Jogador> jogadores, int id)
        {
            Random randNum = new Random();
            int rand;
            rand = randNum.Next(0, 100);
            for (int i = 0; i < jogadores.Count; i++)
            {
                if (jogadores[i].id == id && jogadores[i].treinou == false)
                {
                    if (rand <= 40)
                    {
                        if (jogadores[i].qualidade <= 99)
                        {
                            jogadores[i].qualidade += 1;
                        }
                        else
                        {
                            jogadores[i].qualidade = 100;
                        }
                    }
                    if (rand <= 70 && rand > 40)
                    {
                        if (jogadores[i].qualidade <= 98)
                        {
                            jogadores[i].qualidade += 2;
                        }
                        else
                        {
                            jogadores[i].qualidade = 100;
                        }
                    }
                    if (rand <= 85 && rand > 70)
                    {
                        if (jogadores[i].qualidade + (jogadores[i].qualidade * 5) / 100 <= 100)
                        {
                            jogadores[i].qualidade += (jogadores[i].qualidade * 5) / 100;
                        }
                        else
                        {
                            jogadores[i].qualidade = 100;
                        }
                    }
                    if (rand <= 95 && rand > 85)
                    {
                        if (jogadores[i].qualidade + (jogadores[i].qualidade * 10) / 100 <= 100)
                        {
                            jogadores[i].qualidade += (jogadores[i].qualidade * 10) / 100;
                        }
                        else
                        {
                            jogadores[i].qualidade = 100;
                        }
                    }
                    if (rand <= 100 && rand > 85)
                    {
                        if (jogadores[i].qualidade + (jogadores[i].qualidade * 15) / 100 <= 100)
                        {
                            jogadores[i].qualidade += (jogadores[i].qualidade * 15) / 100;
                        }
                        else
                        {
                            jogadores[i].qualidade = 100;
                        }
                    }
                    jogadores[i].treinou = true;
                }
            }
        }
    }
}
