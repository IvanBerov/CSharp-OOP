using System.Collections.Generic;

namespace INStock.Contracts
{
    public interface IStock : IEnumerable<IProduct>
    {
        int Count { get; set; }

        int Capacity { get; }

        IProduct this[int index] { get; set; }

        void Add(IProduct product);

        bool Contains(IProduct product);

        bool Remove(IProduct product);

        IProduct Find(int index);

        IProduct FindByLabel(string label);

        IEnumerable<IProduct> FindAllByPrice(decimal price);

        IEnumerable<IProduct> FindAllByPriceRage(decimal minPrice, decimal maxPrice);

        IProduct FindMostExpensiveProduct(int price);

        IEnumerable<IProduct> FindAllByQuantity(int quantity);


    }
}
