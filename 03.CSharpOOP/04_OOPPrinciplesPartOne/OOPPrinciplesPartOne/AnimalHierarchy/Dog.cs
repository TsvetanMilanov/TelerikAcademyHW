namespace AnimalHierarchy
{
    public class Dog : Animal, ISound
    {
        public Dog(string inputName, int inputAge, string inputSex)
            : base(inputName, inputAge)
        {
            this.Sex = inputSex;
        }

        public string MakeSound()
        {
            return string.Format("{0} says BAU.\n", this.Name);
        }
    }
}
