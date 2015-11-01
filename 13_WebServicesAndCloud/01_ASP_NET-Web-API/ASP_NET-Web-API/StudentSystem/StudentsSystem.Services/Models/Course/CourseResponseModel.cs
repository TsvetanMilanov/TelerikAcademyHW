namespace StudentsSystem.Services.Models.Course
{
    using System;

    public class CourseResponseModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}