namespace VectorStructure.Pathing
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> points;

        public Path()
        {
            this.points = new List<Point3D>();
        }

        public List<Point3D> Points
        {
            get
            {
                return this.points;
            }
        }

        public void AddPointToPath(Point3D point)
        {
            this.points.Add(point);
        }
    }
}
