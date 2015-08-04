namespace Methods
{
    using System;

    public class DistanceWithType
    {
        private double distance;

        public DistanceWithType(double distance, bool isHorizontal, bool isVertical)
        {
            this.Distance = distance;
            this.IsHorizontal = isHorizontal;
            this.IsVertical = isVertical;
        }

        public double Distance
        {
            get
            {
                return this.distance;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Distance can not be negative number!");
                }

                this.distance = value;
            }
        }

        public bool IsHorizontal { get; private set; }

        public bool IsVertical { get; private set; }
    }
}
