using CaseVotaRestaurante.Application.DTOs;
using CaseVotaRestaurante.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CaseVotaRestaurante.WebUI.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantService _restaurantService;
        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var restaurants = await _restaurantService.GetAllRestaurantAsync();
            return View(restaurants);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(RestaurantDTO restaurant)
        {
            if (ModelState.IsValid)
            {
                await _restaurantService.CreateAsync(restaurant);
                return RedirectToAction(nameof(Index));
            }
            return View(restaurant);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null)
            
                return NotFound();
            var restaurantDto = await _restaurantService.GetRestaurantByIdAsync(id);

            if (restaurantDto == null) return NotFound();

            return View(restaurantDto);
        }

        [HttpPost(), ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _restaurantService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
