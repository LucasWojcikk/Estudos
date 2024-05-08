using System;
using System.Globalization;

namespace Aula15 {
    class Program {
        static void Main(string[] args) {

            //sbyte x = 100;
            //Console.WriteLine(x);

            /*
            bool completo = false;
            char genero = 'F'; // é possivel utilizar tabela unicode
            char letra = '\u0041'; // utilizando tabela unicode
            byte n1 = 126; // tipo de byte que cabe de 0 a 255
            int n2 = 1000; // int normal
            int n3 = 2147483647; // valor máximo para int
            long n4 = 2147483648L; // para colocar valor de > maior que o valor maximo de int, tem que utilizar o long, colocar sufixo L dps do número.
            float n5 = 4.5f; // para utilizar float colocar o prefixo 'f' no final, senão ele puxa double automaticamente
            double n6 = 4.5; // colocar double normal
            string nome = "Maria Green"; // string normal (string é imutável)
            object obj1 = "Alex Brown"; // tipo genérico de objeto e aceita qualquer tipo primitivo. (string)
            Object obj2 = 4.5f; // objeto genérico recenbdo float

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4); // digitar cw e dar tab 1x
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2); */

            //int n1 = int.MinValue;
            //int n2 = int.MaxValue;
            //sbyte n3 = sbyte.MinValue;
            //sbyte n4 = sbyte.MaxValue;
            //decimal n5 = decimal.MaxValue;

            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //Console.WriteLine(n4);
            //Console.WriteLine(n5);

            //char genero = 'F';
            //int idade = 32;
            //double saldo = 10.35784;
            //string nome = "Maria";

            //Console.Write("Bom dia!");
            //Console.WriteLine("Boa Tarde!");
            //Console.WriteLine("Boa noite!");
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine(genero);
            //Console.WriteLine(idade);
            //Console.WriteLine(saldo);
            //Console.WriteLine(nome);
            //Console.WriteLine(saldo.ToString("F2"));
            //Console.WriteLine(saldo.ToString("F4"));

            // COMANDO PARA TROCAR A VÍRGULA POR PONTO
            //Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));


            // PLACEHOLDER
            //Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            // INTERPOLAÇÃO
            //Console.WriteLine($"{nome} tem {idade} e tem {saldo:F2} reais");


            // EXERCÍCIO

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo o preço é R${preco1:F2}");
            Console.WriteLine($"{produto2}, cujo o preço é R${preco2:F2}");
            Console.WriteLine($"\nRegistro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine($"\nMedida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casa decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: ", medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}

