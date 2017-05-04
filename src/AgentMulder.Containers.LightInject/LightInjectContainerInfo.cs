using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Reflection;

using AgentMulder.ReSharper.Domain.Containers;

namespace AgentMulder.Containers.LightInject
{
    public class LightInjectContainerInfo : ContainerInfoBase
    {
        public override IEnumerable<string> ContainerQualifiedNames
        {
            get
            {
                yield return "LightInject";
            }
        }

        public override string ContainerDisplayName
        {
            get { return "LightInject"; }
        }

        protected override ComposablePartCatalog GetComponentCatalog()
        {
            return new AssemblyCatalog(Assembly.GetExecutingAssembly());
        }
    }
}