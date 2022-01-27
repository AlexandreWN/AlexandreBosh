using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_12_03
{
    // Super classe
    abstract class Veiculo
    {

        public abstract void Andar(string andar);
    }

    // Sub classes
    abstract class VeiculoTerrester : Veiculo
    {
        public abstract void Rodas(int rodas);
    }
    abstract class VeiculoAereo : Veiculo
    {
        public abstract void Elic(int elices);
    }
    abstract class VeiculoAquatico : Veiculo
    {
        public abstract void Leme(int leme);
    }
    // Sub Sub classes
    class Carro : VeiculoTerrester
    {

    }
    class Trem : VeiculoTerrester
    {

    }
    class Aviao : VeiculoAereo
    {

    }

    class Barco : VeiculoAquatico
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
