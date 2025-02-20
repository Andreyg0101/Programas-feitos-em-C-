using System;

namespace Media_entre_alunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N1, N2, N3, media;
            Console.WriteLine("Escreva as notas do aluno: ");
            Console.WriteLine("1º nota: ");
            N1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2º nota: ");
            N2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("3º nota: ");
            N3 = Convert.ToDouble(Console.ReadLine());
            media = (N1 + N2 + N3);
            Console.WriteLine("A média do aluno é: ");
            Console.WriteLine(media);

            Console.ReadKey();
        }
    }
}
