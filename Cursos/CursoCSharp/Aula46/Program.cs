using System;
using System.Globalization;

namespace Aula46
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Entre com o valor do raio: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Circle.CircleCalculation(radius);
        }
    }
}