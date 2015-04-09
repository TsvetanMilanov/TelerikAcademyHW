namespace AnimalHierarchy
{
    public class Cat : Animal, ISound
    {
        public Cat(string inputName, int inputAge, string inputSex)
            : base(inputName, inputAge)
        {
            this.Sex = inputSex;
        }

        public string MakeSound()
        {
            return string.Format("{0} says MEOW.\n", this.Name);
        }
    }
}
