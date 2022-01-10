using System;
using INStock.Contracts;

namespace INStock
{
    public class Product : IProduct
    {
        private string label;
        private decimal price;
        private int quantity;

        public Product(string label, decimal price, int quantity)
        {
            Label = label;
            Price = price;
            Quantity = quantity;
        }

        public string Label
        {
            get => this.label;
            set
            {
                if (value == null)
                {
                    throw new ArgumentException();
                }
                this.label = value;
            }
        }

        public decimal Price
        {
            get => this.price;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price can not be negative or zero!");
                }
                this.price = value;
            }
        }

        public int Quantity
        {
            get => this.quantity;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Quantity can not be negative or zero!");
                }
                this.quantity = value;
            }
        }

        public int CompareTo(IProduct other)
        {
            return this.Label.CompareTo(other.Label);
        }
    }
}
