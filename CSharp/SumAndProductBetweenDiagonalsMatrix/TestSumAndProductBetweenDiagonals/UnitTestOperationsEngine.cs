using System;
using NUnit.Framework;
using SumAndProductBetweenDiagonalsMatrix.OperationsEngine;

namespace TestSumAndProductBetweenDiagonals
{
    class UnitTestsOperationsEngine
    {
        private IOperationsEngine _operationsEngine;
        
        [SetUp]
        public void Setup()
        {
            _operationsEngine = OperationsEngineFactoryObject.GetOperationsEngine();
        }
        
        [Test]
        public void Test_ProcessSum_()
        {
            Assert.IsTrue(_operationsEngine.ProcessSum(new int[, ] { {1, 2, 3}, {4, 5, 6}, {7, 8, 9}}, 3) == 30);
        }

        [Test]
        public void Test_ProcessProduct_()
        {
            Assert.IsTrue(_operationsEngine.ProcessProduct(new int[, ] { {1, 2, 3}, {4, 5, 6}, {7, 8, 9}}, 3) == 4725);
        }
    }
}