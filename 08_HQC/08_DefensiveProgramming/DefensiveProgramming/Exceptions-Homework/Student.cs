namespace Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        private const int MinNameLength = 2;
        private const int MaxNameLength = 30;
        private string firstName;
        private string lastName;
        private IList<Exam> exams;

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.exams = new List<Exam>();
        }

        public Student(string firstName, string lastName, IList<Exam> exams)
            : this(firstName, lastName)
        {
            this.Exams = exams;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                Validator.CheckIfStringIsValid(value, "First name");
                Validator.CheckIfStringLengthIsInRange(value, MinNameLength, MaxNameLength, "First name");

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                Validator.CheckIfStringIsValid(value, "Last name");
                Validator.CheckIfStringLengthIsInRange(value, MinNameLength, MaxNameLength, "Last name");

                this.lastName = value;
            }
        }

        public IList<Exam> Exams
        {
            get
            {
                return this.exams.ToList();
            }

            set
            {
                Validator.CheckIfNull(value, "Students exams list");

                this.exams = value;
            }
        }

        public IList<ExamResult> CheckExams()
        {
            Validator.CheckIfCollectionIsEmpty(this.Exams, "Students exams");

            IList<ExamResult> results = new List<ExamResult>();

            for (int i = 0; i < this.Exams.Count; i++)
            {
                results.Add(this.Exams[i].Check());
            }

            return results;
        }

        public double CalculateAverageExamResultInPercents()
        {
            if (this.Exams.Count == 0)
            {
                // No exams --> return -1;
                return -1;
            }

            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = this.CheckExams();

            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] =
                    ((double)examResults[i].Grade - examResults[i].MinGrade) /
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
    }
}