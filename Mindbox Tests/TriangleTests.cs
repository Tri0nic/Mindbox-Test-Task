using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mindbox_Library;

namespace Mindbox_Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TestArea()
        {
            //Assert
            double firstSide = 11.3;
            double secondSide = 20.1;
            double thirdSide = 38.9;
            double semiPerimeter = (firstSide + secondSide + thirdSide) / 2;
            double expectedArea = Math.Sqrt(semiPerimeter * (semiPerimeter - firstSide) * (semiPerimeter - secondSide) * (semiPerimeter - thirdSide));

            //Act
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            double actualArea = triangle.Area();

            //Assert
            Assert.AreEqual(expectedArea, actualArea);
        }
        [TestMethod]
        public void TestIsRightTriangle() 
        {
            // Arrange
            double firstSide = 3;
            double secondSide = 4;
            double thirdSide = 5;
            string expectedOutput = "Прямоугольный Треугольник с площадью: 6";

            // Act
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            string actualOutput;
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                triangle.Print(); 
                actualOutput = sw.ToString().Trim(); 
            }

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [TestMethod]
        public void TestIsNotRightTriangle()
        {
            // Arrange
            double firstSide = 5;
            double secondSide = 5;
            double thirdSide = 8;
            string expectedOutput = "Непрямоугольный Треугольник с площадью: 12";

            // Act
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            string actualOutput;
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                triangle.Print();
                actualOutput = sw.ToString().Trim();
            }

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}