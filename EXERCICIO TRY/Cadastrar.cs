using System;
using System.Collections.Generic;
using System.Text;

namespace EXERCICIO_TRY
{
    class Cadastrar
    {
        DateTime data_entrada;
        DateTime data_saida;
        int quarto;

        public int getQuarto()
        {
            return this.quarto;
        }
        public void setQuarto(int quarto)
        {
            this.quarto = quarto;
        }
        public DateTime getDataEntrada()
        {
            return this.data_entrada;
        }
        public void setDataEntrada(DateTime data_entrada)
        {
            this.data_entrada = data_entrada;
        }
        public DateTime getDataSaida()
        {
            return this.data_saida;
        }
        public void setDataSaida(DateTime data_saida)
        {
            this.data_saida = data_saida;
        }
    }
}
