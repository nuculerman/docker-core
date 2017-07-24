using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using DockerChatApp.Models;
using Newtonsoft.Json;
using ChatClient.ViewModels;

namespace ChatClient.Controllers
{
    public class ChannelsController : Controller
    {
        public IActionResult Index()
        {
            var channelsString = "";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://chatserver");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                var response = client.GetAsync("/api/channels").Result;
                channelsString = response.Content.ReadAsStringAsync().Result;
            }

            var channels = JsonConvert.DeserializeObject<List<Channel>>(channelsString);

            return View(new ChannelViewModel { Channels = channels });

        }
    }
}