namespace VectorStructure
{
    public struct Point3D
    {
        private static readonly Point3D O = new Point3D(0, 0, 0);

        private decimal x;
        private decimal y;
        private decimal z;

        public Point3D(decimal x, decimal y, decimal z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static string GetO
        {
            get
            {
                return string.Format("{{{0},{1},{2}}}", O.X, O.Y, O.Z);
            }
        }

        public decimal X
        {
            get
            {
                return this.x;
            }

            set
            {
                this.x = value;
            }
        }

        public decimal Y
        {
            get
            {
                return this.y;
            }

            set
            {
                this.y = value;
            }
        }

        public decimal Z
        {
            get
            {
                return this.z;
            }

            set
            {
                this.z = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{{{0},{1},{2}}}", this.X, this.Y, this.Z);
        }
    }
}
