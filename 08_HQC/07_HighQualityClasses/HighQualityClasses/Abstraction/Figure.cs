namespace Abstraction
{
    using System;
    using System.Text;

    public abstract class Figure
    {
        public double Surface { get; protected set; }

        public double Perimeter { get; protected set; }

        public override string ToString()
        {
            string result = string.Format(
                "My perimeter is {0:f2}. My surface is {1:f2}.",
                this.Perimeter,
                this.Surface);

            return result;
        }

        protected abstract double CalculatePerimeter();

        protected abstract double CalculateSurface();
    }
}
