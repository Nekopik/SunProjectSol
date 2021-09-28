using Microsoft.AspNetCore.Mvc;
using SunProject.Classes;
using SunProject.Models;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SunProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorEnergyController : ControllerBase
    {
        // GET: api/<CalcEngController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CalcEngController>/5
        /* [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        */
        // POST api/<CalcEngController>
        [HttpPost("Calculator")]
        public ActionResult Calculation(CalculatorEnergy request)
        {
            return Ok(new CalculatorResult
            {
                ActualEnergyGain = 0
            }) ;
        }

        // PUT api/<CalcEngController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CalcEngController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
