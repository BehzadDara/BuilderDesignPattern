using System.Drawing;

namespace BuilderDesignPattern
{
    public class SquareBuilder : ISquareBuilder
    {
        private readonly Square square = new();
        public void BuildColor(Color color)
        {
            square.Color = color;
        }

        public void BuildSideLength(double sideLength)
        {
            square.SideLength = sideLength;
        }

        public IShape GetShape()
        {
            return square;
        }
    }
}
