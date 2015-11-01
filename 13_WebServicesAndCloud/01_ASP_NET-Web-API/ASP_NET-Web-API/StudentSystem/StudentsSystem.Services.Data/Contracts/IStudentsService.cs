namespace StudentsSystem.Services.Data.Contracts
{
    using System.Linq;

    using StudentSystem.Models;

    public interface IStudentsService
    {
        IQueryable<Student> All();

        IQueryable<Student> GetById(int id);

        Student Add(Student student);

        Student Upadte(int id, Student student);

        void Delete(int id);
    }
}
