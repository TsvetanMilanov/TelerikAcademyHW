namespace AnimalHierarchy
{
    public class Tomcat : Cat
    {
        private const string TomcatSex = "Male";

        public Tomcat(string inputName, int inputAge)
            : base(inputName, inputAge, TomcatSex)
        {

        }
    }
}
