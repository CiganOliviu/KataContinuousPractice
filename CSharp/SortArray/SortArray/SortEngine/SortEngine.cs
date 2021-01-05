using System;

namespace SortArray.SortEngine
{
    public class SortEngine : ISortEngine
    {
        public int[] BubbleSortArray(int[] array)
        {
            ValidateLength(array);

            int[] result = array;

            for (int it = 0; it < result.Length; it++)
                for (int jit = it + 1; jit < result.Length; jit++)
                    if (result[it] > result[jit])
                        SwapElementsInArray(result, it, jit);

            return result;
        }
        private static void SwapElementsInArray(int[] result, int it, int jit)
        {
            result[it] = result[it] + result[jit];
            result[jit] = result[it] - result[jit];
            result[it] = result[it] - result[jit];
        }

        private static void ValidateLength(int[] array)
        {
            if (array.Length <= 0)
                throw new ArgumentException();
        }
    }
}