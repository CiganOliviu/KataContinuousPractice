using System;

namespace MinimumSumSequence.MinimumSumEngine
{
    public class MinimumSumEngine : IMinimumSumEngine
    {
        public int GetMinimumSumSequence(int[] array)
        {
            int sum = 0;
            int result = 0;

            foreach (var it in array)
            {
                sum += it;

                result = Math.Max(result, sum);

                sum = Math.Max(sum, 0);
            }

            return result;
        }
    }
}