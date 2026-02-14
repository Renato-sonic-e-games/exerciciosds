using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite 2 números para a gente ver os números impares q tem entre eles doido");
            int num1, num2;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            if (num1 < num2)
            {
                for (int i = num1; i <= num2; i++)
                {
                    int bla1 = i % 2;
                    if (bla1 == 1) Console.WriteLine(i);
                }
            }
            if (num1 > num2)
            {
                for (int i = num2; i <= num1; i++)
                {
                    int bla = i % 2;
                    if (bla == 1) Console.WriteLine(i);
                }
            }
        }
    }
}