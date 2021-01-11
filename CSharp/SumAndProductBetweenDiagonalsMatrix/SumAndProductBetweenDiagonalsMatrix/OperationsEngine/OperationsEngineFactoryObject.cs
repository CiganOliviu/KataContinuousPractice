namespace SumAndProductBetweenDiagonalsMatrix.OperationsEngine
{
    public class OperationsEngineFactoryObject
    {
        public static IOperationsEngine GetOperationsEngine()
        {
            return new OperationsEngine();
        }
    }
}