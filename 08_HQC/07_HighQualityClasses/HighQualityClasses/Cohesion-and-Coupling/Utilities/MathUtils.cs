namespace CohesionAndCoupling.Utilities
{
    using System;

    public static class MathUtils
    {
        public static double CalculateDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            return distance;
        }

        public static double CalculateDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt(
                ((x2 - x1) * (x2 - x1)) +
                ((y2 - y1) * (y2 - y1)) +
                ((z2 - z1) * (z2 - z1)));

            return distance;
        }

        public static double CalculateVolume(double width, double height, double depth)
        {
            double volume = width * height * depth;
            return volume;
        }

        public static double CalculateDiagonalXYZ(double width, double height, double depth)
        {
            double distance = CalculateDistance3D(0, 0, 0, width, height, depth);
            return distance;
        }

        public static double CalculateDiagonalXY(double width, double height)
        {
            double distance = CalculateDistance2D(0, 0, width, height);
            return distance;
        }

        public static double CalculateDiagonalXZ(double width, double depth)
        {
            double distance = CalculateDistance2D(0, 0, width, depth);
            return distance;
        }

        public static double CalculateDiagonalYZ(double height, double depth)
        {
            double distance = CalculateDistance2D(0, 0, height, depth);
            return distance;
        }
    }
}
