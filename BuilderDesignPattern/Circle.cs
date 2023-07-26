using System.Drawing;

namespace BuilderDesignPattern
{
    public class Circle : IShape
    {
        public Color Color { get; set; }
        public double Radius { get; set; }

        public string GetInfo()
            => $"Circle with color {Color.Name} and Radius {Radius}";
    }
}
