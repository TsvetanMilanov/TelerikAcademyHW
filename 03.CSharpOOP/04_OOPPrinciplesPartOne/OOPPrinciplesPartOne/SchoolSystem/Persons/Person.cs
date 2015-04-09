namespace SchoolSystem.Persons
{
    public class Person : ICommentable
    {
        public Person(string inputName)
        {
            this.Name = inputName;
        }

        public string Name { get; protected set; }

        public string Comment { get; set; }
    }
}
