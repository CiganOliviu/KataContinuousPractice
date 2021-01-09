namespace DifferenceBetweenFibonacciAndFactorial.FactorialEngine
{
    public class FactorialEngineFactoryObject
    {
        public static IFactorialEngine GetFactorialEngineObject()
        {
            return new FactorialEngine();
        }
    }
}