namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AnimalHierarchyMain
    {
        public static void Main(string[] args)
        {
            Animal[] arrayOfAnimals = new Animal[]
                {
                       new Dog("Pesho", 3, "Male"),
                       new Cat("Gosho", 4, "Male"),
                       new Tomcat("Haralampi", 5),
                       new Kitten("Goshka", 6),
                       new Dog("Gosho", 4, "Male"),
                       new Cat("Ivan", 8, "Male"),
                       new Tomcat("Genadi", 5),
                       new Kitten("Ivanka", 6),
                       new Dog("Lasi", 1, "Female"),
                       new Cat("Dragan", 7, "Male"),
                       new Tomcat("Grigor", 5),
                       new Kitten("Petka", 6),
                       new Dog("Peshka", 7, "Female"),
                       new Cat("Strahilka", 4, "Female"),
                       new Tomcat("Hristo", 5),
                       new Kitten("Genka", 6)
                };

            CalculateAverageAge(arrayOfAnimals);
        }

        public static void CalculateAverageAge(Animal[] inputArrayOfAnimals)
        {
            var groups = inputArrayOfAnimals.GroupBy(x => x.GetType());

            foreach (var group in groups)
            {
                var currentType = group.Key.ToString().Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);

                Console.WriteLine("{0}'s average age is: {1} years.", currentType[currentType.Length - 1], group.Average(x => x.Age));
            }
        }
    }
}
