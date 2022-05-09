using DigiVisio2030.BL.Cities;
using DigiVisio2030.BL.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigiVisio2030.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : ControllerBase
    {
        private readonly ICitiesService _citiesService;

        public CitiesController(ICitiesService citiesService)
        {
            _citiesService = citiesService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CityDTO>>> GetAllCities()
        {
            var cities = await _citiesService.GetAllCities();
            return Ok(cities);
        }
    }
}
