using System;

namespace Aula34
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos números você vai digitar? ");
            int quantity = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= quantity; i++)
            {
                Console.Write($"Valor #{i}: ");
                sum += int.Parse(Console.ReadLine());

            }

            Console.WriteLine($"A soma dos valores é: {sum}");
        }
    }
}

 