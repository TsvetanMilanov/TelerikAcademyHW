namespace SchoolSystem
{
    public class Discipline : ICommentable
    {
        public Discipline(string inputName, int inputNumberOfLectures, int inputnumberOfExercises)
        {
            this.Name = inputName;
            this.NumberOfLectures = inputNumberOfLectures;
            this.NumberOfExercises = inputnumberOfExercises;
        }

        public string Name { get; set; }

        public int NumberOfLectures { get; set; }

        public int NumberOfExercises { get; set; }

        public string Comment { get; set; }

        public override string ToString()
        {
            return string.Format("Discipline name: {0}\nNumber of lectures: {1}\nNumberOfExercises: {2}\nComment for this discipline: {3}\n", this.Name, this.NumberOfLectures, this.NumberOfExercises, this.Comment);
        }
    }
}
