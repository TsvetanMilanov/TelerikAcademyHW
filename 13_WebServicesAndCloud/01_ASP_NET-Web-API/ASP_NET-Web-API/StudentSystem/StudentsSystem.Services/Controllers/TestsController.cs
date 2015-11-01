namespace StudentsSystem.Services.Controllers
{
    using System.Web.Http;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Data.Contracts;
    using Models.Test;
    using StudentSystem.Models;

    public class TestsController : ApiController
    {
        private ITestsService testsService;

        public TestsController(ITestsService testsService)
        {
            this.testsService = testsService;
        }

        public IHttpActionResult Get()
        {
            return this.Ok(this.testsService.All().ProjectTo<TestResponseModel>());
        }

        public IHttpActionResult Get(int id)
        {
            return this.Ok(this.testsService.GetById(id).ProjectTo<TestResponseModel>());
        }

        public IHttpActionResult Post(TestRequestModel requestTest)
        {

            var test = Mapper.Map<Test>(requestTest);
            test = this.testsService.Add(test);

            return this.Created("/", test);
        }


        public IHttpActionResult Put(int id, TestRequestModel requestTest)
        {
            var test = Mapper.Map<Test>(requestTest);
            test = this.testsService.Upadte(id, test);

            return this.Ok(Mapper.Map<TestResponseModel>(test));
        }

        public IHttpActionResult Delete(int id)
        {
            this.testsService.Delete(id);

            return this.Ok();
        }
    }
}