using CompuTrabajo.Test.Service;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace CompuTrabajo.Test.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IEmployeesService, EmployeesService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}