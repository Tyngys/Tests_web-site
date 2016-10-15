using System.Data.Entity;
using CP.Business;
using CP.Business.Abstract;
using CP.Data;
using Microsoft.Practices.Unity;

namespace CP.DependencyResolver
{
    public class DependencyResolverConfiguration
    {
        public DependencyResolverConfiguration()
        {
            this.Container = new UnityContainer();
            this.RegisterTypes();
        }

        public IUnityContainer Container { get; private set; }

        protected virtual void RegisterTypes()
        {
            this.Container.RegisterType(typeof(IRepository<>), typeof(EfRepository<>));
            this.Container.RegisterType<DbContext, TestDb>();
            this.Container.RegisterType<IRoleService, RoleService>();
            this.Container.RegisterType<IUserService, UserService>();
            this.Container.RegisterType<ITestService, TestService>();
        }
    }
}
