using System;
using System.Security.Cryptography.X509Certificates;

namespace Aula40
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Maria";
            person1.Age = 30;

            Person person2 = new Person();
            person2.Name = "João";
            person2.Age = 25;

            if (person1.Age > person2.Age)
            {
                Console.WriteLine($"Pessoa mais velha: {person1.Name}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {person2.Name}");
            }
        }
    }

}
