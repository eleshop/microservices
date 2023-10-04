using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        // GET: api/<AdminsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "admin1", "admin2" };
        }

        // GET api/<AdminsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "admin" + " " + id;
        }

        // POST api/<AdminsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AdminsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AdminsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
