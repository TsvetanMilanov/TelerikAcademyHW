namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(int inputWidth, int inputHeight)
        {
            this.Width = inputWidth;
            this.Height = inputHeight;
        }

        public override decimal CalculateSurface()
        {
            return ((decimal)this.Width * this.Height) / 2;
        }
    }
}
