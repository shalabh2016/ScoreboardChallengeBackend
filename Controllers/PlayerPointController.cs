using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ScoreboardChallenge.Model;
using ScoreboardChallenge.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ScoreboardChallenge.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PlayerPointController : ControllerBase
    {
        private readonly ILogger<PlayerPointController> _logger;

        public PlayerPointController(ILogger<PlayerPointController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{PageNumber}/{PerPage}")]
        public async Task<IActionResult> GetPlayers(int? PageNumber, int? PerPage)
        {
            try
            {
                var db = new PlayerPointDbContext();
                var players = await PaginatedList<PlayerPointModel>.CreateAsync(db.PlayerPoint.AsQueryable().AsNoTracking(), PageNumber ?? 1, PerPage ?? 10);
                var totalPlayers = await db.PlayerPoint.CountAsync();
                return new OkObjectResult(new { data = players, totalPlayers = totalPlayers});
             }
            catch (Exception e)
            {
                return new BadRequestObjectResult("There is an error, please try again.");
            }
        }

        [HttpPost]
        public async Task<string> AddNewPlayer([FromBody] PlayerPointModel model)
        {
            try{
                var db = new PlayerPointDbContext();   
                db.PlayerPoint.Add(model);
                db.SaveChanges();

                return "Successfully added new Player with Points.";
            }catch(Exception e)
            {
                _logger.LogError($"There is an error in adding data: {e.Message}");
                return $"There is an error in adding data: {e.Message}";
            }
          
        }
    }
}
