using System;
using System.Globalization;

namespace Aula23{
    class Program{
        static void Main(string[] args){

            Console.WriteLine("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            //  CultureInfo.InvariantCulture é utilizado para trocar " , " por " . " na hora de digitar aqui e no print la embaixo
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"Você digitou: {n1}");
            Console.WriteLine(ch);
            //  CultureInfo.InvariantCulture usado para trocar " , " por " . " aqui no print final
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        } 
    }
}
