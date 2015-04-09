namespace VectorStructure
{
    using System;

    public static class Calculations
    {
        public static decimal CalculateDistance(Point3D firstVector, Point3D secondVector)
        {
            decimal result = 0;

            result = (decimal)Math.Sqrt((double)(((secondVector.X - firstVector.X) * (secondVector.X - firstVector.X)) + ((secondVector.Y - firstVector.Y) * (secondVector.Y - firstVector.Y)) + ((secondVector.Z - firstVector.Z) * (secondVector.Z - firstVector.Z))));

            return result;
        }
    }
}
