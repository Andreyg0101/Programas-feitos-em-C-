using System;

namespace Media_entre_alunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, r;
            Console.Write("Digite o 1° número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o 2° número: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o 3° número: ");
            n3 = Convert.ToDouble(Console.ReadLine());
            r = (n1 + n2 + n3) / 3;
            Console.WriteLine("A média aritmética dos numeros é: " + r);

            Console.ReadKey();
        }
    }
}
