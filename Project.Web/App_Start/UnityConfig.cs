using Microsoft.Practices.Unity;
using System.Web.Http;
using Project.DB.Configurations;
using Project.Logic.Mappers;
using Project.Logic.Services;
using Unity.WebApi;

namespace Project.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IProjectDbContext, ProjectDbContext>();
            container.RegisterType<IContextProvider, ContextProvider>();

            container.RegisterType<ITimeTableMapper, TimeTableMapper>();
            container.RegisterType<IRecordShortMapper, RecordShortMapper>();

            container.RegisterType<ITimeTableService, TimeTableService>();

            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}