using System;

namespace Aula28
{
    class Program
    {
        static void Main(string[] args)
        {
            // É preciso inicializar a variavel e seu valor fora do escopo do if
            // (igual em Python onde não consigo acessar uma variável de dentro da função
            double discount = 0.0;

            Console.WriteLine("Digite o valor do produto: ");
            double price = double.Parse(Console.ReadLine());

            if (price > 100.0) {
                discount = price * 0.1;
            }

            Console.WriteLine($"Total de desconto para esse produto é de: {discount} reais.");

        }
    }
}