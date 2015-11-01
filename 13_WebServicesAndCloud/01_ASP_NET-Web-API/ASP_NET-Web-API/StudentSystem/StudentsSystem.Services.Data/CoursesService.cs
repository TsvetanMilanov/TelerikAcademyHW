namespace StudentsSystem.Services.Data
{
    using System;
    using System.Linq;

    using Contracts;
    using StudentSystem.Models;
    using StudentSystem.Data.Repositories;

    public class CoursesService : ICoursesService
    {
        private IGenericRepository<Course> courses;

        public CoursesService(IGenericRepository<Course> courses)
        {
            this.courses = courses;
        }

        public Course Add(Course course)
        {
            this.courses.Add(course);
            this.courses.SaveChanges();

            return course;
        }

        public IQueryable<Course> All()
        {
            return this.courses.All();
        }

        public void Delete(Guid id)
        {
            var course = this.GetById(id).FirstOrDefault();

            this.courses.Delete(course);
            this.courses.SaveChanges();
        }

        public IQueryable<Course> GetById(Guid id)
        {
            return this.courses.SearchFor(c => c.Id == id);
        }

        public Course Upadte(Guid id, Course course)
        {
            var courseToUpdate = this.GetById(id).FirstOrDefault();

            courseToUpdate.Name = course.Name;
            courseToUpdate.Description = course.Description;

            this.courses.Update(courseToUpdate);
            this.courses.SaveChanges();

            return courseToUpdate;
        }
    }
}
