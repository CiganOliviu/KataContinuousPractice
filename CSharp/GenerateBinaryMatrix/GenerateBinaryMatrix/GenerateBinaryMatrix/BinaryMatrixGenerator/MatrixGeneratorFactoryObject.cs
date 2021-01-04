namespace GenerateBinaryMatrix.BinaryMatrixGenerator
{
    public class MatrixGeneratorFactoryObject
    {
        public static IMatrixGenerator GetMatrixGeneratorObject()
        {
            return new MatrixGenerator();
        }
    }
}