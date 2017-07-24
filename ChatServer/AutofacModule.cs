using System;
using Autofac;
using DockerChatApp.Data;
using DockerChatApp.Models;

namespace ChatServer
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new ChannelsDao())
                .As<IAccessChannels>()
                .InstancePerLifetimeScope();
        }
    }
}