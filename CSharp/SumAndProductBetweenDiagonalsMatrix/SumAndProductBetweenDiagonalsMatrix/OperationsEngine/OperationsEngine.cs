using System;
using SumAndProductBetweenDiagonalsMatrix.MatrixOperations;

namespace SumAndProductBetweenDiagonalsMatrix.OperationsEngine
{
    public class OperationsEngine : IOperationsEngine
    {
        private IMatrixOperations _matrixOperations = MatrixOperationsFactoryObject.GetMatrixOperations();
        
        private int GetSumOfArray(int[] array)
        {
            int sum = 0;

            foreach (var item in array)
                sum += item;

            return sum;
        }
        
        public int ProcessSum(int[,] matrix, int length)
        {
            int[] mainDiagonal = _matrixOperations.GetMainDiagonalOfMatrix(matrix, length);
            int[] secondaryDiagonal = _matrixOperations.GetSecondaryDiagonalOfMatrix(matrix, length);

            return GetSumOfArray(mainDiagonal) + GetSumOfArray(secondaryDiagonal);
        }

        private int GetProductOfArray(int[] array)
        {
            int product = 1;

            foreach (var item in array)
                product *= item;

            return product;
        }
        
        public int ProcessProduct(int[,] matrix, int length)
        {
            int[] mainDiagonal = _matrixOperations.GetMainDiagonalOfMatrix(matrix, length);
            int[] secondaryDiagonal = _matrixOperations.GetSecondaryDiagonalOfMatrix(matrix, length);

            return GetProductOfArray(mainDiagonal) * GetProductOfArray(secondaryDiagonal);
        }
    }
}