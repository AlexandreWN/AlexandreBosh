using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Animal
    {
        private string tipo;
        private string nome;

        public string Tipo {
            get { return tipo; }
            set {
                if (value == "Gato" || value == "Cachorro")
                {
                    tipo = value;
                }
                else
                {
                    tipo = "Peixe";
                }
            }
        }

        public string Nome {
            get { return nome; }
            set { nome = value; }
        }

        public static void Printar(List<Animal> animais)
        {
            string print;
            for (int i = 0; i < animais.Count; i++)
            {
                print = string.Format($"O tipo do animal é {animais[i].Tipo} e o nome dele é {animais[i].Nome}");
                Console.WriteLine(print);
            }
        }
    }
}
