namespace MinimumSumSequence.MinimumSumEngine
{
    public class MinimumSumEngineFactoryObject
    {
        public static IMinimumSumEngine GetMinimumSumEngineObject()
        {
            return new MinimumSumEngine();
        }
    }
}