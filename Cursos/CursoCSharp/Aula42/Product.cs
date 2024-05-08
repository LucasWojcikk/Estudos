using System.Globalization;

namespace Aula42
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;
        public double TotalValueStock()
        {
            return Price * Quantity;
        }
        public void AddProducts(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveProducts(int quantity)
        {
            Quantity -= quantity;
        }

        // Override serve para substituir uma função da classe Object
        public override string ToString()
        {
            return Name
            + ", $ "
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantity
            + " unidades, Total: $ "
            + TotalValueStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}


 