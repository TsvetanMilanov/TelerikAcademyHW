namespace MakePerson
{
    public class Person
    {
        public enum Genders
        {
            Male,
            Female
        }

        public Genders Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
