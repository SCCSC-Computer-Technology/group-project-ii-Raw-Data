
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RawDataWebapp.Services; 
using System.Threading.Tasks;

namespace RawDataWebapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly SportsDbClient _sportsDbClient;

        // Inject SportsDbClient through the constructor
        public PlayersController(SportsDbClient sportsDbClient)
        {
            _sportsDbClient = sportsDbClient;
        }

        [HttpGet("searchplayers")]
        public async Task<IActionResult> SearchPlayersByName(string name)
        {
            try
            {
                var players = await _sportsDbClient.SearchPlayersByNameAsync(name);
                return Ok(players);
            }
            catch (HttpRequestException)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, "Error accessing Sports DB API");
            }
        }
    }
}
