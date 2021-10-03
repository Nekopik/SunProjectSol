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
        public ActionResult Calculation(CalculatorEnergy c)
        {
            return Ok(new CalculatorResult
            {
                ActualEnergyGain = (c.Insolation*c.WspKor*c.Power*c.WW)/c.NatProm
            });
        }
    }
}
