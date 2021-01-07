using CountDivisorsOfTheSameParity.CountDivisorsEngine;
using NUnit.Framework;

namespace TestCountDivisorsObject
{
    public class Tests
    {
        private ICountDivisors _countDivisors;
        
        [SetUp]
        public void Setup()
        {
            _countDivisors = CountDivisorsFactoryObject.GetCountDivisorsObject();
        }

        [Test]
        public void Test_CountOddDivisors_()
        {
            Assert.IsTrue(_countDivisors.CountOddDivisors(12) == 2);
            Assert.IsTrue(_countDivisors.CountOddDivisors(24) == 2);
            Assert.IsTrue(_countDivisors.CountOddDivisors(3) == 2);
        }

        [Test]
        public void Test_CountEvenDivisors_()
        {
            Assert.IsTrue(_countDivisors.CountEvenDivisors(12) == 4);
            Assert.IsTrue(_countDivisors.CountEvenDivisors(24) == 6);
            Assert.IsTrue(_countDivisors.CountEvenDivisors(3) == 0);
            
            Assert.Pass();
        }
    }
}