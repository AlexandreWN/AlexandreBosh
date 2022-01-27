using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Banco
{
    class Excecao : ApplicationException
    {
        public Excecao(string mensagem) : base (mensagem)
        {

        }
    }
}
