namespace PersonProblem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PersonMain
    {
        public static void Main(string[] args)
        {
            Person notNullAgePerson = new Person("Pesho", 5);

            Person nullAgePerson = new Person("Gosho");

            Console.WriteLine(notNullAgePerson.ToString());
            Console.WriteLine(nullAgePerson.ToString());
        }
    }
}
