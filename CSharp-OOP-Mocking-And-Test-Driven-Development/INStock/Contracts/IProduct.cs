using System;

namespace INStock.Contracts
{
    public interface IProduct : IComparable<IProduct>
    {
        public string Label { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
