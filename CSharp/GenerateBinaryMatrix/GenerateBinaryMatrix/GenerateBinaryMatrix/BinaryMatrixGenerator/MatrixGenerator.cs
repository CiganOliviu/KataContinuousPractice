using System;

namespace GenerateBinaryMatrix.BinaryMatrixGenerator
{
    public class MatrixGenerator : IMatrixGenerator
    {
        private bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public int[,] GenerateBinaryMatrix(int length)
        {
            int[, ] result = new int[length, length];

            for (int it = 0; it < length; it++)
                for (int jit = 0; jit < length; jit++)
                    result[it, jit] = IsEven(it + jit) ? 1 : 0;

            return result;
        }
    }
}