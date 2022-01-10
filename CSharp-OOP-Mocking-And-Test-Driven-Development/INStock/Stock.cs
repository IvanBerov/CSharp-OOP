﻿using System;
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
                if (index > this.Count || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                return this.products[index];
            }
            set => this.products[index] = value;
        }

        public void Add(IProduct product)
        {
            if (!this.products.Contains(product))
            {
                this.products.Add(product);
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
            throw new System.NotImplementedException();
        }

        public IEnumerable<IProduct> FindAllByPrice(decimal price)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<IProduct> FindAllByPriceRage(decimal minPrice, decimal maxPrice)
        {
            throw new System.NotImplementedException();
        }

        public IProduct FindMostExpensiveProduct(int price)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<IProduct> FindAllByQuantity(int quantity)
        {
            throw new System.NotImplementedException();
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
