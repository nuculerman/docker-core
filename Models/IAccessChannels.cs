using System;
using System.Collections.Generic;
using System.Text;

namespace DockerChatApp.Models
{
    public interface IAccessChannels
    {
        Channel Get(string Id);

        IEnumerable<Channel> GetAll();

        Channel Create(string name);

    }
}
