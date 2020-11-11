using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netcoreWebApi_3_1.Models;

namespace netcoreWebApi_3_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly sbtestContext context;

        public ValuesController(sbtestContext context)
        {
            this.context = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Sbtest1>> Get()
        {
            return context.Sbtest1.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Sbtest1> Get(int id)
        {
            var item = context.Sbtest1.Where(c => c.Id == id).SingleOrDefault();
            //item = myDbContext.Sbtest1.Single(c => c.id == id);
            return item;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Sbtest1 value)
        {
            context.Sbtest1.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Sbtest1 value)
        {
            if(value.Id != id)
            {
                throw new Exception("id not equeal");
            }
            context.Sbtest1.Update(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = context.Sbtest1.First(c => c.Id == id);
            //item = myDbContext.Sbtest1.Single(c => c.id == id);
            context.Sbtest1.Remove(item);
        }
    }
}
