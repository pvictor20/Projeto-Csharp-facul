using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoRepeticao1
{
    internal class Program
    {
        static int a, b, c, d;

        static void loop01()
        {
            for (int i = 0; i <= 100; i++)//teste no incio
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            for (int i = 100; i >=0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        static void loop02() 
        {
            a = 0;
            while(a <=10)//teste no inicio
            {
                Console.WriteLine(a);
                a += 1;
            }
            Console.ReadKey();

            b = 0;
            do
            {
                Console.WriteLine(b);
                b += 1;
            }
            while(b <=10);
        }
        static void Main(string[] args)
        {
            loop01();
            loop02();
        }
    }
}
