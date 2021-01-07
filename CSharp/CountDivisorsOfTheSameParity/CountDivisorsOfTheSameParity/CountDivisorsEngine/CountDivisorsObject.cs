namespace CountDivisorsOfTheSameParity.CountDivisorsEngine
{
    public class CountDivisorsObject : ICountDivisors
    {
        private bool IsOdd(int number)
        {
            return number % 2 == 1;
        }
        
        private bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        private bool IsOddDivisor(int number, int divisor)
        {
            return number % divisor == 0 && IsOdd(divisor);
        }

        private bool IsEvenDivisor(int number, int divisor)
        {
            return number % divisor == 0 && IsEven(divisor);
        }
        
        public int CountOddDivisors(int factor)
        {
            int counter = 0;
            
            for (int divisor = 1; divisor <= factor; divisor++)
                if (IsOddDivisor(factor, divisor))
                    counter += 1;

            return counter;
        }

        public int CountEvenDivisors(int factor)
        {
            int counter = 0;
            
            for (int divisor = 1; divisor <= factor; divisor++)
                if (IsEvenDivisor(factor, divisor))
                    counter += 1;

            return counter;
        }
    }
}