using GetMaxAndMinFromArray.GetLimitsEngine;
using NUnit.Framework;

namespace GetLimitsEngineTests
{
    public class Tests
    {
        private IGetLimitsEngine _getLimitsEngine;
        
        [SetUp]
        public void Setup()
        {
            _getLimitsEngine = GetLimitsEngineFactory.GetLimitsEngineObject();
        } 

        [Test]
        public void Test_GetMaxFromArray_()
        {
            Assert.IsTrue(_getLimitsEngine.GetMaxFromArray(new int[] {1, 2, 3, 4, 5}) == 5);
            Assert.IsTrue(_getLimitsEngine.GetMaxFromArray(new int[] {-1, -2, -3, -4, -5}) == -1);
        }

        [Test]
        public void Test_GetMinFromArray_()
        {
            Assert.IsTrue(_getLimitsEngine.GetMinFromArray(new int[] {1, 2, 3, 4, 5}) == 1);
            Assert.IsTrue(_getLimitsEngine.GetMinFromArray(new int[] {-1, -2, -3, -4, -5}) == -5);
        }
    }
}