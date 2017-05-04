// Patterns: 1
// Matches: CommonImpl1.cs
// NotMatches: Foo.cs

using LightInject;
using TestApplication.Types;

namespace TestApplication.LightInject
{
    public class RegisterInterfaceImplementationGeneric
    {
        public RegisterInterfaceImplementationGeneric()
        {
            var container = new ServiceContainer();

            container.Register<ICommon, CommonImpl1>();
        }
    }
}
