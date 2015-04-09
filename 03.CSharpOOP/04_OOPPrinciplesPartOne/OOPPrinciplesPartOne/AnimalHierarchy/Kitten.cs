namespace AnimalHierarchy
{
    public class Kitten : Cat
    {
        private const string KittenSex = "Female";

        public Kitten(string inputName, int inputAge)
            : base(inputName, inputAge, KittenSex)
        {

        }
    }
}
