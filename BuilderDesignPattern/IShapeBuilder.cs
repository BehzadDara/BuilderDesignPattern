using System.Drawing;

namespace BuilderDesignPattern
{
    public interface IShapeBuilder
    {
        void BuildColor(Color color);
        IShape GetShape();
    }
}
