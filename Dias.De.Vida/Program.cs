using System;

namespace Dias.De.Vida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Mes, Anos, Dias, r;
            Console.WriteLine("Digite quantos anos, meses e dias você tem: ");
            Console.WriteLine("Anos: ");
            Anos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Meses: ");
            Mes = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("dias: ");
            Dias = Convert.ToDouble(Console.ReadLine());
            r = (Anos * 365) + (Mes * 30) + Dias;
            Console.WriteLine("Você tem: " + r + " " + "dias de vida");

            Console.ReadKey();
        }
    }
}
