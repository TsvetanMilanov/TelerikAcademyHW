namespace VectorStructure.Pathing
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public static class PathStorage
    {
        private static List<Path> paths = new List<Path>();

        public static List<Path> Paths
        {
            get
            {
                return paths;
            }
        }

        public static void LoadPaths(string fileName)
        {
            List<string[]> allPoints = new List<string[]>();

            using (var reader = new StreamReader(fileName))
            {
                string currentLine = string.Empty;

                while ((currentLine = reader.ReadLine()) != null)
                {
                    allPoints.Add(currentLine.Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries));
                }

                allPoints.TrimExcess();

                Path currentPath = new Path();

                foreach (var point in allPoints)
                {
                    if (point.Length == 0)
                    {
                        paths.Add(currentPath);

                        currentPath = new Path();
                    }
                    else
                    {
                        Point3D currentPoint = new Point3D();

                        decimal[] pathCoordinates = point[0].Split(',').Select(decimal.Parse).ToArray();

                        currentPoint.X = pathCoordinates[0];
                        currentPoint.Y = pathCoordinates[1];
                        currentPoint.Z = pathCoordinates[2];

                        currentPath.AddPointToPath(currentPoint);
                    }
                }

                paths.Add(currentPath);
            }
        }

        public static void SavePaths(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                StringBuilder result = new StringBuilder();

                foreach (var path in paths)
                {
                    foreach (var point in path.Points)
                    {
                        result.AppendFormat("{{{0},{1},{2}}}\n", point.X, point.Y, point.Z);
                    }

                    result.Append("\n");
                }

                writer.WriteLine(result.ToString().TrimEnd());

                Console.WriteLine("Successfully wrote the information in {0}.", fileName);
            }
        }
    }
}
