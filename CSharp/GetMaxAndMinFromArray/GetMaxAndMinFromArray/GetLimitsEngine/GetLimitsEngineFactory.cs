namespace GetMaxAndMinFromArray.GetLimitsEngine
{
    public class GetLimitsEngineFactory
    {
        public static IGetLimitsEngine GetLimitsEngineObject()
        {
            return new GetLimitsEngine();
        }
    }
}