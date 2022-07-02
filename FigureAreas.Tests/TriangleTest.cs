using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FiguresClassLibrary;

namespace FigureAreas.Tests
{
    public class TriangleTest
    {
        [Fact]
        public void Create_Not_Existed_Triangle_Exception()
        {

            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(1,2,3));
        }
        [Fact]
        public void Create_Not_Existed_Triangle_With_Zero_Side1_Exception()
        {


            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(0, 5, 4));
        }
        [Fact]
        public void Create_Not_Existed_Triangle_With_Zero_Side2_Exception()
        {

            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(2, 0, 4));
        }
        [Fact]
        public void Create_Not_Existed_Triangle_With_Zero_Side3_Exception()
        {

            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(3, 5, 0));
        }
        [Fact]
        public void Create_Not_Existed_Triangle_With_Zero_Side1_Side2_Exception()
        {


            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(0, 0, 5));
        }
        [Fact]
        public void Create_Not_Existed_Triangle_With_Zero_Side1_Side3_Exception()
        {

            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(0, 5, 0));
        }
        [Fact]
        public void Create_Not_Existed_Triangle_With_Zero_Side2_Side3_Exception()
        {

            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(5, 0, 0));
        }
        [Fact]
        public void Create_Not_Existed_Triangle_With_Zero_Side1_Side2_Side3_Exception()
        {

            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(0, 0, 0));
        }
        [Fact]
        public void Create_Not_Existed_Triangle_With_Negative_Side1_Exception()
        {

            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(-5, 3, 4));
        }
        [Fact]
        public void Create_Not_Existed_Triangle_With_Negative_Side2_Exception()
        {

            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(3, -4, 5));
        }
        [Fact]
        public void Create_Not_Existed_Triangle_With_Negative_Side3_Exception()
        {

            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(3, 4, -5));
        }
        [Fact]
        public void Create_Not_Existed_Triangle_With_Negative_Side1_Side2_Exception()
        {

            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(-3, -4, 5));
        }
        [Fact]
        public void Create_Not_Existed_Triangle_With_Negative_Side1_Side3_Exception()
        {

            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(-3, 4, -5));
        }
        [Fact]
        public void Create_Not_Existed_Triangle_With_Negative_Side2_Side3_Exception()
        {

            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(3, -4, -5));
        }
        [Fact]
        public void Create_Not_Existed_Triangle_With_Negative_Side1_Side2_Side3_Exception()
        {

            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(-3, -4, -5));
        }
        [Fact]
        public void Create_Existed_Triangle_With_Positive_Sides_IsNotNull()
        {
            // Arrange
            Triangle triangle = new Triangle(5,6,7);
            
            // Assert
            Assert.NotNull(triangle);
        }
        [Fact]
        public void GetArea_IsPositive()
        {
            // Arrange
            Triangle triangle = new Triangle(5, 6, 7);
            // Act
            double area = triangle.GetArea();
            // Assert
            Assert.True(area > 0);
        }
        [Fact]
        public void GetArea_6_With_Side1_3_Side2_4_Side3_5()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);
            // Act
            double area = triangle.GetArea();
            // Assert
            Assert.True(area == 6);
        }
        [Fact]
        public void RectangularCheck_Side1_3_Side2_4_Side3_5()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);
            // Act
            bool triangleIsRectangular = triangle.IsRectangular;
            // Assert
            Assert.True(triangleIsRectangular);
        }
        [Fact]
        public void RectangularCheck_Side1_5_Side2_6_Side3_7()
        {
            // Arrange
            Triangle triangle = new Triangle(5, 6, 7);
            // Act
            bool triangleIsRectangular = triangle.IsRectangular;
            // Assert
            Assert.False(triangleIsRectangular);
        }
    }
}
