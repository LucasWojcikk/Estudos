using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula46
{
    class Circle
    {
        //private static double pi = Math.PI;
        private static double pi = 3.14;


        public static void CircleCalculation(double radius)
        {
            double circumference = (2 * pi) * radius;
            double volume = (4.0 / 3.0) * pi * Math.Pow(radius, 3);
            
            Console.WriteLine($"Circunferência: {circumference.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }

    }
}
