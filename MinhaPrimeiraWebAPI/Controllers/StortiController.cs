using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MinhaPrimeiraWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StortiController : Controller
    {
        // GET api/Storti
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Storti/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "O número digitado foi: " +  id.ToString();
        }
    }
}