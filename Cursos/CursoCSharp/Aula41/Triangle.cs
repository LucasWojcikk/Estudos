using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula41
{
    class Triangle
    {
        public double A;
        public double B;
        public double C;

        public double AreaCalculation()
        {
            double perimeter = (A + B + C) / 2;
            double area = Math.Sqrt(perimeter * (perimeter - A) * (perimeter - B) * (perimeter - C));

            return area;
        }

    }
}
