using System.Linq;
using GenerateBinaryMatrix.BinaryMatrixGenerator;
using NUnit.Framework;

namespace TestGeneratedBinaryMatrix
{
    public class Tests
    {
        private IMatrixGenerator _generator;
        
        [SetUp]
        public void Setup()
        {
            _generator = MatrixGeneratorFactoryObject.GetMatrixGeneratorObject();
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(_generator.GenerateBinaryMatrix(3).Cast<int>().SequenceEqual(new int[, ] { {1, 0, 1}, {0, 1, 0}, {1, 0, 1} }.Cast<int>()));
            Assert.IsTrue(_generator.GenerateBinaryMatrix(4).Cast<int>().SequenceEqual(new int[, ] { {1, 0, 1, 0}, {0, 1, 0, 1}, {1, 0, 1, 0}, {0, 1, 0, 1} }.Cast<int>()));
            Assert.IsTrue(_generator.GenerateBinaryMatrix(2).Cast<int>().SequenceEqual(new int[, ] { {1, 0}, {0, 1} }.Cast<int>()));
        }
    }
}