namespace StudentsSystem.Services.Models.Student
{
    using StudentSystem.Models;

    public class StudentResponseModel
    {
        public int StudentIdentification { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Level { get; set; }

        public StudentInfo AdditionalInformation { get; set; }
    }
}