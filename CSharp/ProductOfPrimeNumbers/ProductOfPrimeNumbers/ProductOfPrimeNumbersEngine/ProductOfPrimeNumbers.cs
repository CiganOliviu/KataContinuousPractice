using System;

namespace ProductOfPrimeNumbers.ProductOfPrimeNumbersEngine
{
    public class ProductOfPrimeNumbers : IProductOfPrimeNumbers
    {
        private bool IsPrime(int number)
        {
            if (number == 2) return true;

            for (int divisor = 2; divisor <= number / 2; divisor++)
                if (number % divisor == 0)
                    return false;

            return true;
        }
        public int GetProductOfPrimeNumbers(int number)
        {
            int product = 1;
            
            for (int it = 2; it <= number; it++)
                if (IsPrime(it))
                    product *= it;

            return product;
        }
    }
}