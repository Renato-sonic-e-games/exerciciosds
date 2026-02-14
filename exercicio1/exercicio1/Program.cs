using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=211; i<=250; i++)
            {
                int bla = i % 2;
                if (bla == 0) Console.WriteLine(i);
            }
        }
    }
}