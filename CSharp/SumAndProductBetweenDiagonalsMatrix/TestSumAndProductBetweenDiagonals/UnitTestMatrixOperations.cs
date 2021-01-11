using System;
using System.Linq;
using NUnit.Framework;
using SumAndProductBetweenDiagonalsMatrix.MatrixOperations;

namespace TestSumAndProductBetweenDiagonals
{
    class UnitTestMatrixOperations
    {
        private IMatrixOperations _matrixOperations;
        
        [SetUp]
        public void Setup()
        {
            _matrixOperations = MatrixOperationsFactoryObject.GetMatrixOperations();
        }
        
        [Test]
        public void Test_GetMainDiagonalOfMatrix_()
        {
            Assert.IsTrue(_matrixOperations.GetMainDiagonalOfMatrix(new int[, ] { {1, 2, 3}, {4, 5, 6}, {7, 8, 9}}, 3).SequenceEqual(new int[] {1, 5, 9}));
        }

        [Test]
        public void Test_GetSecondaryDiagonalOfMatrix_()
        {
            Assert.IsTrue(_matrixOperations.GetSecondaryDiagonalOfMatrix(new int[, ] { {1, 2, 3}, {4, 5, 6}, {7, 8, 9}}, 3).SequenceEqual(new int[] {3, 5, 7}));
        }
    }
}