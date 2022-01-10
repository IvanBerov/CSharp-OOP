using System;
using INStock.Contracts;

namespace INStock.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class ProductStockTests
    {
        private IStock productStock;
        private Product dummyProduct;

        [SetUp]
        public void Setup()
        {
            this.productStock = new Stock();
            this.dummyProduct = new Product("SSD", 12.34m, 4);
        }

        [Test]
        public void ConstructorShouldInitializeArray()
        {
            IProduct product = dummyProduct; 

            productStock.Add(product);

            var expectedValue = 1;

            Assert.AreEqual(expectedValue, this.productStock.Capacity);
        }

        [Test]
        public void AddMethodShouldAddSuccessfully()
        {
            productStock.Add(this.dummyProduct);

            Assert.AreEqual(true, productStock.Contains(dummyProduct));
        }

        [Test]
        public void Add_ShouldThrow_InvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => this.productStock.Add(null));
        }

        [Test]
        public void InvalidIndex_ShouldThrow_IndexOutOfRangeException()
        {
            this.productStock.Add(dummyProduct);

            Assert.Throws<IndexOutOfRangeException>(() => this.productStock[1] = this.dummyProduct);
        }
    }
}
