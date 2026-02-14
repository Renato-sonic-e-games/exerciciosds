using System;
using System.Runtime.InteropServices.Marshalling;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char escolha;
            int N;
            double S = 0, E = 0;
            do {
                Console.WriteLine("qual é o número de horas trabalhadas pelo operário?");
                N = int.Parse(Console.ReadLine());
                if (N <= 50)
                {
                    S = N * 100.00;
                    E = 0;
                }
                if (N > 50)
                {
                    S = 50 * 100.00;
                    E = (N - 50) * 20.00;
                }
                double stotal = S + E;
                Console.WriteLine("seu salário total é: " + stotal);
                Console.WriteLine("seu salário base é: " + S);
                Console.WriteLine("seu salário excendente é: " + E);

                
                do {
                    Console.WriteLine("Deseja encerrar o programa? S/N");
                    escolha = char.Parse(Console.ReadLine());
                } while ((escolha != 'S') && (escolha != 'N'));
            }
            while (escolha == 'N');
        }
    }
}