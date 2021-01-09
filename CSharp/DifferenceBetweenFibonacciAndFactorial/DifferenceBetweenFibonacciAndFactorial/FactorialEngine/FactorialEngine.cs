namespace DifferenceBetweenFibonacciAndFactorial.FactorialEngine
{
    public class FactorialEngine : IFactorialEngine
    {
        public int GetFactorialNumberRecursive(int number)
        {
            if (IsEqualWithZeroOrOne(number)) 
                return 1;

            return number * GetFactorialNumberRecursive(number - 1);
        }

        private static bool IsEqualWithZeroOrOne(int number)
        {
            return number == 0 || number == 1;
        }

        public int GetFactorialNumber(int number)
        {
            int result = 1;

            for (int it = 1; it <= number; it++)
                result *= it;

            return result;
        }
    }
}