namespace ProductOfPrimeNumbers.ProductOfPrimeNumbersEngine
{
    public class ProductOfPrimeNumbersFactoryObject
    {
        public static IProductOfPrimeNumbers GetProductOfPrimeNumbers()
        {
            return new ProductOfPrimeNumbers();
        }
    }
}