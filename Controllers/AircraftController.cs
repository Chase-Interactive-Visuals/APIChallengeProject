using APIChallengeProject.Interfaces;
using APIChallengeProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIChallengeProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AircraftController : Controller
    {
        private readonly IAircraftRepository _aircraftrepository;

        public AircraftController(IAircraftRepository aircraftRepository)
        {
            _aircraftrepository = aircraftRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Aircraft>))]
        public IActionResult GetAircrafts()
        {
            var aircrafts = _aircraftrepository.GetAircrafts();
            if (!ModelState.IsValid) 
                return BadRequest(ModelState);

            return Ok(aircrafts);
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(Aircraft))]
        public IActionResult GetAircraft(int aircraftID)
        {
            if (!_aircraftrepository.AircraftExist(aircraftID))
                return NotFound();

            var aircraft = _aircraftrepository.GetAircraftById(aircraftID);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(aircraft);
        }

        /*
        [HttpPost("/aircraft/{aircraftId}/duelist")]
        [ProducesResponseType(200, Type = typeof(Aircraft))]
        [ProducesResponseType(400)]
        public async Task<ActionResult<List<AircraftTasks>>> PostAircraft(int aircraftId, AircraftTasks? tasks)
        {

        }
        */
        
        
    }
}
