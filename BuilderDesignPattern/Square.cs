using System.Drawing;

namespace BuilderDesignPattern
{
    public class Square : IShape
    {
        public Color Color { get; set; }
        public double SideLength { get; set; }

        public string GetInfo()
            => $"Square with color {Color.Name} and SideLength {SideLength}";
    }
}
