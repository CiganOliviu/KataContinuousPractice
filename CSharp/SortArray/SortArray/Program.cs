using System;
using SortArray.SortEngine;

namespace SortArray
{
    class Program
    {
        private static ISortEngine _sortEngine;

        private static void OutputArray(int[] Array)
        {
            foreach (var it in Array)
                Console.Write(it + " ");
        }
        
        static void Main(string[] args)
        {
            _sortEngine = SortEngineFactoryObject.GetSortEngineObject();

            int[] array = _sortEngine.BubbleSortArray(new int[] {-1, -2, -3, -4, -5});
            
            OutputArray(array);
        }
    }
}