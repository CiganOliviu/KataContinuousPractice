using MinimumSumSequence.MinimumSumEngine;
using NUnit.Framework;

namespace TestMinimumSumSequence
{
    public class Tests
    {
        private IMinimumSumEngine _minimumSumEngine;
        
        [SetUp]
        public void Setup()
        {
            _minimumSumEngine = MinimumSumEngineFactoryObject.GetMinimumSumEngineObject();
        }

        [Test]
        public void TestMinimumSumSequence()
        {
            Assert.IsTrue(_minimumSumEngine.GetMinimumSumSequence(new int[] {5, -6, 3, 4, -2, 3, -3})  == 8);
        }
    }
}