using System.Globalization;

namespace Aula55
{
    class Product
    {
        private string _name;
        public double Price
        {
            get; private set;
        }
        public double Quantity
        {
            get; set;
        }
        public Product()
        {
        }
        public Product(string nome, double preco, int quantidade)
        {
            _name = nome;
            Price = preco;
            Quantity = quantidade;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }
    }
}