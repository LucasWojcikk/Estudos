using System;
using System.Globalization;

namespace Aula41
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle x = new Triangle();
            Triangle y = new Triangle();


            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area_x = x.AreaCalculation();

            double area_y = y.AreaCalculation();


            Console.WriteLine($"Área de X = {area_x.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y = {area_y.ToString("F4", CultureInfo.InvariantCulture)}");
            if (area_x > area_y)
            {
                Console.WriteLine("Maior área: X");
            }
            else if (area_x == area_y)
            {
                Console.WriteLine("A área dos triângulos são iguais.");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

        }
    }
}
