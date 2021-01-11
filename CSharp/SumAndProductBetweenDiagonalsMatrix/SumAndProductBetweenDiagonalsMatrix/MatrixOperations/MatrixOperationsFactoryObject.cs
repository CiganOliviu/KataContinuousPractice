namespace SumAndProductBetweenDiagonalsMatrix.MatrixOperations
{
    public class MatrixOperationsFactoryObject
    {
        public static IMatrixOperations GetMatrixOperations()
        {
            return new MatrixOperations();
        }
    }
}