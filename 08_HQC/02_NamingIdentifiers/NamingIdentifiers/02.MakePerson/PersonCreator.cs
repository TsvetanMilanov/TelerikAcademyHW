namespace MakePerson
{
    using System;

    public class PersonCreator
    {
        public void CreatePerson(int age)
        {
            Person person = new Person();

            person.Age = age;

            if (age % 2 == 0)
            {
                person.Name = "Батката";
                person.Gender = Person.Genders.Male;
            }
            else
            {
                person.Name = "Мацето";
                person.Gender = Person.Genders.Female;
            }
        }
    }
}
