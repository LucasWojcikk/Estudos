using System;

namespace Aula30
{
    class Program
    {
        // Aqui é a função de inicialização, similar ao __init__ no Python
        static void Main(string[] args)
        {
            //double a;
            //a = Math.Sqrt(25);
            //Console.WriteLine(a);


            Console.WriteLine("Digite três números:");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            //// Forma de fazer sem utilizar função
            //if (number1 > number2 && number1 > number3) 
            //{
            //    Console.WriteLine($"Maior número é o: {number1}");
            //}

            //else if (number2 > number3)
            //{
            //    Console.WriteLine($"Maior número é o: {number2}");
            //}

            //else 
            //{
            //    Console.WriteLine($"Maior número é o: {number3}");
            //}



            double result = Bigger(number1, number2, number3);

            Console.WriteLine($"O Maior número é o: {result}");

        }
        
        // Assim que cria função no C#, muito similar ao Python, você cria uma função dentro da classe normalmente
        static int Bigger(int number1, int number2, int number3)
        {
            int bigger;

            if (number1 > number2 && number1 > number3)
            {
                bigger = number1;
            }

            else if (number2 > number3) 
            {
                bigger = number2;
            }

            else
            {
                bigger = number3;
            }

            return bigger;

        }

    }
}
