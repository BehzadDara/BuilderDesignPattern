namespace BuilderDesignPattern
{
    public interface ISquareBuilder : IShapeBuilder
    {
        void BuildSideLength(double sideLength);
    }
}
