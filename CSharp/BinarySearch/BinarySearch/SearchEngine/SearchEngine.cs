namespace BinarySearch.SearchEngine
{
    public class SearchEngine : ISearchEngine
    {
        private static int GetMiddleValue(int left, int right)
        {
            return left + (right - left) / 2;
        }
        
        private bool IsValueFound(int[] oneDimensionalArray, int valueToSearch, int middle)
        {
            return oneDimensionalArray[middle] == valueToSearch;
        }

        private bool IsValueBigger(int[] oneDimensionalArray, int index, int valueToSearch)
        {
            return oneDimensionalArray[index] < valueToSearch;
        }
        
        private bool IsValueSmaller(int[] oneDimensionalArray, int index, int valueToSearch)
        {
            return oneDimensionalArray[index] > valueToSearch;
        }
        
        private int GetSpecificLimit(int limit, int middle, bool condition)
        {
            if (condition)
                limit = middle + 1;
            return limit;
        }
        public int SearchByBinarySearch(int[] oneDimensionalArray, int valueToSearch)
        {
            int left = 0;
            int right = oneDimensionalArray.Length - 1;

            while (left <= right)
            {
                int middle = GetMiddleValue(left, right);

                if (IsValueFound(oneDimensionalArray, valueToSearch, middle))
                    return middle;

                left = GetSpecificLimit(left, middle, IsValueBigger(oneDimensionalArray, middle, valueToSearch));

                right = GetSpecificLimit(right, middle, IsValueSmaller(oneDimensionalArray, middle, valueToSearch));
            }

            return -1;
        }
    }
}