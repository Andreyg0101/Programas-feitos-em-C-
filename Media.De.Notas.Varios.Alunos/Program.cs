using System;

namespace Media.De.Notas.Varios.Alunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, media, soma = 0;
            int qal;
            Console.WriteLine("Digite quantos alunos tem: ");
            qal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite as notas:");
            for (int c = 1; c <= qal; c++)
            {
                num = Convert.ToDouble(Console.ReadLine());
                soma = soma + num;
            }
            media = soma / qal;
            Console.WriteLine("Média: " + media);

            Console.ReadKey();
        }

    }
}
