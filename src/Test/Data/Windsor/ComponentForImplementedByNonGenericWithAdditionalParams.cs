using AgentMulder.ReSharper.Tests.Data;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace TestApplication.Windsor
{
    public class ComponentForImplementedByNonGenericWithAdditionalParams : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For(typeof(IFoo)).Named("foo").LifestyleScoped().ImplementedBy(typeof(Foo)).Forward<IBar>());
        }
    }
}