using System.Linq;
using NUnit.Framework;
using SortArray.SortEngine;

namespace TestSortEngine
{
    public class Tests
    {
        private ISortEngine _sortEngine;
        
        [SetUp]
        public void Setup()
        {
            _sortEngine = SortEngineFactoryObject.GetSortEngineObject();
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(_sortEngine.BubbleSortArray(new int[] {5, 4, 3, 2, 1}).SequenceEqual((new int[] {1, 2, 3, 4, 5})));
        }
    }
}