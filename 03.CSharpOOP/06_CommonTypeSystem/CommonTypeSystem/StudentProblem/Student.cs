namespace Students
{
    using System;

    using Students.Enumerations;

    public class Student : ICloneable, IComparable<Student>
    {
        private readonly string address;

        public Student(string studentAddres)
        {
            this.address = studentAddres;
        }

        public Student(
                        string studentFirstName,
                        string studentMiddleName,
                        string studentLastName,
                        uint studentSSN,
                        string studentAddress,
                        string studentPhoneNumber,
                        string studentEMail,
                        UniversityEnum studentUniversity,
                        FacultyEnum studentFaculty,
                        SpecialtyEnum studentSpecialty,
                        CourseEnum studentCourse)
        {
            this.FirstName = studentFirstName;
            this.MiddleName = studentMiddleName;
            this.LastName = studentLastName;
            this.SSN = studentSSN;
            this.address = studentAddress;
            this.PhoneNumber = studentPhoneNumber;
            this.EMail = studentEMail;
            this.University = studentUniversity;
            this.Faculty = studentFaculty;
            this.Specialty = studentSpecialty;
            this.Course = studentCourse;
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public uint SSN { get; set; }

        public string Address
        {
            get
            {
                return this.address;
            }
        }

        public string PhoneNumber { get; set; }

        public string EMail { get; set; }

        public UniversityEnum University { get; set; }

        public FacultyEnum Faculty { get; set; }

        public SpecialtyEnum Specialty { get; set; }

        public CourseEnum Course { get; set; }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            if (firstStudent.Equals(secondStudent))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            if (!firstStudent.Equals(secondStudent))
            {
                return true;
            }

            return false;
        }

        public override bool Equals(object obj)
        {
            Student secondStudent = obj as Student;

            if (this.SSN - secondStudent.SSN == 0)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format(
                "First name: {0}\nMiddle Name: {1}\nLast name: {2}\nSSN: {3}\nAddress: {4}\nPhonenumber: {5}\nE-Mail: {6}\nUniversity: {7}\nFaculty: {8}nSpecialty: {9}\nCourse: {10}\n", this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.PhoneNumber, this.EMail, this.University.ToString(), this.Faculty.ToString(), this.Specialty.ToString(), this.Course.ToString());
        }

        public object Clone()
        {
            Student resultStudent = new Student(this.address);

            resultStudent.FirstName = this.FirstName;
            resultStudent.MiddleName = this.MiddleName;
            resultStudent.LastName = this.LastName;
            resultStudent.SSN = this.SSN;
            resultStudent.PhoneNumber = this.PhoneNumber;
            resultStudent.EMail = this.EMail;
            resultStudent.University = this.University;
            resultStudent.Faculty = this.Faculty;
            resultStudent.Specialty = this.Specialty;
            resultStudent.Course = this.Course;

            return (object)resultStudent;
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName.CompareTo(other.FirstName) > 0)
            {
                return 1;
            }
            else if (this.FirstName.CompareTo(other.FirstName) < 0)
            {
                return -1;
            }
            else
            {
                if (this.SSN.CompareTo(other.SSN) > 0)
                {
                    return 1;
                }
                else if (this.SSN.CompareTo(other.SSN) < 0)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
