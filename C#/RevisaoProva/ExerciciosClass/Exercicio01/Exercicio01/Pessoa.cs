using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Pessoa
    {
        private string Nome;
        private int Idade;

        public static string ExibirDados(List<Pessoa> pessoas)
        {
            int idadeMaior = 0, x = 0;
            string nomeEIdade;
            for (int i = 0; i < pessoas.Count; i++)
            {
                if (pessoas[i].Idade > idadeMaior)
                {
                    idadeMaior = pessoas[i].Idade;
                }
            }
            for (int c = 0; c < pessoas.Count; c++)
            {
                if (idadeMaior == pessoas[c].Idade)
                {
                    x = c;
                }
            }
            nomeEIdade = String.Format($"A pessoa mais velha é {pessoas[x].Nome} e sua idade é {pessoas[x].Idade} anos");
            return nomeEIdade;
        }
        public Pessoa()
        {

        }
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
