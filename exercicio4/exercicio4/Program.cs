using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            int[] notas = new int[10];
            Console.WriteLine("Insira a nota as 10 notas do aluno para calcular sua média");
            for (int i = 0; i < 10; i++)
            {
                notas[i] = int.Parse(Console.ReadLine());
                if ((notas[i] > 10) || (notas[i] < 0))
                {
                    i--;
                    Console.WriteLine("somente insira valores entre 0 a 10");
                }
                else total = total + notas[i];

            }
            double media;
            media = total/10 ;
            Console.WriteLine("a média desse aluno é:" + media);
        }
    }
}