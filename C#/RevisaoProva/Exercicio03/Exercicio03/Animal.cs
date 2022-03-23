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
    }
}
