using System;
using BinarySearch.Tests;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            ITests tests = TestsFactoryObject.GetTestsObject();
            
            tests.TestSearchByBinarySearch();
        }
    }
}