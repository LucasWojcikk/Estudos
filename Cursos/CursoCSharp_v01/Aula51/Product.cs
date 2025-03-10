using System.Globalization;

namespace Aula51
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        // Nesse caso estou passando construtor padrão, sem argumentos algum
        public Product()
        {
        }

        // Nesse caso estou passando que meu construtor precisa de 3 argumentos para ser iniciado
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        // Neste construtor estou passando que são necessários 2 argumetos para ser iniciado
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            // Valores numéricos por padrão ja são iniciados com 0, está aqui para vizualização apenas
            Quantity = 5;
        }

        public double TotalValueStock()
        {
            return Price * Quantity;
        }

        public void AddProduct(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveProduct(int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + "unidade, Total: $ "
                + TotalValueStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}