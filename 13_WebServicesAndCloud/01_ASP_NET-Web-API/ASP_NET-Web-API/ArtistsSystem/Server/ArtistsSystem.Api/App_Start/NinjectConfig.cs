[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ArtistsSystem.Api.App_Start.NinjectConfig), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(ArtistsSystem.Api.App_Start.NinjectConfig), "Stop")]

namespace ArtistsSystem.Api.App_Start
{
    using System;
    using System.Web;

    using Data;
    using Data.Repositories;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Extensions.Conventions;
    using Ninject.Web.Common;

    public static class NinjectConfig
    {
        private const string ServicesAssemblyName = "ArtistsSystem.Services.Data";

        private static readonly Bootstrapper Bootstrapper = new Bootstrapper();

        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            Bootstrapper.Initialize(CreateKernel);
        }

        public static void Stop()
        {
            Bootstrapper.ShutDown();
        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IArtistsSystemDbContext>().To<ArtistsSystemDbContext>().InRequestScope();

            kernel.Bind(typeof(IGenericRepository<>)).To(typeof(GenericRepository<>));

            kernel.Bind(
                b => b.From(ServicesAssemblyName)
                .SelectAllClasses()
                .BindDefaultInterface());
        }
    }
}
