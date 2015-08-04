namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private const int MinStudentNumber = 10000;
        private const int MaxStudentNumber = 99999;

        private static IList<int> listOfAllStudentNumbers = new List<int>();
        private string name;
        private int number;

        public Student(string name, int number)
        {
            this.Name = name;
            this.Number = number;
            listOfAllStudentNumbers.Add(number);
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Students name should not be null or empty!");
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Students name must not be white space!");
                }

                this.name = value;
            }
        }

        public int Number
        {
            get
            {
                return this.number;
            }

            set
            {
                if (value < MinStudentNumber || value > MaxStudentNumber)
                {
                    string errorMessage = string.Format(
                        "Students number must be between {0} and {1}!", MinStudentNumber, MaxStudentNumber);
                    throw new ArgumentOutOfRangeException(errorMessage);
                }

                if (listOfAllStudentNumbers.Contains(value))
                {
                    throw new ArgumentException("The student number must be unique number!");
                }

                this.number = value;
            }
        }
    }
}
