using NUnit.Framework;
using ProductOfPrimeNumbers.ProductOfPrimeNumbersEngine;

namespace TestProductOfPrimeNumbers
{
    public class Tests
    {
        private IProductOfPrimeNumbers _productOfPrimeNumbers;
        
        [SetUp]
        public void Setup()
        {
            _productOfPrimeNumbers = ProductOfPrimeNumbersFactoryObject.GetProductOfPrimeNumbers();
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(_productOfPrimeNumbers.GetProductOfPrimeNumbers(12) == 2310);
            Assert.IsTrue(_productOfPrimeNumbers.GetProductOfPrimeNumbers(8) == 210);
            Assert.IsTrue(_productOfPrimeNumbers.GetProductOfPrimeNumbers(13) == 30030);
        }
    }
}