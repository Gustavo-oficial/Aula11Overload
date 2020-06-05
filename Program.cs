using System;

namespace Aula11Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculos num = new Calculos();

            Console.WriteLine(num.Calcular());

            System.Console.WriteLine(num.Calcular("100", "200"));

            Console.WriteLine(num.Calcular(100, 200));

        }
    }
}