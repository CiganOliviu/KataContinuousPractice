using DifferenceBetweenFibonacciAndFactorial.FactorialEngine;
using DifferenceBetweenFibonacciAndFactorial.FibonacciEngine;
using NUnit.Framework;

namespace SystemTests
{
    public class TestFactorialModule
    {
        private IFactorialEngine _factorialEngine;
        
        [SetUp]
        public void Setup()
        {
            _factorialEngine = FactorialEngineFactoryObject.GetFactorialEngineObject();
        }

        [Test]
        public void Test_GetFactorialNumberRecursive_()
        {
            Assert.IsTrue(_factorialEngine.GetFactorialNumberRecursive(3) == 6);
            Assert.IsTrue(_factorialEngine.GetFactorialNumberRecursive(7) == 5040);
            Assert.IsTrue(_factorialEngine.GetFactorialNumberRecursive(5) == 120);
            Assert.IsTrue(_factorialEngine.GetFactorialNumberRecursive(0) == 1);
        }

        [Test]
        public void Test_GetFactorialNumber_()
        {
            Assert.IsTrue(_factorialEngine.GetFactorialNumber(3) == 6);
            Assert.IsTrue(_factorialEngine.GetFactorialNumber(7) == 5040);
            Assert.IsTrue(_factorialEngine.GetFactorialNumber(5) == 120);
            Assert.IsTrue(_factorialEngine.GetFactorialNumber(0) == 1);
        }
    }
}