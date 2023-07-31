using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mindbox_Library;

namespace Mindbox_Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void TestArea()
        {
            //Assert
            double radius = 5.5;
            double expectedArea = Math.PI * Math.Pow(radius, 2);

            //Act
            Circle circle = new Circle(radius);
            double actualArea = circle.Area();

            //Assert
            Assert.AreEqual(expectedArea, actualArea);
        }
        [TestMethod]
        public void TestPrint()
        {
            // Arrange
            double radius = 12.4;
            double expectedArea = Math.PI * Math.Pow(radius, 2);
            string expectedOutput = $"Круг с площадью: {expectedArea}";

            // Act
            Circle circle = new Circle(radius);
            string actualOutput;
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                circle.Print();
                actualOutput = sw.ToString().Trim();
            }

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}