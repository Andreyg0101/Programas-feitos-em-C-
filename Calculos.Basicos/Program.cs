using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andrey_vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                double n1, n2, r;
                Console.Write("Digite 1º Valor: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite 2º Valor: ");
                n2 = Convert.ToDouble(Console.ReadLine());
                r = n1 + n2;
                Console.WriteLine("Soma: " + r);
                r = n1 - n2;
                Console.WriteLine("Subtração: " + r);
                r = n1 / n2;
                Console.WriteLine("Divisão: " + r);
                r = n1 * n2;
                Console.WriteLine("Multiplicação: " + r);
                Console.ReadKey();
            }
        }
    }
}
