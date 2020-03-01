using Contacts.API.Models;
using Contacts.API.Repository;
using Contacts.API.Repository.Interface;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace Contacts.API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IRepository<Contact>, ContactRepository>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}