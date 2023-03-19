using CaseVotaRestaurante.Application.DTOs;
using CaseVotaRestaurante.Application.Interfaces;
using CaseVotaRestaurante.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaseVotaRestaurante.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoteController : ControllerBase
    {
        private readonly IVoteService _voteService;
        public VoteController(IVoteService voteService)
        {
            _voteService = voteService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VoteDTO>>> Get()
        {
            var vote = await _voteService.GetAllVoteAsync();
            if (vote == null)
            {
                return NotFound("Restaurant not found");
            }
            return Ok(vote);
        }        

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] VoteDTO voteDto)
        {
            if (voteDto == null)
                return BadRequest("Invalid Data");


            await _voteService.CreateVoteAsync(voteDto);

            return new CreatedAtRouteResult("GetRestaurant", new { id = voteDto.Id }, voteDto);
        }
    }
}   
