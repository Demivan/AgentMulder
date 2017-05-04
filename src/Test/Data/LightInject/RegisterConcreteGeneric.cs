// Patterns: 1
// Matches: CommonImpl1.cs
// NotMatches: Foo.cs

using LightInject;
using TestApplication.Types;

namespace TestApplication.LightInject
{
    public class RegisterConcreteGeneric
    {
        public RegisterConcreteGeneric()
        {
            var container = new ServiceContainer();

            container.Register<CommonImpl1>();
        }
    }
}
