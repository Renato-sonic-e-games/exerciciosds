using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char escolha;
            int par = 0, impar = 0, posi = 0, nega = 0;
            do
            {
                Console.WriteLine("digite um número");
                
                int num = int.Parse(Console.ReadLine());
                if (num < 0) nega++;
                if (num > 0) posi++;
                if ((num % 2) == 0) par++;
                if ((num % 2) != 0) impar++;
                do
                {
                    Console.WriteLine("Quer continuar escrevendo números? S/N");
                    escolha = char.Parse(Console.ReadLine());
                } while ((escolha != 'S') && (escolha != 'N'));
            }
            while (escolha == 'S');
            Console.WriteLine("Você escreveu:");
            Console.WriteLine("Impares:" + " " + impar);
            Console.WriteLine("Pares:" + " " + par);
            Console.WriteLine("Positivo:" + " " + posi);
            Console.WriteLine("Negativos:" + " " + nega);

        }
    }
}