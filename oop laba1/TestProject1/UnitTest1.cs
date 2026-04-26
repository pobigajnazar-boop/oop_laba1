using Xunit;

namespace TestProject1
{
    public class MatrixTests
    {
        [Fact]
        public void MultiplyMatrix_ShouldMultiplyEachElementByConstant()
        {
            char[,] inputMatrix = {
                { (char)2, (char)3 },
                { (char)4, (char)5 }
            };
            char constant = (char)3;
            char[,] expectedMatrix = {
                { (char)6, (char)9 },
                { (char)12, (char)15 }
            };

            char[,] actualMatrix = Lab1.MultiplyMatrix(inputMatrix, constant);

            Assert.Equal(expectedMatrix, actualMatrix);
        }

        [Fact]
        public void FindMinInColumns_ShouldReturnMinimumsForCorrectColumns()
        {
            char[,] matrix = {
                { (char)20, (char)40, (char)60 },
                { (char)30, (char)10, (char)50 },
                { (char)16, (char)24, (char)36 }
            };
            char[] expectedMins = { (char)16, (char)10, (char)36 };

            char[] actualMins = Lab1.FindMinInColumns(matrix);

            Assert.Equal(expectedMins, actualMins);
        }
    }
}