namespace BinarySearch.Tests
{
    public class TestsFactoryObject
    {
        public static ITests GetTestsObject()
        {
            return new Tests();
        }
    }
}