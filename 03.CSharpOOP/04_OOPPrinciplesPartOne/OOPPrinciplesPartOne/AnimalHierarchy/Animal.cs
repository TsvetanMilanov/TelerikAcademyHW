namespace AnimalHierarchy
{
    public abstract class Animal
    {
        public Animal(string inputName, int inputAge)
        {
            this.Name = inputName;
            this.Age = inputAge;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Sex { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}\nSex: {2}\n", this.Name, this.Age, this.Sex);
        }
    }
}
