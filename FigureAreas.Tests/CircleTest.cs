using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FiguresClassLibrary;

namespace FigureAreas.Tests
{
    public class CircleTest
    {
        [Fact]
        public void Create_Circle_With_0_Radius_Exception()
        {
           
            // Assert
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }
        [Fact]
        public void Create_Circle_With_Negative_Radius_Exception()
        {
            
            // Assert
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }
        [Fact]
        public void Create_Circle_With_Positive_Radius_IsNotNull()
        {
            // Arrange
            Circle circle = new Circle(4);

           
            // Assert
            Assert.NotNull(circle);
        }
        [Fact]
        public void GetArea_IsPositive()
        {
            // Arrange
            Circle circle = new Circle(4);

            // Act
            double area = circle.GetArea();

            // Assert
            Assert.True(area>0);
        }
        [Fact]
        public void GetArea_about_12_56_With_Radius_2()
        {
            // Arrange
            Circle circle = new Circle(2);

            // Act
            double area = circle.GetArea();

            // Assert
            Assert.True((area > 12.5)&&(area<12.6));
        }

    }
}
