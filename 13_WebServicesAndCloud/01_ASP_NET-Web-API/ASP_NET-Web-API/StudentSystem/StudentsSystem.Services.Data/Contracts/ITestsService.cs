namespace StudentsSystem.Services.Data.Contracts
{
    using System.Linq;
    using StudentSystem.Models;

    public interface ITestsService
    {
        IQueryable<Test> All();

        IQueryable<Test> GetById(int id);

        Test Add(Test test);

        Test Upadte(int id, Test test);

        void Delete(int id);
    }
}
