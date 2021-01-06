using System;

namespace GetMaxAndMinFromArray.GetLimitsEngine
{
    public class GetLimitsEngine : IGetLimitsEngine
    {
        public int GetMaxFromArray(int[] array)
        {
            int result = array[0];

            for (int it = 1; it < array.Length; it++)
                result = Math.Max(array[it], result);

            return result;
        }

        public int GetMinFromArray(int[] array)
        {
            int result = array[0];

            for (int it = 1; it < array.Length; it++)
                result = Math.Min(array[it], result);

            return result;
        }
    }
}