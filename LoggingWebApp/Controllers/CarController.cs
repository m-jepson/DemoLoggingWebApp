using Microsoft.AspNetCore.Mvc;

namespace LoggingWebApp.Controllers
{
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        private readonly IGarage _garage;

        public CarController(IGarage garage)
        {
            _garage = garage;
        }

        [HttpGet("start")]
        public IActionResult Start()
        {
            var result = _garage.Car.Start();
            return Ok(result);
        }

        [HttpGet("stop")]
        public IActionResult Stop()
        {
            var result = _garage.Car.Stop();
            return Ok(result);
        }
    }
}
