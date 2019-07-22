using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ConsoleApp1;
namespace XunitTesting
{
    public class ShapeAreaTest
    {

        [Fact]
        public void CircleAreaPassingTest()
        {
            Circle circle = new Circle(3);
            Assert.True(Math.Round(circle.FindArea(),2).Equals(28.26));
        }

        [Fact]
        public void CircleAreaFailingTest()
        {
            Circle circle = new Circle(3);
            Assert.False(Math.Round(circle.FindArea(), 2).Equals(25.26));

        }

       
        [Fact]
        public void SquareAreaPassingTest()
        {
            Square square = new Square(2);
            Assert.True(Math.Round(square.FindArea(), 1).Equals(4.0));
        }
        [Fact]
        public void SquareAreaFailingTest()
        {
            Square square = new Square(2);
            Assert.False(Math.Round(square.FindArea(), 1).Equals(5.0));

        }

        [Fact]

        public void TriangleAreaPassingTest()
        {
            Triangle triangle = new Triangle(4, 4);
            Assert.True(Math.Round(triangle.FindArea(), 1).Equals(8.0));
        }

        [Fact]

        public void TriangleAreaFailingTest()
        {
            Triangle triangle = new Triangle(4, 4);
            Assert.False(Math.Round(triangle.FindArea(), 1).Equals(9.0));


        }
    }
}
