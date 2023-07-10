using Microsoft.AspNetCore.Mvc;
using VehicleHub.Business.Abstract;

namespace VehicleHubAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatsController : ControllerBase
    {
        private readonly IBoatService _boatService;

        public BoatsController(IBoatService boatService)
        {
            _boatService = boatService;
        }

        //Get boats by color endpoint
        [HttpGet("{color}")]
        public IActionResult GetBoatsByColor(string color)
        {
            var boats = _boatService.GetByColor(color);
            return Ok(boats);
        }
    }
}
