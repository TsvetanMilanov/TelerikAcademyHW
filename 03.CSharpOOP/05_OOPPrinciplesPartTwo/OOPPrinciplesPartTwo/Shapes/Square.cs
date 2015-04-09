namespace Shapes
{
    public class Square : Shape
    {
        public Square(int inputSquareSide)
        {
            this.Width = inputSquareSide;
            this.Height = inputSquareSide;
        }

        public override decimal CalculateSurface()
        {
            return (decimal)this.Width * this.Height;
        }
    }
}
