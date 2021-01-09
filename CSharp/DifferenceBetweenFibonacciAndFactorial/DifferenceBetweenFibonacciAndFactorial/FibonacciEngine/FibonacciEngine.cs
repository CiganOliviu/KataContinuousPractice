namespace DifferenceBetweenFibonacciAndFactorial.FibonacciEngine
{
    public class FibonacciEngine : IFibonacciEngine
    {
        public int GetFibonacciNumberRecursive(int indexOfNumber)
        {
            if (IsEqualWithOneOrTwo(indexOfNumber))
                return 1;

            return GetFibonacciNumberRecursive(indexOfNumber - 1) + GetFibonacciNumberRecursive(indexOfNumber - 2);
        }

        private static bool IsEqualWithOneOrTwo(int indexOfNumber)
        {
            return indexOfNumber == 1 || indexOfNumber == 2;
        }

        public int GetFibonacciNumber(int indexOfNumber)
        {
            var firstTerm = 0;
            var secondTerm = 1;

            if (indexOfNumber == 0) return 1;

            secondTerm = ProcessSwapOfElements(indexOfNumber, firstTerm, secondTerm);

            return secondTerm;
        }

        private static int ProcessSwapOfElements(int indexOfNumber, int firstTerm, int secondTerm)
        {
            for (int it = 2; it <= indexOfNumber; it++)
                firstTerm = SwapFibonacciElements(firstTerm, ref secondTerm);
            
            return secondTerm;
        }

        private static int SwapFibonacciElements(int firstTerm, ref int secondTerm)
        {
            var thirdTerm = firstTerm + secondTerm;
            firstTerm = secondTerm;
            secondTerm = thirdTerm;
            
            return firstTerm;
        }
    }
}