using BowlingAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BowlingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;
        public BowlerController(IBowlingRepository temp)
        {
            _bowlingRepository = temp;
        }

        //public IEnumerable<Bowler> Get()
        //{
        //    var bowlerData = _bowlingRepository.Bowlers.ToArray();
        //    return bowlerData;
        //}

        [HttpGet("marlins-sharks")]
        public IActionResult GetBowlersForMarlinsAndSharks()
        {
            var bowlers = _bowlingRepository.GetBowlersForMarlinsAndSharks();
            return Ok(bowlers);
        }
    }
}

