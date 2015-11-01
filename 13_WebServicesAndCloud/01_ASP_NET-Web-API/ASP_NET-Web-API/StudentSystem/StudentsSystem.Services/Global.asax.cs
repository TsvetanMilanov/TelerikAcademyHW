namespace StudentsSystem.Services
{
    using System.Web;
    using System.Web.Http;

    using App_Start;

    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AutoMapperConfig.Initialize();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
