namespace NorthwindTwin
{
    using System;

    using NorthwindDbContext;

    public class EntryPint
    {
        public static void Main()
        {
            var context = new NorthwindEntities();
            context.Database.CreateIfNotExists();
            Console.WriteLine("Database NorthwindTwin created!");
        }
    }
}
