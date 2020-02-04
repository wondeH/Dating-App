using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //_ before the name of the variable represents private
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;

        }
        // GET api/values
        [HttpGet] //IActionResults return the value and http response to the client
        public async Task<IActionResult> GetValues()
        {
            //retrieves the values from the db as a list
            var values = await _context.Values.ToListAsync(); 

            return Ok(values); //returns http ok message then the db values
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {   //this searches for a specific value, 
        //used first or default instead of first as it returns null if value is not found oposed to returning just a exception 
        //FirstOrDefault uses lambda where x represents the value we are returning
        // we match the both the ids and return the value that matched the id
            var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value); 
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
