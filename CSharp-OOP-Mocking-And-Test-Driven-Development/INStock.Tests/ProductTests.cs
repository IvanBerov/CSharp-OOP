using System;

namespace INStock.Tests
{
    using NUnit.Framework;
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void Ctor_ShouldInitializeCorrectly()
        {
            string label = "Loco";
            decimal price = 3.30m;
            int quantity = 5;

            Product product = new Product(label, price, quantity);

            Assert.AreEqual(label, product.Label);
            Assert.AreEqual(price, product.Price);
            Assert.AreEqual(quantity, product.Quantity);
        }

        [Test]
        [TestCase("AAA", -1.5d, 3)]
        [TestCase(null, 1.2d, 5)]
        [TestCase("BBB", 2.5d, 0)]
        public void Ctor_ShouldThrowException(string label, decimal price, int quantity)
        {
            Assert.Throws<ArgumentException>(() => new Product(label, price, quantity));
        }

        [Test]
        public void CompareTo_ShouldReturn_LabelWithGreaterASCIISum()
        {
            var firstProductLabel = "Zom";
            var firsProductPrice = 2.12m;
            var firstProductQuantity = 3;

            var secondProductLabel = "Dom";
            var secondProductPrice = 4.13m;
            var secondProductQuantity = 2;

            var firstProduct = new Product(firstProductLabel, firsProductPrice, firstProductQuantity);
            var secondProduct = new Product(secondProductLabel, secondProductPrice, secondProductQuantity);

            var result = firstProduct.CompareTo(secondProduct);
            Assert.AreEqual(1, result);
        }
    }
}