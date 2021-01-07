namespace CountDivisorsOfTheSameParity.CountDivisorsEngine
{
    public class CountDivisorsFactoryObject
    {
        public static ICountDivisors GetCountDivisorsObject()
        {
            return new CountDivisorsObject();
        }
    }
}