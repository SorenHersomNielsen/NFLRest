using Microsoft.AspNetCore.Mvc;
using NFLRest.Manager;
using NFLRest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NFLRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NFLController : ControllerBase
    {
        private readonly NFLManager NFLManager = new NFLManager();


        // GET: api/<NFLController>
        [HttpGet]
        public IEnumerable<NFLModel> Get()
        {
            return NFLManager.GetAll();
        }

        // GET api/<NFLController>/5
        [HttpGet("{id}")]
        public NFLModel Get(int id)
        {
            return NFLManager.GetByID(id);
        }

        // POST api/<NFLController>
        [HttpPost]
        public NFLModel Post([FromBody] NFLModel value)
        {
            return NFLManager.Add(value);
        }

        // PUT api/<NFLController>/5
        [HttpPut("{id}")]
        public NFLModel Put(int id, [FromBody] NFLModel value)
        {
            return NFLManager.Update(id, value);
        }

        // DELETE api/<NFLController>/5
        [HttpDelete("{id}")]
        public NFLModel Delete(int id)
        {
            return NFLManager.Delete(id);
        }
    }
}
