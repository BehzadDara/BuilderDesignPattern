using System.Drawing;

namespace BuilderDesignPattern
{
    public interface IShape
    {
        Color Color { get; set; }
        public string GetInfo();
    }
}
