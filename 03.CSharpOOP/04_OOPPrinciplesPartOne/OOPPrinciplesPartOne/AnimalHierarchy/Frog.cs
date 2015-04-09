namespace AnimalHierarchy
{
    public class Frog : Animal, ISound
    {
        public Frog(string inputName, int inputAge, string inputSex)
            : base(inputName, inputAge)
        {
            this.Sex = inputSex;
        }

        public string MakeSound()
        {
            return string.Format("{0} says QUAK.\n", this.Name);
        }
    }
}
