using System.Drawing;

namespace BuilderDesignPattern
{
    public class CircleBuilder : ICircleBuilder
    {
        private readonly Circle circle = new();
        public void BuildColor(Color color)
        {
            circle.Color = color;
        }

        public void BuildRadius(double radius)
        {
            circle.Radius = radius;
        }

        public IShape GetShape()
        {
            return circle;
        }
    }
}
