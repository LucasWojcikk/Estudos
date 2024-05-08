using System;
using System.Globalization;

namespace Aula32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double number1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (number1 >= 0.0)
            {
                double sqrt = Math.Sqrt(number1);

                Console.WriteLine(sqrt.ToString("F2", CultureInfo.InvariantCulture));


                Console.Write("Digite outro número: ");
                number1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            Console.WriteLine("Número negativo!");

        }
    }
}
