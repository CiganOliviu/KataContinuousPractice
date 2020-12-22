using System;
using BinarySearch.SearchEngine;

namespace BinarySearch.Tests
{
    public class Tests : ITests
    {
        private readonly ISearchEngine _searchEngine;

        public Tests()
        {
            _searchEngine = SearchEngineFactoryObject.GetSearchEngineObject();
        }
        private static bool Assert(bool statement)
        {
            if (statement == false)
                throw new ArgumentException("Assertion failed");

            return true;
        }
        
        public void TestSearchByBinarySearch()
        {
            Assert(_searchEngine.SearchByBinarySearch(new [] {1, 2, 3, 4, 5}, 5) == 4);
            Assert(_searchEngine.SearchByBinarySearch(new [] { 12, -12, 3, 0, 54, 65 }, 3) == 2);
            Assert(_searchEngine.SearchByBinarySearch(new [] { 1, 2, 3, 4, 5 }, 123) == -1);
        }
    }
}