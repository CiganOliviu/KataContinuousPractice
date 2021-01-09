using DifferenceBetweenFibonacciAndFactorial.FibonacciEngine;
using NUnit.Framework;

namespace SystemTests
{
    public class TestFibonacciModules
    {
        private IFibonacciEngine _fibonacciEngine;
        
        [SetUp]
        public void Setup()
        {
            _fibonacciEngine = FibonacciEngineFactoryObject.GetFibonacciEngineObject();
        }

        [Test]
        public void Test_GetFibonacciNumberRecursive_()
        {
            Assert.IsTrue(_fibonacciEngine.GetFibonacciNumberRecursive(8) == 21);
            Assert.IsTrue(_fibonacciEngine.GetFibonacciNumberRecursive(12) == 144);
            Assert.IsTrue(_fibonacciEngine.GetFibonacciNumberRecursive(2) == 1);
            Assert.IsTrue(_fibonacciEngine.GetFibonacciNumberRecursive(5) == 5);
        }

        [Test]
        public void Test_GetFibonacciNumber_()
        {
            Assert.IsTrue(_fibonacciEngine.GetFibonacciNumber(8) == 21);
            Assert.IsTrue(_fibonacciEngine.GetFibonacciNumber(12) == 144);
            Assert.IsTrue(_fibonacciEngine.GetFibonacciNumber(2) == 1);
            Assert.IsTrue(_fibonacciEngine.GetFibonacciNumber(5) == 5);
        }
    }
}