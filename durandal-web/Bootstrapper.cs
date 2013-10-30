using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using Autofac;
using Common.Logging;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.Conventions;
using Nancy.Responses;

namespace durandal_web
{
        public class Bootstrapper : Nancy.Bootstrappers.Autofac.AutofacNancyBootstrapper
        {
            public static readonly ILog Logger = LogManager.GetLogger(typeof(Bootstrapper));

            protected override void ApplicationStartup(ILifetimeScope container, Nancy.Bootstrapper.IPipelines pipelines)
            {
                base.ApplicationStartup(container, pipelines);
                Conventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Images"));
                Conventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Scripts"));
                Conventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Content"));
                Conventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("App"));
            }
            protected override void ConfigureApplicationContainer(ILifetimeScope container)
            {

                // Perform registrations that should have an application lifetime
                var builder = new ContainerBuilder();
              
                builder.Update(container.ComponentRegistry);

            }
            protected override void ConfigureRequestContainer(ILifetimeScope container, NancyContext context)
            {
                base.ConfigureRequestContainer(container, context);


            }
            protected override void RequestStartup(ILifetimeScope container, IPipelines pipelines, NancyContext context)
            {
                
            }
            protected override NancyInternalConfiguration InternalConfiguration
            {
                get
                {

                    return NancyInternalConfiguration.WithOverrides(
                        c =>
                        {
                            //c.Serializers.Insert(0, typeof(Nancy.Serializers.Json.ServiceStack.ServiceStackJsonSerializer));
                        });
                }
            }
        }
}