namespace SumAndProductBetweenDiagonalsMatrix.OperationsEngine
{
    public interface IOperationsEngine
    {
        int ProcessSum(int[, ] matrix, int length);
        int ProcessProduct(int[,] matrix, int length);
    }
}