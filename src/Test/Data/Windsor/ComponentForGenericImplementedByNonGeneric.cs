﻿using AgentMulder.ReSharper.Tests.Data;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace TestApplication.Windsor
{
    public class ComponentForGenericImplementedByNonGeneric : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IFoo>().ImplementedBy(typeof(Foo)));
        }
    }
}