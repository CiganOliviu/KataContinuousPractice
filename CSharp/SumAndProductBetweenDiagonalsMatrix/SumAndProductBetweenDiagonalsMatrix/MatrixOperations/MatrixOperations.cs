namespace SumAndProductBetweenDiagonalsMatrix.MatrixOperations
{
    public class MatrixOperations : IMatrixOperations
    {
        public int[] GetMainDiagonalOfMatrix(int[,] matrix, int length)
        {
            int[] result = new int[length];

            for (int it = 0; it < length; it++)
                result[it] = matrix[it, it];

            return result;
        }

        public int[] GetSecondaryDiagonalOfMatrix(int[,] matrix, int length)
        {
            int[] result = new int[length];
            int index = 0;
            
            for (int it = 0; it < length; it++)
                for (int jit = 0; jit < length; jit++)
                if (it + jit == length - 1)
                {
                    result[index] = matrix[it, jit];
                    index += 1;
                }

            return result;
        }
    }
}