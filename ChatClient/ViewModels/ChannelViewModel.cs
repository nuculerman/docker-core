using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DockerChatApp.Models;

namespace ChatClient.ViewModels
{
    public class ChannelViewModel
    {
        public IList<Channel> Channels { get; set; }
    }
}
