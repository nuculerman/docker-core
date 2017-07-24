using DockerChatApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DockerChatApp.Data
{
    public class ChannelsDao : IAccessChannels
    {
        public Channel Create(string name)
        {
            throw new NotImplementedException();
        }

        public Channel Get(string Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Channel> GetAll()
        {
            return new List<Channel>
            {
                new Channel {Id = Guid.NewGuid().ToString(), Name="Fun with Docker" },
                new Channel {Id = Guid.NewGuid().ToString(), Name="Docker MVC Core" },
                new Channel {Id = Guid.NewGuid().ToString(), Name="Docker for Windows" }
            };
        }
    }
}
