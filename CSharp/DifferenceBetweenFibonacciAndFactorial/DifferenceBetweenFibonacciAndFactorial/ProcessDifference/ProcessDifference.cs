using DifferenceBetweenFibonacciAndFactorial.FactorialEngine;
using DifferenceBetweenFibonacciAndFactorial.FibonacciEngine;

namespace DifferenceBetweenFibonacciAndFactorial.ProcessDifference
{
    public class ProcessDifference
    {
        private readonly IFibonacciEngine _fibonacciEngine;
        private readonly IFactorialEngine _factorialEngine;
        
        public ProcessDifference()
        {
            _fibonacciEngine = FibonacciEngineFactoryObject.GetFibonacciEngineObject();
            _factorialEngine = FactorialEngineFactoryObject.GetFactorialEngineObject();
        }   
        
        public int RealiseSubtractionBetweenFibonacciAndFactorial(int factor)
        {
            return _fibonacciEngine.GetFibonacciNumberRecursive(factor) - _factorialEngine.GetFactorialNumberRecursive(factor);
        }
    }
}