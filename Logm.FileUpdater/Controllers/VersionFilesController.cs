using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logm.FileUpdater.Databases;
using Logm.FileUpdater.Sdk.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Logm.FileUpdater.Controllers
{
    [Route("api/[controller]")]
    public class VersionFilesController : Controller
    {
        private DatabaseContext _context;

        public VersionFilesController(DatabaseContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<VersionFile>? Get()
        {
            return _context.VersionFiles?.ToList();
        }
        
        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

