using Microsoft.AspNetCore.Mvc;
using SunProject.Classes;
using SunProject.Models;
using System.Collections.Generic;


namespace SunProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorEnergyController : ControllerBase
    {
        [HttpPost("Calculator")]
        public ActionResult Calculation(CalculatorEnergy Calculation)
        {
            return Ok(new CalculatorResult
            {
                ActualEnergyGain = 0
            }) ;
        }
    }
}
