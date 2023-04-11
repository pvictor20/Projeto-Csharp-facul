using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício03.cs
{
    internal class ClassConsumo
    {
        public double CalculoConsumoMedio(double dist, double litros)
        {
            double  ConsumoMedio = dist/litros;
            return ConsumoMedio;
        }
    }
}
