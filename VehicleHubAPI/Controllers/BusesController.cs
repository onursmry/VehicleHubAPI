using Microsoft.AspNetCore.Mvc;
using VehicleHub.Business.Abstract;

namespace VehicleHubAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusesController : ControllerBase
    {
        private readonly IBusService _busService;

        public BusesController(IBusService busService)
        {
            _busService = busService;
        }

        //Get buses by color endpoint
        [HttpGet("{color}")]
        public IActionResult GetBusesByColor(string color)
        {
            var buses = _busService.GetByColor(color);
            return Ok(buses);
        }
    }
}
