using System;
using System.Linq.Expressions;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario;
            string cargo = "bla";
            double percentual = 0;
            Console.WriteLine("Digite o salário do funcionário");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código do cargo do funcionário (101-104)");
            int code = int.Parse(Console.ReadLine());
            switch (code)
            {
                case 101:
                    cargo = "admnistrador";
                    percentual = 0.008;
                    break;
                case 102:
                    cargo = "engenheiro";
                    percentual = 0.0065; 
                    break;

                case 103:
                    cargo = "médico";
                    percentual = 0.006; 
                    break;

                case 104:
                    cargo = "outro cargo";
                    percentual = 0.0055;
                    break;

                default:
                    Console.WriteLine("código inexistente");
                    return;
            }
            double aument = salario * percentual;
            double novsalario = salario + aument;
            Console.WriteLine("Cargo: " + cargo);
            Console.WriteLine("Salário antigo: " + salario);
            Console.WriteLine("novo salário: " + novsalario);
            Console.WriteLine("diferença: "+aument);
        }
     }
   }
