using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bla, maior = 0;
            Console.WriteLine("digite 15 números aí e o maior a gente vê se te mostra doido");
            for(int i = 0; i<15; i++)
            {
                Console.Write((i + 1)+"° :");
                bla = int.Parse(Console.ReadLine());
                if(bla > maior) maior = bla;
            }
            Console.WriteLine("o maior foi " + maior);
        }
    }
}