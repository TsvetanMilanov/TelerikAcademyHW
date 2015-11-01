namespace StudentsSystem.Services.App_Start
{
    using AutoMapper;
    using Models.Course;
    using Models.Homewrok;
    using Models.Student;
    using Models.Test;
    using StudentSystem.Models;

    public static class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.CreateMap<Student, StudentResponseModel>();
            Mapper.CreateMap<StudentRequestModel, Student>();

            Mapper.CreateMap<Course, CourseResponseModel>();
            Mapper.CreateMap<CourseRequestModel, Course>();

            Mapper.CreateMap<Homework, HomeworkResponseModel>();
            Mapper.CreateMap<HomeworkRequestModel, Homework>();

            Mapper.CreateMap<Test, TestResponseModel>();
            Mapper.CreateMap<TestRequestModel, Test>();
        }
    }
}