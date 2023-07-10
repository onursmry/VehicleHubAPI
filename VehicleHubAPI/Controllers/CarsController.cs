using Microsoft.AspNetCore.Mvc;
using VehicleHub.Business.Abstract;
using IResult = VehicleHub.Core.Utilities.Results.IResult;

namespace VehicleHubAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;


        public CarsController(ICarService carService, IBoatService boatService, IBusService busService)
        {
            _carService = carService;
        }


        //Get all vehicles endpoint
        [HttpGet]
        public IActionResult GetAllVehicles()
        {
            var cars = _carService.GetAll();
            return Ok(cars);
        }

        //Get cars by color endpoint
        [HttpGet("{color}")]
        public IActionResult GetCarsByColor(string color)
        {
            var cars = _carService.GetByColor(color);
            return Ok(cars);
        }

        //Toggle headlights endpoint
        [HttpPost("toggle-headlights/{carId}")]
        public IActionResult ToggleHeadlights(Guid carId)
        {
            IResult headlightsStatus = _carService.ToggleHeadlights(carId);
            return Ok(new { HeadlightsTurnedOn = headlightsStatus });
        }

        //Delete car endpoint
        [HttpDelete("{carId}")]
        public IActionResult DeleteCar(Guid carId)
        {
            IResult isDeleted = _carService.Delete(carId);
            if (isDeleted.Success)
            {
                return NoContent(); //Car deleted successfully, no content to return
            }

            return NotFound(); // Car not found

        }

    }
}
