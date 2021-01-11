namespace SumAndProductBetweenDiagonalsMatrix.MatrixOperations
{
    public interface IMatrixOperations
    {
        int[] GetMainDiagonalOfMatrix(int[,] matrix, int length);
        int[] GetSecondaryDiagonalOfMatrix(int[, ] matrix, int length);
    }
}