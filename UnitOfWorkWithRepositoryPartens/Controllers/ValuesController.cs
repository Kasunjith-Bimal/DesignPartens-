using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitOfWorkWithRepositoryPartens.Data.Models;
using UnitOfWorkWithRepositoryPartens.Interface.Servise;

namespace UnitOfWorkWithRepositoryPartens.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        public ITestServise _dataServise;
        public ValuesController(ITestServise dataServise)
        {
            _dataServise = dataServise;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Test> Get()
        {
            return _dataServise.getAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
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
