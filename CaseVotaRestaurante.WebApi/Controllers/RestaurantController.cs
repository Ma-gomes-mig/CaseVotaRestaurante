using CaseVotaRestaurante.Application.DTOs;
using CaseVotaRestaurante.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaseVotaRestaurante.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;
        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RestaurantDTO>>> Get()
        {
            var restaurant = await _restaurantService.GetAllRestaurantAsync();
            if(restaurant == null)
            {
                return NotFound("Restaurant not found");
            }
            return Ok(restaurant);
        }
    }
}
