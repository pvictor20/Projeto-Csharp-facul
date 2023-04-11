using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício03.cs
{
    internal class Program
    {
        static double dist, litros, ConsumoMedio;
        
        static void EntreadaDados()
        {
            Console.WriteLine("============================###==================");
            Console.WriteLine("Favor informar a distância percorrida em km: ");
            Console.WriteLine("============================###==================");
            dist = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("============================###==================");
            Console.WriteLine("Favor informar o gasto de combustível em litros: ");
            Console.WriteLine("============================###==================");
            litros = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
        }

        static void SaidaConsumo()
        {
            Console.WriteLine("O consumo médio com distância de: " + dist + "km");
            Console.WriteLine("O consumo médio em litros: " + litros + "l");
            Console.WriteLine("O consumo médio de: " + Math.Round(ConsumoMedio, 3) + "km/l");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            EntreadaDados();
            ClassConsumo obj_consumo = new ClassConsumo();// objeto
            ConsumoMedio = obj_consumo.CalculoConsumoMedio(dist, litros);
            SaidaConsumo();
            
        }
    }
}
