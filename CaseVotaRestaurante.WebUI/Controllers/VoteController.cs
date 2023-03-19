using CaseVotaRestaurante.Application.DTOs;
using CaseVotaRestaurante.Application.Interfaces;
using CaseVotaRestaurante.Infra.Data.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Framework;

namespace CaseVotaRestaurante.WebUI.Controllers
{
    public class VoteController : Controller
    {
        private readonly IRestaurantService _restaurantService;
        private readonly IPeopleService _peopleService;
        private readonly IVoteService _voteService;
        public VoteController(IVoteService voteService, IPeopleService peopleService, IRestaurantService restaurantService)
        {
            _voteService = voteService;
            _peopleService = peopleService;
            _restaurantService = restaurantService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var votes = await _voteService.GetAllVoteAsync(); 
            return View(votes);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.RestaurantId = new SelectList(await _restaurantService.GetAllRestaurantAsync(), "Id", "Name");
            ViewBag.PeopleId = new SelectList(await _peopleService.GetAllPeopleAsync(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(VoteDTO vote)
        {
            if(ModelState.IsValid)
            {
                await _voteService.CreateVoteAsync(vote);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        //[HttpGet]
        //public async Task<IActionResult> Vencedor()
        //{
        //    var vencedor = await _voteService.GetAllVoteAsync().
        //}

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)

                return NotFound();
            var voteDto = await _restaurantService.GetRestaurantByIdAsync(id);

            if (voteDto == null) return NotFound();

            return View(voteDto);
        }

        [HttpPost(), ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _restaurantService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
