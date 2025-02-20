using System;

namespace Media_entre_alunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media;
            Console.WriteLine("Digite a primeria nota: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a primeria nota: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a primeria nota: ");
            n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a primeria nota: ");
            n4 = Convert.ToDouble(Console.ReadLine());
            media = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine("media: " + media);
            if (media >= 7)
            {
                Console.WriteLine("APROVADO");
            }
            else if (media >= 4 && media < 6)
            {
                Console.WriteLine("RECUPERAÇÃO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
            }

            Console.ReadKey();
        }

    }
}
