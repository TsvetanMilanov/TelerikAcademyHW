namespace StudentsSystem.Services.Data
{
    using System.Linq;

    using Contracts;
    using StudentSystem.Data.Repositories;
    using StudentSystem.Models;

    public class TestsService : ITestsService
    {
        private IGenericRepository<Test> tests;

        public TestsService(IGenericRepository<Test> tests)
        {
            this.tests = tests;
        }

        public Test Add(Test test)
        {
            this.tests.Add(test);
            this.tests.SaveChanges();

            return test;
        }

        public IQueryable<Test> All()
        {
            return this.tests.All();
        }

        public void Delete(int id)
        {
            var test = this.GetById(id).FirstOrDefault();

            this.tests.Delete(test);
            this.tests.SaveChanges();
        }

        public IQueryable<Test> GetById(int id)
        {
            return this.tests.SearchFor(t => t.Id == id);
        }

        public Test Upadte(int id, Test test)
        {
            var testToUpdate = this.GetById(id).FirstOrDefault();

            testToUpdate.CourseId = test.CourseId;
            this.tests.Update(testToUpdate);
            this.tests.SaveChanges();

            return testToUpdate;
        }
    }
}
