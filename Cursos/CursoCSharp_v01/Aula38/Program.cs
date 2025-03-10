using System;
using System.Globalization;

namespace Aula38
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Entre com as medidas do triângulo X:");
            //double x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double x3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com as medidas do triângulo Y:");
            //double y1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double y2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double y3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double px = (x1 + x2 + x3) / 2;
            //double ax = Math.Sqrt( px * (px - x1) * (px - x2) * (px - x3));

            //double py = (y1 + y2 + y3) / 2;
            //double ay = Math.Sqrt(py * (py - y1) * (py - y2) * (py - y3));

            //Console.WriteLine($"Área de X = {ax.ToString("F4", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"Área de Y = {ay.ToString("F4", CultureInfo.InvariantCulture)}");
            //if (ax > ay)
            //{
            //    Console.WriteLine("Maior área: X");
            //}
            //else if(ax == ay)
            //{
            //    Console.WriteLine("A área dos triângulos são iguais.");
            //}
            //else
            //{
            //    Console.WriteLine("Maior área: Y");
            //}

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


            double px = (x.A + x.B + x.C) / 2;
            double ax = Math.Sqrt(px * (px - x.A) * (px - x.B) * (px - x.C));

            double py = (y.A + y.B + y.C) / 2;
            double ay = Math.Sqrt(py * (py - y.A) * (py - y.B) * (py - y.C));

            Console.WriteLine($"Área de X = {ax.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y = {ay.ToString("F4", CultureInfo.InvariantCulture)}");
            if (ax > ay)
            {
                Console.WriteLine("Maior área: X");
            }
            else if (ax == ay)
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
