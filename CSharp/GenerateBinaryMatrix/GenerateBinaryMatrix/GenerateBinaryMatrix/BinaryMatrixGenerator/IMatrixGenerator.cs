namespace GenerateBinaryMatrix.BinaryMatrixGenerator
{
    public interface IMatrixGenerator
    {
        int[,] GenerateBinaryMatrix(int length);
    }
}