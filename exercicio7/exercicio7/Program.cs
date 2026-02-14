using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia1, dia2, mes1, mes2;
            do
            {
                Console.Write("digite o dia do aniversario do primeiro usuario: ");
                dia1 = int.Parse(Console.ReadLine());

                Console.Write("digite o mês do aniversario do usuário 1: ");
                mes1 = int.Parse(Console.ReadLine());

                if (dia1 < 1 || dia1 > 31 || mes1 < 1 || mes1 > 12)
                    Console.WriteLine("data invalida, digite denovo");

            } while (dia1 < 1 || dia1 > 31 || mes1 < 1 || mes1 > 12);
            do
            {
                Console.Write("digite o dia do aniversario do segundo usuario: ");
                dia2 = int.Parse(Console.ReadLine());

                Console.Write("digite o mês do anivesario do segundo usuario: ");
                mes2 = int.Parse(Console.ReadLine());

                if (dia2 < 1 || dia2 > 31 || mes2 < 1 || mes2 > 12)
                    Console.WriteLine("data invalida, digite denovo");

            } while (dia2 < 1 || dia2 > 31 || mes2 < 1 || mes2 > 12);

            if (mes1 < mes2 || (mes1 == mes2 && dia1 < dia2))
            {
                Console.WriteLine("o primeiro usuario faz aniversario antes");
            }
            else if (mes2 < mes1 || (mes1 == mes2 && dia2 < dia1))
            {
                Console.WriteLine("o segundo usuario faz aniversario antes");
            }
            else
            {
                Console.WriteLine("os dois fazem aniversario no mesmo dia");
            }
        }
    }
}