using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace INStock.Contracts
{
    public class Stock : IStock
    {
        private List<IProduct> products;

        public Stock()
        {
            this.products = new List<IProduct>();
        }

        public int Count { get; set; }

        public int Capacity
        {
            get => this.products.Count;
        }

        public IProduct this[int index]
        {
            get
            {
                return this.products[index];
            }
            set
            {
                if (index > products.Count - 1 || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                this.products[index] = value;
            }
            
        }

        public void Add(IProduct product)
        {
            if (product == null)
            {
                throw new InvalidOperationException("Add a valid Product !");
            }

            if (!this.products.Contains(product))
            {
                this.products.Add(product);
                this.Count++;
            }
        }

        public bool Contains(IProduct product)
        {
            return this.products.Any(p => p.Label == product.Label);
        }

        public bool Remove(IProduct product)
        {
            return this.products.Remove(product);
        }

        public IProduct Find(int index)
        {
            if (this.Count < index + 1 || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            return this[index];
        }

        public IProduct FindByLabel(string label)
        {
            if (this.All(x => x.Label != label))
            {
                throw new ArgumentException();
            }

            return this.products.FirstOrDefault(p => p.Label == label);
        }

        public IEnumerable<IProduct> FindAllByPrice(decimal price)
        {
            List<IProduct> listByPrice = new List<IProduct>();

            foreach (var product in products)
            {
                if (product.Price == price)
                {
                    listByPrice.Add(product);
                }
            }

            return listByPrice;
        }

        public IEnumerable<IProduct> FindAllByPriceRage(decimal minPrice, decimal maxPrice)
        {
            List<IProduct> listByPriceRange = new List<IProduct>();

            foreach (var product in products)
            {
                if (product.Price >= minPrice && product.Price <= maxPrice)
                {
                    listByPriceRange.Add(product);
                }
            }

            return listByPriceRange.OrderByDescending(p=>p.Price);
        }

        public IProduct FindMostExpensiveProduct(int price)
        {
            var maxPrice = products.Max(p=>p.Price);

            IProduct product = products.First(p => p.Price == maxPrice);

            return product;
        }

        public IEnumerable<IProduct> FindAllByQuantity(int quantity)
        {
            var listByQuantity = products.Where(p => p.Quantity == quantity);

            return listByQuantity;
        }

        public IEnumerator<IProduct> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return products[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
