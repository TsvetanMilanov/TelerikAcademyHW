namespace Abstraction
{
    using System;

    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
            this.Perimeter = this.CalculatePerimeter();
            this.Surface = this.CalculateSurface();
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                Validator.CheckIfNumberIsPositive(value, "Circle radius");

                this.radius = value;
            }
        }

        public override string ToString()
        {
            string result = "I am a circle. " + base.ToString();

            return result;
        }

        protected override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        protected override double CalculateSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
