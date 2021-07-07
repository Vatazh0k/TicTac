using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TicTac.Interfaces.Services;

namespace TicTac.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameConnectionController : ControllerBase
    {
        private IGameConnection _gameConnection;

        public GameConnectionController(IGameConnection gameConnection) => _gameConnection = gameConnection;

        [HttpGet]
        public ActionResult<string> Get() => Ok("Good game!");

        [HttpGet("CreateGame")]
        public ActionResult<string> CreateGame()
        {
            try
            {
                return Ok(_gameConnection.CreateGame());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("JoinGame")]
        public ActionResult CreateGame([FromBody] string Id)
        {
            try
            {
                _gameConnection.JoinGame(Id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
