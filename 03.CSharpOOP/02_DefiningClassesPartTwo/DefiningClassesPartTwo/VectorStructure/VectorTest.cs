namespace VectorStructure
{
    using System;
    using VectorStructure.Pathing;

    public class VectorTest
    {
        public static void Main()
        {
            /// Test the Point3D class.
            Point3D firstVector = new Point3D(1, 1, 1);
            Point3D secondVector = new Point3D(2, 2, 2);
            Point3D thirdVector = new Point3D(3, 3, 3);
            Point3D fourthVector = new Point3D(4, 4, 4);
            Point3D fifthVector = new Point3D(5, 5, 5);

            Console.WriteLine("Vector ToString(): {0}", firstVector.ToString());
            Console.WriteLine("THe coordinates of O: {0}", Point3D.GetO);
            Console.WriteLine("The distance between vector V1{0} and vector V2{1} is: {2}", firstVector.ToString(), secondVector.ToString(), Calculations.CalculateDistance(firstVector, secondVector));

            /// Test Path classes.
            Path testPath = new Path();
            testPath.AddPointToPath(firstVector);
            testPath.AddPointToPath(secondVector);
            testPath.AddPointToPath(thirdVector);
            Console.WriteLine("\nThe test path is:\n{0}", string.Join("\n", testPath.Points));

            string fileName = @"../../TestPathInput.txt";
            PathStorage.LoadPaths(fileName);

            /// Test paths.
            Console.WriteLine("\nAll the paths red from the file {0} are:", fileName);

            foreach (var path in PathStorage.Paths)
            {
                Console.WriteLine(string.Join("\n", path.Points));
                Console.WriteLine();
            }

            /// Write the paths to file.
            PathStorage.SavePaths(@"../../TestPathOutput.txt");
        }
    }
}
