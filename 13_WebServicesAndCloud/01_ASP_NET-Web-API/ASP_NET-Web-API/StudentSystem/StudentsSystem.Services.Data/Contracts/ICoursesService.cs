namespace StudentsSystem.Services.Data.Contracts
{
    using System;
    using System.Linq;

    using StudentSystem.Models;

    public interface ICoursesService
    {
        IQueryable<Course> All();

        IQueryable<Course> GetById(Guid id);

        Course Add(Course course);

        Course Upadte(Guid id, Course course);

        void Delete(Guid id);
    }
}
