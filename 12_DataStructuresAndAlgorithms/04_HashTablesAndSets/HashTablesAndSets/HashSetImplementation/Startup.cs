namespace HashSetImplementation
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var firstSet = new HashedSet<int>() { 1, 2, 3, 4, 5, 5, 5, 5, 3, 2, 2, 1, 2, 3 }; // 1, 2, 3, 4, 5
            firstSet.Add(7);
            firstSet.Add(7);
            firstSet.Add(7);
            firstSet.Add(7);
            firstSet.Add(7);

            var secondSet = new HashedSet<int>() { 2, 3, 4, 8 };

            Console.WriteLine("First set before removing 5:");
            PrintSet(firstSet);

            Console.WriteLine("\nFirst set after removing 5:");
            firstSet.Remove(5);
            PrintSet(firstSet);

            var union = HashedSet<int>.Union(firstSet, secondSet);
            Console.WriteLine("\nUnion {{{0}}} and {{{1}}}", string.Join(", ", firstSet), string.Join(", ", secondSet));
            PrintSet(union);

            var intersect = HashedSet<int>.Intersect(firstSet, secondSet);
            Console.WriteLine("\nIntersect {{{0}}} and {{{1}}}", string.Join(", ", firstSet), string.Join(", ", secondSet));
            PrintSet(intersect);
        }

        private static void PrintSet<T>(HashedSet<T> set) where T : IComparable<T>
        {
            Console.WriteLine(string.Join(", ", set));
        }
    }
}
