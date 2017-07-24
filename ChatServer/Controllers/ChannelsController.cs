using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DockerChatApp.Models;

namespace ChatServer.Controllers
{
    [Route("api/[controller]")]
    public class ChannelsController : Controller
    {
        private readonly IAccessChannels channelsDao;

        public ChannelsController(IAccessChannels channelsDao_)
        {
            channelsDao = channelsDao_;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Channel> Get()
        {
            return channelsDao.GetAll();
        }

        // GET api/values/5
        [HttpGet("{name}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
