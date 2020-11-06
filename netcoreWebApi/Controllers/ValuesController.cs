using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netcoreWebApi.Entities;

namespace netcoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly MyDbContext myDbContext;

        public ValuesController(MyDbContext myDbContext)
        {
            this.myDbContext = myDbContext;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Sbtest1>> Get()
        {
            return myDbContext.Sbtest1.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Sbtest1> Get(int id)
        {
            var item = myDbContext.Sbtest1.Where(c => c.id == id).SingleOrDefault();
            //item = myDbContext.Sbtest1.Single(c => c.id == id);
            return item;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Sbtest1 value)
        {
            myDbContext.Sbtest1.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Sbtest1 value)
        {
            if(value.id != id)
            {
                throw new Exception("id not equeal");
            }
            myDbContext.Sbtest1.Update(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = myDbContext.Sbtest1.First(c => c.id == id);
            //item = myDbContext.Sbtest1.Single(c => c.id == id);
            myDbContext.Sbtest1.Remove(item);
        }
    }
}
