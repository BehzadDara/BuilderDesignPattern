namespace BuilderDesignPattern
{
    public interface ICircleBuilder : IShapeBuilder
    {
        void BuildRadius(double radius);
    }
}
