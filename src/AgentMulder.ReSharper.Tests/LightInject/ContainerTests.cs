using AgentMulder.Containers.LightInject;

namespace AgentMulder.ReSharper.Tests.LightInject
{
    [TestWithNuGetPackage(Packages = new[] { "LightInject/4.1.5" })]
    public class ContainerTests : AgentMulderTestBase<LightInjectContainerInfo>
    {
        protected override string RelativeTestDataPath => "LightInject";
    }
}
