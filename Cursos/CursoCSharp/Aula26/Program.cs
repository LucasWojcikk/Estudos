using System;

namespace Aula26
{
    class Program
    {
        static void Main(string[] args) 
        {
            // Operadores tem precedência, que é: !(not) > &&(and) > || (or)
            // Pode usar o parênteses para mudar a precedência
            bool c1 = 2 > 3 && 4 != 5;

            Console.WriteLine(c1);

            bool c2 = 2 > 3 || 4 != 5;

            Console.WriteLine(c2);

            bool c3 = !(2 > 3) && 4 != 5;

            Console.WriteLine(c3);

            bool c4 = 3 < 5;
            bool c5 = c1 || c2 && c3;

            Console.WriteLine(c4);
            Console.WriteLine(c5);



        }
    }
}