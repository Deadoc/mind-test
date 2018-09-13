using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SquareCalculator.Figures.Primitives;

namespace SquareCalculator.Tests
{
    [TestFixture]
    public class SqrCalculatorTests
    {
        /// <summary>
        /// Тестируем вычисление площади круга
        /// </summary>
        [Test]
        public void CircleSqrCalculationTest()
        {
            //Arrange
            var circle = new Circle(10);

            //Act
            var circleSquare = circle.Square;
            
            //Assert
            Assert.AreEqual(314.15926535897931, circleSquare);
        }

        /// <summary>
        /// Тестируем вычисление площади тиугольника
        /// </summary>
        [Test]
        public void TriangleSqrCalculationTest()
        {
            //Arrange
            var triangle = new Triangle(3,4,5);

            //Act
            var triangleSquare = triangle.Square;

            //Assert
            Assert.AreEqual(6, triangleSquare);
        }

        /// <summary>
        /// Тестируем прямоугольный треугольник
        /// </summary>
        [Test]
        public void RightAngleTriangleTest()
        {
            //Arrange
            var triangle = new Triangle(3,4,5);

            //Act
            var isTriangleRightAngled = triangle.IsRightAngled;

            //Assert
            Assert.AreEqual(true, isTriangleRightAngled);
        }

        /// <summary>
        /// Тестируем не прямоугольный треугольник
        /// </summary>
        [Test]
        public void NotRightAngleTriangleTest()
        {
            //Arrange
            var triangle = new Triangle(6,2,5);

            //Act
            var isTriangleRightAngled = triangle.IsRightAngled;

            //Assert
            Assert.AreEqual(false, isTriangleRightAngled);
        }
    }
}
