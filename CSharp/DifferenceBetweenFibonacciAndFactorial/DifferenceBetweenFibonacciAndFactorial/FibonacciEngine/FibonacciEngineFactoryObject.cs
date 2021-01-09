using DifferenceBetweenFibonacciAndFactorial.FactorialEngine;

namespace DifferenceBetweenFibonacciAndFactorial.FibonacciEngine
{
    public class FibonacciEngineFactoryObject
    {
        public static IFibonacciEngine GetFibonacciEngineObject()
        {
            return new FibonacciEngine();
        }
    }
}