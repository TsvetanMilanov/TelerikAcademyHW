namespace Shapes
{
    public abstract class Shape
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public abstract decimal CalculateSurface();
    }
}
