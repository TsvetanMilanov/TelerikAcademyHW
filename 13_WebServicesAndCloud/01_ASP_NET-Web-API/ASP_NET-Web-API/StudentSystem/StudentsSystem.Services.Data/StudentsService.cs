namespace StudentsSystem.Services.Data
{
    using System.Linq;

    using Contracts;
    using StudentSystem.Data.Repositories;
    using StudentSystem.Models;

    public class StudentsService : IStudentsService
    {
        private IGenericRepository<Student> students;

        public StudentsService(IGenericRepository<Student> students)
        {
            this.students = students;
        }

        public Student Add(Student student)
        {
            this.students.Add(student);
            this.students.SaveChanges();

            return student;

        }

        public IQueryable<Student> All()
        {
            return this.students.All();
        }

        public void Delete(int id)
        {
            var student = this.students.SearchFor(s => s.StudentIdentification == id).FirstOrDefault();

            this.students.Delete(student);
            this.students.SaveChanges();
        }

        public IQueryable<Student> GetById(int id)
        {
            return this.students.SearchFor(s => s.StudentIdentification == id);
        }

        public Student Upadte(int id, Student student)
        {
            var studentToUpdate = this.students
                .All()
                .Where(s => s.StudentIdentification == id)
                .FirstOrDefault();

            studentToUpdate.FirstName = student.FirstName;
            studentToUpdate.LastName = student.LastName;
            studentToUpdate.Level = student.Level;

            this.students.Update(studentToUpdate);

            this.students.SaveChanges();

            return studentToUpdate;
        }
    }
}
