using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Forma
    {
        public double basee { get; set; }
        public double altura { get; set; }
        public double area { get; set; }

        public string ExibirPropriedades()
        {
            this.area = basee * altura;
            string dados = string.Format($"A base do seu retangulo é {basee} a sua altura é {altura} e a sua área é {area}");
            return dados;
        }
    }
}
