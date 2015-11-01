namespace StudentsSystem.Services.Controllers
{
    using System;
    using System.Web.Http;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Data.Contracts;
    using Models.Course;
    using StudentSystem.Models;

    public class CoursesController : ApiController
    {
        private ICoursesService coursesService;

        public CoursesController(ICoursesService coursesService)
        {
            this.coursesService = coursesService;
        }

        public IHttpActionResult Get()
        {
            return this.Ok(this.coursesService.All().ProjectTo<CourseResponseModel>());
        }

        public IHttpActionResult Get(Guid id)
        {
            return this.Ok(this.coursesService.GetById(id).ProjectTo<CourseResponseModel>());
        }

        public IHttpActionResult Post(CourseRequestModel requestCourse)
        {
            var course = Mapper.Map<Course>(requestCourse);

            course = this.coursesService.Add(course);

            return this.Created("/", Mapper.Map<CourseResponseModel>(course));
        }

        public IHttpActionResult Put(Guid id, CourseRequestModel requestCourse)
        {
            var course = Mapper.Map<Course>(requestCourse);

            course = this.coursesService.Upadte(id, course);

            return this.Ok(Mapper.Map<CourseResponseModel>(course));
        }

        public IHttpActionResult Delete(Guid id)
        {
            this.coursesService.Delete(id);

            return this.Ok();
        }
    }
}