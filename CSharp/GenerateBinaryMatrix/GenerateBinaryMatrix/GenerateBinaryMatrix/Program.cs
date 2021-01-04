using System;
using GenerateBinaryMatrix.BinaryMatrixGenerator;

namespace GenerateBinaryMatrix
{
    class Program
    {
        private static void OutputMatrix(int[,] matrix, int length)
        {
            for (int it = 0; it < length; it++) {
                for (int jit = 0; jit < length; jit++)
                    Console.Write(matrix[it, jit]);
                
                Console.WriteLine();
            }
        } 
        
        static void Main(string[] args)
        {
            IMatrixGenerator generator = MatrixGeneratorFactoryObject.GetMatrixGeneratorObject();

            int length = 3;
            int[,] binaryMatrix = generator.GenerateBinaryMatrix(length);

            OutputMatrix(binaryMatrix, length);
        }
    }
}