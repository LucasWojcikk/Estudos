﻿using System.Globalization;

namespace Aula51
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Quantidade no estoque: ");
            //int quantity = int.Parse(Console.ReadLine());

            //Product p = new Product(name, price, quantity);
            Product p = new Product(name, price);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AddProduct(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoveProduct(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
