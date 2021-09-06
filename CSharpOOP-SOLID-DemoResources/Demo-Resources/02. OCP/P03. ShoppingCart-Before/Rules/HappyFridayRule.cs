﻿using System;
using System.Collections.Generic;
using System.Text;
using P03._ShoppingCart;
using P03._ShoppingCart_Before.Contracts;

namespace P03._ShoppingCart_Before.Rules
{
    public class HappyFridayRule : IPriceRule
    {
        public decimal CalculatePrice(OrderItem item)
        {
            return item.Price / 2;
        }

        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("HappyFriday");
        }
    }
}
