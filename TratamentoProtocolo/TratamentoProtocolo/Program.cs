using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoProtocolo
{
    internal class Program
    {
        static string Protocolo1, Protocolo2;
        
        
        static void Sub_01()
        {
            Protocolo1 = "AlfaBetaGamaDelta";
            Protocolo2 = "Alfa:Beta:Gama:Delta";

            string D1 = Protocolo1.Substring(0,4);
            string D2 = Protocolo1.Substring(4,4);
            string D3 = Protocolo1.Substring(8,4);
            string D4 = Protocolo1.Substring(12,5);

            string[] vetor = Protocolo2.Split(':');

            Console.WriteLine(D1);
            Console.WriteLine(D2);
            Console.WriteLine(D3);
            Console.WriteLine(D4);

            for(int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }
            Console.ReadKey();
                
        }
        static void Main(string[] args)
        {
            Sub_01();
        }
    }
}
