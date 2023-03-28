using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    internal class Program
    {   
        struct Concurso
        {  //atributos
           public double Matematica, Portugues, Redacao;
           public double Ciencia, Historia, Geografia;
            
            
           public Concurso(double Ma, double Po, double Re, double Cie, double Hi, double Geo)
            {
                this.Matematica = Ma;
                this.Portugues = Po;
                this.Redacao = Re;
                this.Ciencia = Cie;
                this.Historia = Hi;
                this.Geografia = Geo;
            }

            public bool TesteRedMat()
            {
                bool Teste = true;
                if(Redacao < 50 || Matematica < 50)
                {
                    Teste = false;
                }
                return Teste;
            }

            public double MediaConcurso()
            {
                double Media = (Portugues + Matematica + Redacao + Ciencia + Historia + Geografia) / 6;
                return Media;
            }
        }

        static double PT, MATE, RED, CIE, HIS, GEO;
        static void EntradaDados()
        {
            Console.WriteLine("**************#######*******************");
            Console.WriteLine("Favor digitar a nota de Matemática: ");
            Console.WriteLine("**************#######*******************");
            MATE = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("**************#######*******************");
            Console.WriteLine("Favor digitar a nota de Português: ");
            Console.WriteLine("**************#######*******************");
            PT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("**************#######*******************");
            Console.WriteLine("Favor digitar a nota de Redação: ");
            Console.WriteLine("**************#######*******************");
            RED = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("**************#######*******************");
            Console.WriteLine("Favor digitar a nota de Ciências: ");
            Console.WriteLine("**************#######*******************");
            CIE = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("**************#######*******************");
            Console.WriteLine("Favor digitar a nota de História: ");
            Console.WriteLine("**************#######*******************");
            HIS = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("**************#######*******************");
            Console.WriteLine("Favor digitar a nota de Geografia: ");
            Console.WriteLine("**************#######*******************");
            GEO = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

        }
        static void Main(string[] args)
        {
            EntradaDados();
            Concurso obj_concurso = new Concurso(MATE, PT, RED, CIE, HIS, GEO);
            Console.WriteLine("Média do candidato: " + obj_concurso.MediaConcurso());
            Console.WriteLine("Teste Redação e Matemática: " + obj_concurso.TesteRedMat());
            Console.ReadKey();

        }
    }
}
