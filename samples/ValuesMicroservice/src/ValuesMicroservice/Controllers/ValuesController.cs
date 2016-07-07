using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ValuesMicroservice.Data;
using ValuesMicroservice.Entity;

namespace ValuesMicroservice.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        protected StoredValuesContext _context;

        public ValuesController(StoredValuesContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _context.StoredValues.Select(x => x.Value).ToArray();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            _context.StoredValues.Add(new StoredValue { Value = value });
            _context.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{index}")]
        public void Delete(int index)
        {
            var valToDelete = _context.StoredValues.Skip(index).Take(1).First();
            _context.StoredValues.Remove(valToDelete);
            _context.SaveChanges();
        }
    }
}
