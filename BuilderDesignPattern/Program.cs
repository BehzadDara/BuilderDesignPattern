using BuilderDesignPattern;
using System.Drawing;

var squareBuilder = new SquareBuilder();
squareBuilder.BuildSideLength(10);
squareBuilder.BuildColor(Color.Red);
Console.WriteLine(squareBuilder.GetShape().GetInfo());

var circleBuilder = new CircleBuilder();
circleBuilder.BuildRadius(5);
circleBuilder.BuildColor(Color.Blue);
Console.WriteLine(circleBuilder.GetShape().GetInfo());