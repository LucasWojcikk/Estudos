using System;
using System.Globalization;

namespace Aula24 {
    class Program {
        static void Main(string[] args) {
           
            Console.WriteLine("Entre com seu nome completo:");
            string name = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int num_bedroom = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double price_product = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string[] lista = Console.ReadLine().Split(' ');
            string lastname = lista[0];
            int age = int.Parse(lista[1]);
            double height = double.Parse(lista[2], CultureInfo.InvariantCulture);


            Console.WriteLine(name);
            Console.WriteLine(num_bedroom);
            Console.WriteLine(price_product.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastname);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
