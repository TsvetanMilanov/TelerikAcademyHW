namespace Abstraction
{
    using System;

    public class Rectangle : Figure
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
            this.Surface = this.CalculateSurface();
            this.Perimeter = this.CalculatePerimeter();
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                Validator.CheckIfNumberIsPositive(value, "Rectangle width");

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                Validator.CheckIfNumberIsPositive(value, "Rectangle height");

                this.height = value;
            }
        }

        public override string ToString()
        {
            string result = "I am a rectangle. " + base.ToString();

            return result;
        }

        protected override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        protected override double CalculateSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
