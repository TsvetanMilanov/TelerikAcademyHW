namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(int inputWidth, int inputHeight)
        {
            this.Width = inputWidth;
            this.Height = inputHeight;
        }

        public override decimal CalculateSurface()
        {
            return (decimal)this.Width * this.Height;
        }
    }
}
