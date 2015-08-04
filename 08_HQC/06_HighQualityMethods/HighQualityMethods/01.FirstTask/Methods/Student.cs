namespace Methods
{
    using System;
    using System.Globalization;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string otherInfo;

        public Student(string firstName, string lastName, string otherInfo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.OtherInfo = otherInfo;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.ValidateStringLength(value, 2, 15, "Student's first name");

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
                this.ValidateStringLength(value, 2, 15, "Student's last name");

                this.lastName = value;
            }
        }

        public string OtherInfo
        {
            get
            {
                return this.otherInfo;
            }

            set
            {
                this.ValidateStringLength(value, 5, 60, "Student's other information");

                this.otherInfo = value;
            }
        }

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate = this.ParseDateOfBirth(this);
            DateTime secondDate = this.ParseDateOfBirth(other);

            bool isOlder = false;

            if (DateTime.Compare(firstDate, secondDate) < 0)
            {
                isOlder = true;
            }
            else
            {
                isOlder = false;
            }

            return isOlder;
        }

        private void ValidateStringLength(string value, int minLength, int maxLength, string valueName)
        {
            string errorMessage = string.Format("{0} must be between {1} and {2} symbols long!", valueName, minLength, maxLength);

            if (value.Length < minLength || maxLength < value.Length)
            {
                throw new ArgumentOutOfRangeException(errorMessage);
            }
        }

        private DateTime ParseDateOfBirth(Student student)
        {
            string[] otherInfoStringSplit = new string[] { "born at " };
            string studentBirthDate = student.OtherInfo
                                    .Split(otherInfoStringSplit, StringSplitOptions.RemoveEmptyEntries)[1];

            string dateFormat = "dd.mm.yyyy";
            CultureInfo provider = new CultureInfo("bg-BG");
            DateTime parsedDate = DateTime.ParseExact(studentBirthDate, dateFormat, provider);

            return parsedDate;
        }
    }
}
