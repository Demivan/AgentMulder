// Patterns: 1
// Matches: CommonImpl1.cs
// NotMatches: Foo.cs

using LightInject;
using TestApplication.Types;

namespace TestApplication.LightInject
{
    public class RegisterConcreteGenericLifetime
    {
        public RegisterConcreteGenericLifetime()
        {
            var container = new ServiceContainer();

            container.Register<CommonImpl1>(new PerContainerLifetime());
        }
    }
}
