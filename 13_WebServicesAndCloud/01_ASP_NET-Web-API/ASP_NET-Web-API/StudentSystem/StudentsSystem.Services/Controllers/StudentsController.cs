namespace StudentsSystem.Services.Controllers
{
    using System.Web.Http;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Data.Contracts;
    using Models.Student;
    using StudentSystem.Models;

    public class StudentsController : ApiController
    {
        private IStudentsService studentsService;

        public StudentsController(IStudentsService studentsService)
        {
            this.studentsService = studentsService;
        }

        public IHttpActionResult Get()
        {
            return this.Ok(this.studentsService.All().ProjectTo<StudentResponseModel>());
        }

        public IHttpActionResult Get(int id)
        {
            return this.Ok(this.studentsService.GetById(id).ProjectTo<StudentResponseModel>());
        }

        public IHttpActionResult Post(StudentRequestModel requestStudent)
        {
            var databaseStudent = Mapper.Map<Student>(requestStudent);

            databaseStudent = this.studentsService.Add(databaseStudent);

            return this.Created("/", databaseStudent.StudentIdentification);
        }

        public IHttpActionResult Put(int id, StudentRequestModel requestStudent)
        {
            var student = Mapper.Map<Student>(requestStudent);

            student = this.studentsService.Upadte(id, student);

            return this.Ok(Mapper.Map<StudentResponseModel>(student));
        }

        public IHttpActionResult Delete(int id)
        {
            this.studentsService.Delete(id);

            return this.Ok();
        }
    }
}